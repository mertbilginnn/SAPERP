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
    public class FirmalarController : Controller
    {
        private readonly AppDbContext _context;

        public FirmalarController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Firmalar
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMGEN001.Include(b => b.CITY).Include(b => b.COUNTRY);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Firmalar/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN001 = await _context.BSMGRNNMGEN001
                .Include(b => b.CITY)
                .Include(b => b.COUNTRY)
                .FirstOrDefaultAsync(m => m.COMCODE == id);
            if (bSMGRNNMGEN001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMGEN001);
        }

        // GET: Firmalar/Create
        public IActionResult Create()
        {
            ViewData["CITYCODE"] = new SelectList(_context.BSMGRNNMGEN004, "CITYCODE", "CITYCODE");
            ViewData["COUNTRYCODE"] = new SelectList(_context.BSMGRNNMGEN003, "COUNTRYCODE", "COUNTRYCODE");
            return View();
        }

        // POST: Firmalar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,COMTEXT,ADRESS1,ADRESS2,CITYCODE,COUNTRYCODE")] BSMGRNNMGEN001 bSMGRNNMGEN001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMGEN001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CITYCODE"] = new SelectList(_context.BSMGRNNMGEN004, "CITYCODE", "CITYCODE", bSMGRNNMGEN001.CITYCODE);
            ViewData["COUNTRYCODE"] = new SelectList(_context.BSMGRNNMGEN003, "COUNTRYCODE", "COUNTRYCODE", bSMGRNNMGEN001.COUNTRYCODE);
            return View(bSMGRNNMGEN001);
        }

        // GET: Firmalar/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN001 = await _context.BSMGRNNMGEN001.FindAsync(id);
            if (bSMGRNNMGEN001 == null)
            {
                return NotFound();
            }
            ViewData["CITYCODE"] = new SelectList(_context.BSMGRNNMGEN004, "CITYCODE", "CITYCODE", bSMGRNNMGEN001.CITYCODE);
            ViewData["COUNTRYCODE"] = new SelectList(_context.BSMGRNNMGEN003, "COUNTRYCODE", "COUNTRYCODE", bSMGRNNMGEN001.COUNTRYCODE);
            return View(bSMGRNNMGEN001);
        }

        // POST: Firmalar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,COMTEXT,ADRESS1,ADRESS2,CITYCODE,COUNTRYCODE")] BSMGRNNMGEN001 bSMGRNNMGEN001)
        {
            if (id != bSMGRNNMGEN001.COMCODE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMGEN001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMGEN001Exists(bSMGRNNMGEN001.COMCODE))
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
            ViewData["CITYCODE"] = new SelectList(_context.BSMGRNNMGEN004, "CITYCODE", "CITYCODE", bSMGRNNMGEN001.CITYCODE);
            ViewData["COUNTRYCODE"] = new SelectList(_context.BSMGRNNMGEN003, "COUNTRYCODE", "COUNTRYCODE", bSMGRNNMGEN001.COUNTRYCODE);
            return View(bSMGRNNMGEN001);
        }

        // GET: Firmalar/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN001 = await _context.BSMGRNNMGEN001
                .Include(b => b.CITY)
                .Include(b => b.COUNTRY)
                .FirstOrDefaultAsync(m => m.COMCODE == id);
            if (bSMGRNNMGEN001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMGEN001);
        }

        // POST: Firmalar/Delete/5
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMGEN001 = await _context.BSMGRNNMGEN001.FindAsync(id);
            if (bSMGRNNMGEN001 != null)
            {
                _context.BSMGRNNMGEN001.Remove(bSMGRNNMGEN001);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMGEN001Exists(string id)
        {
            return _context.BSMGRNNMGEN001.Any(e => e.COMCODE == id);
        }
    }
}
