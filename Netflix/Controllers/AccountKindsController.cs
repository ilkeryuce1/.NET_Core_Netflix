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
using DataAceesLayer.Abstract;

namespace Netflix.Controllers
{
    public class AccountKindsController : Controller
    {
        Context _context = new Context();

        AccountKindManager akm = new AccountKindManager(new EfAccountKindRepositories());

        // GET: AccountKinds
        public IActionResult Index()
        {
           var list= akm.GetAllList();
            return View(list);
        }

        // GET: AccountKinds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tbl_AccountKinds == null)
            {
                return NotFound();
            }

            var accountKind = await _context.Tbl_AccountKinds
                .FirstOrDefaultAsync(m => m.AccounKindtId == id);
            if (accountKind == null)
            {
                return NotFound();
            }

            return View(accountKind);
        }

        // GET: AccountKinds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccountKinds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccounKindtId,AccounName")] AccountKind accountKind)
        {
            akm.Add(accountKind);
            
                return RedirectToAction(nameof(Index));
            
        }

        // GET: AccountKinds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tbl_AccountKinds == null)
            {
                return NotFound();
            }

            var accountKind = await _context.Tbl_AccountKinds.FindAsync(id);
            if (accountKind == null)
            {
                return NotFound();
            }
            return View(accountKind);
        }

        // POST: AccountKinds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccounKindtId,AccounName")] AccountKind accountKind)
        {
            if (id != accountKind.AccounKindtId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountKind);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountKindExists(accountKind.AccounKindtId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(accountKind);
        }

        // GET: AccountKinds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tbl_AccountKinds == null)
            {
                return NotFound();
            }

            var accountKind = await _context.Tbl_AccountKinds
                .FirstOrDefaultAsync(m => m.AccounKindtId == id);
            if (accountKind == null)
            {
                return NotFound();
            }

            return View(accountKind);
        }

        // POST: AccountKinds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tbl_AccountKinds == null)
            {
                return Problem("Entity set 'Context.Tbl_AccountKinds'  is null.");
            }
            var accountKind = await _context.Tbl_AccountKinds.FindAsync(id);
            if (accountKind != null)
            {
                _context.Tbl_AccountKinds.Remove(accountKind);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountKindExists(int id)
        {
          return (_context.Tbl_AccountKinds?.Any(e => e.AccounKindtId == id)).GetValueOrDefault();
        }
    }
}
