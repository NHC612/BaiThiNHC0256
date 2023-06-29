using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaiThiNHC.Models;

namespace BaiThiNHC.Controllers
{
    public class NHCcau3Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public NHCcau3Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NHCcau3
        public async Task<IActionResult> Index()
        {
              return _context.NHCcau3 != null ? 
                          View(await _context.NHCcau3.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NHCcau3'  is null.");
        }

        // GET: NHCcau3/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NHCcau3 == null)
            {
                return NotFound();
            }

            var nHCcau3 = await _context.NHCcau3
                .FirstOrDefaultAsync(m => m.MaSinhVien == id);
            if (nHCcau3 == null)
            {
                return NotFound();
            }

            return View(nHCcau3);
        }

        // GET: NHCcau3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NHCcau3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSinhVien,TenSinhVien,Address")] NHCcau3 nHCcau3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nHCcau3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nHCcau3);
        }

        // GET: NHCcau3/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NHCcau3 == null)
            {
                return NotFound();
            }

            var nHCcau3 = await _context.NHCcau3.FindAsync(id);
            if (nHCcau3 == null)
            {
                return NotFound();
            }
            return View(nHCcau3);
        }

        // POST: NHCcau3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaSinhVien,TenSinhVien,Address")] NHCcau3 nHCcau3)
        {
            if (id != nHCcau3.MaSinhVien)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nHCcau3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NHCcau3Exists(nHCcau3.MaSinhVien))
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
            return View(nHCcau3);
        }

        // GET: NHCcau3/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NHCcau3 == null)
            {
                return NotFound();
            }

            var nHCcau3 = await _context.NHCcau3
                .FirstOrDefaultAsync(m => m.MaSinhVien == id);
            if (nHCcau3 == null)
            {
                return NotFound();
            }

            return View(nHCcau3);
        }

        // POST: NHCcau3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NHCcau3 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NHCcau3'  is null.");
            }
            var nHCcau3 = await _context.NHCcau3.FindAsync(id);
            if (nHCcau3 != null)
            {
                _context.NHCcau3.Remove(nHCcau3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NHCcau3Exists(string id)
        {
          return (_context.NHCcau3?.Any(e => e.MaSinhVien == id)).GetValueOrDefault();
        }
    }
}
