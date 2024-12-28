using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Context;
using ERP.Models.Kontrol.Genel;

namespace ERP.Controllers
{
    public class UlkelerController : Controller
    {
        private readonly AppDbContext _context;

        public UlkelerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Ulkeler
        public async Task<IActionResult> Index()
        {
            return View(await _context.BSMGRNNMGEN003.ToListAsync());
        }

        // GET: Ulkeler/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN003 = await _context.BSMGRNNMGEN003
                .FirstOrDefaultAsync(m => m.COUNTRYCODE == id);
            if (bSMGRNNMGEN003 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMGEN003);
        }

        // GET: Ulkeler/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ulkeler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COUNTRYCODE,COUNTRYNAME")] BSMGRNNMGEN003 bSMGRNNMGEN003)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMGEN003);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMGRNNMGEN003);
        }

        // GET: Ulkeler/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN003 = await _context.BSMGRNNMGEN003.FindAsync(id);
            if (bSMGRNNMGEN003 == null)
            {
                return NotFound();
            }
            return View(bSMGRNNMGEN003);
        }

        // POST: Ulkeler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COUNTRYCODE,COUNTRYNAME")] BSMGRNNMGEN003 bSMGRNNMGEN003)
        {
            if (id != bSMGRNNMGEN003.COUNTRYCODE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMGEN003);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMGEN003Exists(bSMGRNNMGEN003.COUNTRYCODE))
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
            return View(bSMGRNNMGEN003);
        }

        // GET: Ulkeler/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN003 = await _context.BSMGRNNMGEN003
                .FirstOrDefaultAsync(m => m.COUNTRYCODE == id);
            if (bSMGRNNMGEN003 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMGEN003);
        }

        // POST: Ulkeler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMGEN003 = await _context.BSMGRNNMGEN003.FindAsync(id);
            if (bSMGRNNMGEN003 != null)
            {
                _context.BSMGRNNMGEN003.Remove(bSMGRNNMGEN003);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMGEN003Exists(string id)
        {
            return _context.BSMGRNNMGEN003.Any(e => e.COUNTRYCODE == id);
        }
    }
}
