﻿using DataAceesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Netflix.ViewsComponents
{
    public class Horrors:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            EfMovieRepositories mr= new EfMovieRepositories();
            var value = mr.GetListAll().Where(x => x.MovieKindId == 3).OrderByDescending(x=>x.MovieId).Take(10);
            return View(value);
        }
    }
}
