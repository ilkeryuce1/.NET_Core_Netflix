using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Netflix.Models;
using System.Diagnostics;

namespace Netflix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signin(Account account)
        {


            return View(account);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}