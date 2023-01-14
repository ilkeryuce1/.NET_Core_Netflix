using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAceesLayer.Concrete;
using EntityLayer.Concrete;
using BusinnessLayer.Concrete;
using DataAceesLayer.EntityFramework;

namespace Netflix.Controllers
{
    public class Movies1Controller : Controller
    {
    Context c= new Context();


        MovieManager mm = new MovieManager(new EfMovieRepositories());
        public IActionResult Index()
        {
            var values = mm.GetAllList();
            return View(values);
        }
      
        // GET: Movies1
      

        // GET: Movies1/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null )
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

        //GET: Movies1/Create
        public IActionResult Create()
        {
            ViewData["MovieKindId"] = new SelectList(c.Tbl_MovieKinds, "MovieKindId", "MovieKindName");
            return View();
        }

        //POST: Movies1/Create
        //To protect from overposting attacks, enable the specific properties you want to bind to.
        //For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

       [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieName,Description,MovieYear,Episodes,MovieKindId,CoverPhotoLink,TrailerLink")] Movie movie)
        {
        
                mm.Add(movie);
                ViewData["Ekle"] = "Film Başarıyla Eklendi";
                return RedirectToAction(nameof(Index));
            
            //ViewData["MovieKindId"] = new SelectList(c.Tbl_MovieKinds, "MovieKindId", "MovieKindName", movie.MovieKindId);
            //return View(movie);
        }

        //GET: Movies1/Edit/5
         public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || c.Tbl_Movies == null)
            {
                return NotFound();
            }

            var movie = await c.Tbl_Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            ViewData["MovieKindId"] = new SelectList(c.Tbl_MovieKinds, "MovieKindId", "MovieKindName", movie.MovieKindId);
            return View(movie);
        }

        //POST: Movies1/Edit/5
        //  To protect from overposting attacks, enable the specific properties you want to bind to.
        //  For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("MovieId,MovieName,Description,MovieYear,Episodes,MovieKindId,CoverPhotoLink,TrailerLink")] Movie movie)
        {
            if (id != movie.MovieId)
            {
                return NotFound();
            }

            c.Update(movie);
            c.SaveChanges();
            ViewData["MovieKindId"] = new SelectList(c.Tbl_MovieKinds, "MovieKindId", "MovieKindName", movie.MovieKindId);
            return RedirectToAction(nameof(Index));
        }

        //GET: Movies1/Delete/5
         public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || c.Tbl_Movies == null)
            {
                return NotFound();
            }

            var movie = await c.Tbl_Movies
                .Include(m => m.MovieKind)
                .FirstOrDefaultAsync(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        //POST: Movies1/Delete/5
         [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (c.Tbl_Movies == null)
            {
                return Problem("Entity set 'Context.Tbl_Movies'  is null.");
            }
            var movie = await c.Tbl_Movies.FindAsync(id);
            if (movie != null)
            {
                c.Tbl_Movies.Remove(movie);
            }

            await c.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return (c.Tbl_Movies?.Any(e => e.MovieId == id)).GetValueOrDefault();
        }
    }
}
