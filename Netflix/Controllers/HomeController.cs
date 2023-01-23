using BusinnessLayer.Concrete;
using DataAceesLayer.Concrete;
using DataAceesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Netflix.Models;
using System.Diagnostics;

namespace Netflix.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        int ids = 0;

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
        public async Task<IActionResult> Signin(Account t )
        {
           
          
            var data = c.Tbl_Accounts.FirstOrDefault(x => x.Email == t.Email);

            if (data!=null)//email kayıtlı ıse 
            {
                var parola = c.Tbl_Accounts.FirstOrDefault(x => x.Email == t.Email && t.Password == x.Password);
                if (parola!=null)
                {
                 
                    var Id=c.Tbl_Accounts.Where(x=>x.Email==t.Email).Select(a=>a.AccountId).FirstOrDefault();
                    ids = Id;
                    TempData["v"] = Id;
                    



                    var odemekontrol = c.Tbl_Accounts.Where(a=>a.AccountId==Id).FirstOrDefault(a => a.Isverified == true); 
                    if (odemekontrol == null )
                    {
                        return RedirectToAction("Odemekontrol");
                        
                    }
                    else
                    {
                        var data1 = c.Tbl_Accounts.FirstOrDefault(x => x.Email == t.Email&&x.AccountId==3);

                        if (data1==null)
                        {
                            return RedirectToAction("Index", "MovieHomePage");

                        }
                        else
                        {
                            return RedirectToAction("Index", "Movies1");

                        }
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
        [HttpGet]
        public IActionResult Odemekontrol(int? id)
        {
            id = int.Parse(TempData["v"].ToString());
            if (TempData["v"] == null)
            {
                return RedirectToAction("Index", "Home");

            }

            return View();
        }
        [HttpPost]
        public IActionResult Odemekontrol(Account t,  int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
         

            }

            id = ids;
            using (var context = new Context())
            {
                // İlgili satırı veri tabanından okuyun
                var item = context.Tbl_Accounts.FirstOrDefault(i => i.AccountId == id);

                // Eğer satır bulunduysa, sütunu değiştirin
                if (item != null)
                {
                    item.Isverified = true;
                    am.Update(item);
                 
                    return RedirectToAction("Index", "MovieHomePage");

                }
            }

           


            ViewBag.odeme = "başarısız";
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}