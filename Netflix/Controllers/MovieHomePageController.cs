using BusinnessLayer.Concrete;
using DataAceesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Netflix.Controllers
{
	public class MovieHomePageController : Controller
	{
		MovieManager mm = new MovieManager(new EfMovieRepositories());
		public IActionResult Index()
		{
			var values = mm.GetAllList();
			return View(values);
		}
	}
}
