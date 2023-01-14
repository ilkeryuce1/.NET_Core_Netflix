using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAceesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using BusinnessLayer.Concrete;
using DataAceesLayer.EntityFramework;

namespace Netflix.Controllers
{
    public class MovieKindsController : Controller
    {
        Context _context = new Context();

        MovieKindManager mkm = new MovieKindManager(new EfMovieKindRepositories());

        // GET: MovieKinds
        public async Task<IActionResult> Index()
        {
            var list =mkm.GetAllList();
            return View(list);
        }

        // GET: MovieKinds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tbl_MovieKinds == null)
            {
                return NotFound();
            }

            var movieKind = await _context.Tbl_MovieKinds
                .FirstOrDefaultAsync(m => m.MovieKindId == id);
            if (movieKind == null)
            {
                return NotFound();
            }

            return View(movieKind);
        }

        // GET: MovieKinds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MovieKinds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieKindId,MovieKindName,Description")] MovieKind movieKind)
        {
            mkm.Add(movieKind);
                return RedirectToAction(nameof(Index));
            
        }

        // GET: MovieKinds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tbl_MovieKinds == null)
            {
                return NotFound();
            }

            var movieKind = await _context.Tbl_MovieKinds.FindAsync(id);
            if (movieKind == null)
            {
                return NotFound();
            }
            return View(movieKind);
        }

        // POST: MovieKinds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieKindId,MovieKindName,Description")] MovieKind movieKind)
        {
            if (id != movieKind.MovieKindId)
            {
                return NotFound();
            }

                  mkm.Update(movieKind);
           
                
                return RedirectToAction(nameof(Index));
            
            
        }

        // GET: MovieKinds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tbl_MovieKinds == null)
            {
                return NotFound();
            }

            var movieKind = await _context.Tbl_MovieKinds
                .FirstOrDefaultAsync(m => m.MovieKindId == id);
            if (movieKind == null)
            {
                return NotFound();
            }

            return View(movieKind);
        }

        // POST: MovieKinds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tbl_MovieKinds == null)
            {
                return Problem("Entity set 'Context.Tbl_MovieKinds'  is null.");
            }
            var movieKind = await _context.Tbl_MovieKinds.FindAsync(id);
            if (movieKind != null)
            {
                _context.Tbl_MovieKinds.Remove(movieKind);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieKindExists(int id)
        {
          return (_context.Tbl_MovieKinds?.Any(e => e.MovieKindId == id)).GetValueOrDefault();
        }
    }
}
