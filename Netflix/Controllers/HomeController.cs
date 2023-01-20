using BusinnessLayer.Concrete;
using DataAceesLayer.Concrete;
using DataAceesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Netflix.Models;
using System.Diagnostics;

namespace Netflix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Context c= new Context();
        
        AccountManager am = new AccountManager(new EfAccountRepositories());
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signin(Account t,int id)
        {

            var data = c.Tbl_Accounts.FirstOrDefault(x => x.Email == t.Email);

            if (data!=null)//email kayıtlı ıse 
            {
                var parola = c.Tbl_Accounts.FirstOrDefault(x => x.Email == t.Email && t.Password == x.Password);
                if (parola!=null)
                {
                    var odemekontrol = c.Tbl_Accounts.FirstOrDefault(a => a.Isverified == true);
                    if (odemekontrol == null)
                    {
                        return RedirectToAction("Odemekontrol");

                    }
                    else
                    {
                        return RedirectToAction("Index", "MovieHomePage");
                    }
                }
                else
                {
                    ViewBag.Message = "Parolanız Yanlış Tekrar deneyiniz";

                }
            }
            else
            {
                ViewBag.Message = "Email Kayıtlarda bulunamadı Lütfen Kontrol Ediniz";

            }
            return View();

		}
        public IActionResult Odemekontrol(int id)
        {
            if (id == null)
            {
                return View("Index");

            }
            ViewBag.odeme = "Ödeme yapmalısınız";

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Odemekontrol(Account t ,int id)
        {
          
            t.Isverified = true;
            am.Update(t);
            return RedirectToAction("Index", "MovieHomePage");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}