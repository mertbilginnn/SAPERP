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
    public class RotaTipiController : Controller
    {
        private readonly AppDbContext _context;

        public RotaTipiController(AppDbContext context)
        {
            _context = context;
        }

        // GET: RotaTipi
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMROT001.Include(b => b.FCOMCODE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: RotaTipi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMROT001 = await _context.BSMGRNNMROT001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMROT001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMROT001);
        }

        // GET: RotaTipi/Create
        public IActionResult Create()
        {
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            return View();
        }

        // POST: RotaTipi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMROT001 bSMGRNNMROT001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMROT001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMROT001.COMCODE);
            return View(bSMGRNNMROT001);
        }

        // GET: RotaTipi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMROT001 = await _context.BSMGRNNMROT001.FindAsync(id);
            if (bSMGRNNMROT001 == null)
            {
                return NotFound();
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMROT001.COMCODE);
            return View(bSMGRNNMROT001);
        }

        // POST: RotaTipi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMROT001 bSMGRNNMROT001)
        {
            if (id != bSMGRNNMROT001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMROT001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMROT001Exists(bSMGRNNMROT001.DOCTYPE))
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
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMROT001.COMCODE);
            return View(bSMGRNNMROT001);
        }

        // GET: RotaTipi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMROT001 = await _context.BSMGRNNMROT001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMROT001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMROT001);
        }

        // POST: RotaTipi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMROT001 = await _context.BSMGRNNMROT001.FindAsync(id);
            if (bSMGRNNMROT001 != null)
            {
                _context.BSMGRNNMROT001.Remove(bSMGRNNMROT001);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMROT001Exists(string id)
        {
            return _context.BSMGRNNMROT001.Any(e => e.DOCTYPE == id);
        }
    }
}
