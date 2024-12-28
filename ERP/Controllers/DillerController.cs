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
    public class DillerController : Controller
    {
        private readonly AppDbContext _context;

        public DillerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Diller
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMGEN002.Include(b => b.FCOMCODE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Diller/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN002 = await _context.BSMGRNNMGEN002
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.LANCODE == id);
            if (bSMGRNNMGEN002 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMGEN002);
        }

        // GET: Diller/Create
        public IActionResult Create()
        {
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            return View();
        }

        // POST: Diller/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LANCODE,LANTEXT,COMCODE")] BSMGRNNMGEN002 bSMGRNNMGEN002)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMGEN002);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMGEN002.COMCODE);
            return View(bSMGRNNMGEN002);
        }

        // GET: Diller/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN002 = await _context.BSMGRNNMGEN002.FindAsync(id);
            if (bSMGRNNMGEN002 == null)
            {
                return NotFound();
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMGEN002.COMCODE);
            return View(bSMGRNNMGEN002);
        }

        // POST: Diller/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LANCODE,LANTEXT,COMCODE")] BSMGRNNMGEN002 bSMGRNNMGEN002)
        {
            if (id != bSMGRNNMGEN002.LANCODE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMGEN002);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMGEN002Exists(bSMGRNNMGEN002.LANCODE))
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
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMGEN002.COMCODE);
            return View(bSMGRNNMGEN002);
        }

        // GET: Diller/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMGEN002 = await _context.BSMGRNNMGEN002
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.LANCODE == id);
            if (bSMGRNNMGEN002 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMGEN002);
        }

        // POST: Diller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMGEN002 = await _context.BSMGRNNMGEN002.FindAsync(id);
            if (bSMGRNNMGEN002 != null)
            {
                _context.BSMGRNNMGEN002.Remove(bSMGRNNMGEN002);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMGEN002Exists(string id)
        {
            return _context.BSMGRNNMGEN002.Any(e => e.LANCODE == id);
        }
    }
}
