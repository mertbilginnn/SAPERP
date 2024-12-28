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
    public class BirimlerController : Controller
    {
        private readonly AppDbContext _context;

        public BirimlerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Birimler
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMGEN005.Include(b => b.FCOMCODE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Birimler/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN005 = await _context.BSMGRNNMGEN005
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.UNITCODE == id);
            if (bSMGRNNMGEN005 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMGEN005);
        }

        // GET: Birimler/Create
        public IActionResult Create()
        {
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            return View();
        }

        // POST: Birimler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UNITCODE,UNITTEXT,ISMAINUNIT,MAINUNITCODE,COMCODE")] BSMGRNNMGEN005 bSMGRNNMGEN005)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMGEN005);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMGEN005.COMCODE);
            return View(bSMGRNNMGEN005);
        }

        // GET: Birimler/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN005 = await _context.BSMGRNNMGEN005.FindAsync(id);
            if (bSMGRNNMGEN005 == null)
            {
                return NotFound();
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMGEN005.COMCODE);
            return View(bSMGRNNMGEN005);
        }

        // POST: Birimler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UNITCODE,UNITTEXT,ISMAINUNIT,MAINUNITCODE,COMCODE")] BSMGRNNMGEN005 bSMGRNNMGEN005)
        {
            if (id != bSMGRNNMGEN005.UNITCODE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMGEN005);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMGEN005Exists(bSMGRNNMGEN005.UNITCODE))
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
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMGEN005.COMCODE);
            return View(bSMGRNNMGEN005);
        }

        // GET: Birimler/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN005 = await _context.BSMGRNNMGEN005
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.UNITCODE == id);
            if (bSMGRNNMGEN005 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMGEN005);
        }

        // POST: Birimler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMGEN005 = await _context.BSMGRNNMGEN005.FindAsync(id);
            if (bSMGRNNMGEN005 != null)
            {
                _context.BSMGRNNMGEN005.Remove(bSMGRNNMGEN005);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMGEN005Exists(string id)
        {
            return _context.BSMGRNNMGEN005.Any(e => e.UNITCODE == id);
        }
    }
}
