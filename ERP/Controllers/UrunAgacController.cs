using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Context;
using ERP.Models.Kontrol.UrunAgac;

namespace ERP.Controllers
{
    public class UrunAgacController : Controller
    {
        private readonly AppDbContext _context;

        public UrunAgacController(AppDbContext context)
        {
            _context = context;
        }

        // GET: UrunAgac
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMBOM001.Include(b => b.FCOMCODE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: UrunAgac/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMBOM001 = await _context.BSMGRNNMBOM001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMBOM001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMBOM001);
        }

        // GET: UrunAgac/Create
        public IActionResult Create()
        {
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            return View();
        }

        // POST: UrunAgac/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMBOM001 bSMGRNNMBOM001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMBOM001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMBOM001.COMCODE);
            return View(bSMGRNNMBOM001);
        }

        // GET: UrunAgac/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMBOM001 = await _context.BSMGRNNMBOM001.FindAsync(id);
            if (bSMGRNNMBOM001 == null)
            {
                return NotFound();
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMBOM001.COMCODE);
            return View(bSMGRNNMBOM001);
        }

        // POST: UrunAgac/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMBOM001 bSMGRNNMBOM001)
        {
            if (id != bSMGRNNMBOM001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMBOM001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMBOM001Exists(bSMGRNNMBOM001.DOCTYPE))
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
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMBOM001.COMCODE);
            return View(bSMGRNNMBOM001);
        }

        // GET: UrunAgac/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMBOM001 = await _context.BSMGRNNMBOM001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMBOM001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMBOM001);
        }

        // POST: UrunAgac/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMBOM001 = await _context.BSMGRNNMBOM001.FindAsync(id);
            if (bSMGRNNMBOM001 != null)
            {
                _context.BSMGRNNMBOM001.Remove(bSMGRNNMBOM001);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMBOM001Exists(string id)
        {
            return _context.BSMGRNNMBOM001.Any(e => e.DOCTYPE == id);
        }
    }
}
