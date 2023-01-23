using DataAceesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Netflix.ViewComponents
{
    public class Action:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            EfMovieRepositories mr = new EfMovieRepositories();
            var value = mr.GetListAll().Where(x => x.MovieKindId == 1).OrderByDescending(x => x.MovieId).Take(10);
            return View(value);
        }
    }
}
