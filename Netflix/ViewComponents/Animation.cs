using DataAceesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Netflix.ViewComponents
{
    public class Animation:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            EfMovieRepositories mr = new EfMovieRepositories();
            var value = mr.GetListAll().Where(x => x.MovieKindId == 7).OrderByDescending(x => x.MovieId).Take(10);
            return View(value);
        }
    }
}
