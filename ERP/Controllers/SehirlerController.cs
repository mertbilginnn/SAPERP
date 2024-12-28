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
    public class SehirlerController : Controller
    {
        private readonly AppDbContext _context;

        public SehirlerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Sehirler
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMGEN004.Include(b => b.COUNTRY);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Sehirler/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN004 = await _context.BSMGRNNMGEN004
                .Include(b => b.COUNTRY)
                .FirstOrDefaultAsync(m => m.CITYCODE == id);
            if (bSMGRNNMGEN004 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMGEN004);
        }

        // GET: Sehirler/Create
        public IActionResult Create()
        {
            ViewData["COUNTRYCODE"] = new SelectList(_context.BSMGRNNMGEN003, "COUNTRYCODE", "COUNTRYCODE");
            return View();
        }

        // POST: Sehirler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CITYCODE,CITYTEXT,COUNTRYCODE")] BSMGRNNMGEN004 bSMGRNNMGEN004)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMGEN004);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["COUNTRYCODE"] = new SelectList(_context.BSMGRNNMGEN003, "COUNTRYCODE", "COUNTRYCODE", bSMGRNNMGEN004.COUNTRYCODE);
            return View(bSMGRNNMGEN004);
        }

        // GET: Sehirler/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN004 = await _context.BSMGRNNMGEN004.FindAsync(id);
            if (bSMGRNNMGEN004 == null)
            {
                return NotFound();
            }
            ViewData["COUNTRYCODE"] = new SelectList(_context.BSMGRNNMGEN003, "COUNTRYCODE", "COUNTRYCODE", bSMGRNNMGEN004.COUNTRYCODE);
            return View(bSMGRNNMGEN004);
        }

        // POST: Sehirler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CITYCODE,CITYTEXT,COUNTRYCODE")] BSMGRNNMGEN004 bSMGRNNMGEN004)
        {
            if (id != bSMGRNNMGEN004.CITYCODE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMGEN004);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMGEN004Exists(bSMGRNNMGEN004.CITYCODE))
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
            ViewData["COUNTRYCODE"] = new SelectList(_context.BSMGRNNMGEN003, "COUNTRYCODE", "COUNTRYCODE", bSMGRNNMGEN004.COUNTRYCODE);
            return View(bSMGRNNMGEN004);
        }

        // GET: Sehirler/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN004 = await _context.BSMGRNNMGEN004
                .Include(b => b.COUNTRY)
                .FirstOrDefaultAsync(m => m.CITYCODE == id);
            if (bSMGRNNMGEN004 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMGEN004);
        }

        // POST: Sehirler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMGEN004 = await _context.BSMGRNNMGEN004.FindAsync(id);
            if (bSMGRNNMGEN004 != null)
            {
                _context.BSMGRNNMGEN004.Remove(bSMGRNNMGEN004);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMGEN004Exists(string id)
        {
            return _context.BSMGRNNMGEN004.Any(e => e.CITYCODE == id);
        }
    }
}
