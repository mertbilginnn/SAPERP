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
    public class OperasyonTipiController : Controller
    {
        private readonly AppDbContext _context;

        public OperasyonTipiController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OperasyonTipi
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMOPR001.Include(b => b.FCOMCODE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: OperasyonTipi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMOPR001 = await _context.BSMGRNNMOPR001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMOPR001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMOPR001);
        }

        // GET: OperasyonTipi/Create
        public IActionResult Create()
        {
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            return View();
        }

        // POST: OperasyonTipi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMOPR001 bSMGRNNMOPR001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMOPR001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMOPR001.COMCODE);
            return View(bSMGRNNMOPR001);
        }

        // GET: OperasyonTipi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMOPR001 = await _context.BSMGRNNMOPR001.FindAsync(id);
            if (bSMGRNNMOPR001 == null)
            {
                return NotFound();
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMOPR001.COMCODE);
            return View(bSMGRNNMOPR001);
        }

        // POST: OperasyonTipi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMOPR001 bSMGRNNMOPR001)
        {
            if (id != bSMGRNNMOPR001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMOPR001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMOPR001Exists(bSMGRNNMOPR001.DOCTYPE))
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
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMOPR001.COMCODE);
            return View(bSMGRNNMOPR001);
        }

        // GET: OperasyonTipi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMOPR001 = await _context.BSMGRNNMOPR001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMOPR001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMOPR001);
        }

        // POST: OperasyonTipi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMOPR001 = await _context.BSMGRNNMOPR001.FindAsync(id);
            if (bSMGRNNMOPR001 != null)
            {
                _context.BSMGRNNMOPR001.Remove(bSMGRNNMOPR001);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMOPR001Exists(string id)
        {
            return _context.BSMGRNNMOPR001.Any(e => e.DOCTYPE == id);
        }
    }
}
