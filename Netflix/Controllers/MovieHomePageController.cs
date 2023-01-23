using BusinnessLayer.Concrete;
using DataAceesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Netflix.Controllers
{
    [AllowAnonymous]

    public class MovieHomePageController : Controller
	{
		MovieManager mm = new MovieManager(new EfMovieRepositories());
		public IActionResult Index()
        {
            if (TempData["v"] == null)
            {
                return RedirectToAction("Index", "Home");

            }
            var values = mm.GetAllList().OrderByDescending(x => x.MovieId); return View(values);
		}
        public async Task<IActionResult> Details(int id)
        {
            if (TempData["v"] == null)
            {
                return RedirectToAction("Index", "Home");

            }
            if (TempData["v"] == null )
            {
                return RedirectToAction("Index", "Home");

            }
            if (id == null)
            {
                return NotFound();
            }

            var movie = mm.GetById(id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }



    }
}
