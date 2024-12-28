using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Context;
using ERP.Models.Kontrol.MalzemeBilgi;

namespace ERP.Controllers
{
    public class MalzemeTipiController : Controller
    {
        private readonly AppDbContext _context;

        public MalzemeTipiController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MalzemeTipi
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMMAT001.Include(b => b.FCOMCODE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: MalzemeTipi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMMAT001 = await _context.BSMGRNNMMAT001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMMAT001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMMAT001);
        }

        // GET: MalzemeTipi/Create
        public IActionResult Create()
        {
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            return View();
        }

        // POST: MalzemeTipi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMMAT001 bSMGRNNMMAT001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMMAT001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMMAT001.COMCODE);
            return View(bSMGRNNMMAT001);
        }

        // GET: MalzemeTipi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMMAT001 = await _context.BSMGRNNMMAT001.FindAsync(id);
            if (bSMGRNNMMAT001 == null)
            {
                return NotFound();
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMMAT001.COMCODE);
            return View(bSMGRNNMMAT001);
        }

        // POST: MalzemeTipi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMMAT001 bSMGRNNMMAT001)
        {
            if (id != bSMGRNNMMAT001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMMAT001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMMAT001Exists(bSMGRNNMMAT001.DOCTYPE))
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
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMMAT001.COMCODE);
            return View(bSMGRNNMMAT001);
        }

        // GET: MalzemeTipi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMMAT001 = await _context.BSMGRNNMMAT001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMMAT001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMMAT001);
        }

        // POST: MalzemeTipi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMMAT001 = await _context.BSMGRNNMMAT001.FindAsync(id);
            if (bSMGRNNMMAT001 != null)
            {
                _context.BSMGRNNMMAT001.Remove(bSMGRNNMMAT001);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMMAT001Exists(string id)
        {
            return _context.BSMGRNNMMAT001.Any(e => e.DOCTYPE == id);
        }
    }
}
