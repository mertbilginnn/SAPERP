using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Context;
using ERP.Models.Kontrol.RotaBilgi;

namespace ERP.Controllers
{
    public class IsMerkezTipiController : Controller
    {
        private readonly AppDbContext _context;

        public IsMerkezTipiController(AppDbContext context)
        {
            _context = context;
        }

        // GET: IsMerkezTipi
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMWCM001.Include(b => b.FCOMCODE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: IsMerkezTipi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMWCM001 = await _context.BSMGRNNMWCM001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMWCM001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMWCM001);
        }

        // GET: IsMerkezTipi/Create
        public IActionResult Create()
        {
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            return View();
        }

        // POST: IsMerkezTipi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMWCM001 bSMGRNNMWCM001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMWCM001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMWCM001.COMCODE);
            return View(bSMGRNNMWCM001);
        }

        // GET: IsMerkezTipi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMWCM001 = await _context.BSMGRNNMWCM001.FindAsync(id);
            if (bSMGRNNMWCM001 == null)
            {
                return NotFound();
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMWCM001.COMCODE);
            return View(bSMGRNNMWCM001);
        }

        // POST: IsMerkezTipi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMWCM001 bSMGRNNMWCM001)
        {
            if (id != bSMGRNNMWCM001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMWCM001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMWCM001Exists(bSMGRNNMWCM001.DOCTYPE))
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
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMWCM001.COMCODE);
            return View(bSMGRNNMWCM001);
        }

        // GET: IsMerkezTipi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMWCM001 = await _context.BSMGRNNMWCM001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMWCM001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMWCM001);
        }

        // POST: IsMerkezTipi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMWCM001 = await _context.BSMGRNNMWCM001.FindAsync(id);
            if (bSMGRNNMWCM001 != null)
            {
                _context.BSMGRNNMWCM001.Remove(bSMGRNNMWCM001);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMWCM001Exists(string id)
        {
            return _context.BSMGRNNMWCM001.Any(e => e.DOCTYPE == id);
        }
    }
}
