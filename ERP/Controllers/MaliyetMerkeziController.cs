using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Context;
using ERP.Models.Kontrol.Maliyet;

namespace ERP.Controllers
{
    public class MaliyetMerkeziController : Controller
    {
        private readonly AppDbContext _context;

        public MaliyetMerkeziController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MaliyetMerkezi
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMCCM001.Include(b => b.FCOMCODE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: MaliyetMerkezi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMCCM001 = await _context.BSMGRNNMCCM001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMCCM001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMCCM001);
        }

        // GET: MaliyetMerkezi/Create
        public IActionResult Create()
        {
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            return View();
        }

        // POST: MaliyetMerkezi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMCCM001 bSMGRNNMCCM001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMCCM001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMCCM001.COMCODE);
            return View(bSMGRNNMCCM001);
        }

        // GET: MaliyetMerkezi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMCCM001 = await _context.BSMGRNNMCCM001.FindAsync(id);
            if (bSMGRNNMCCM001 == null)
            {
                return NotFound();
            }
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMCCM001.COMCODE);
            return View(bSMGRNNMCCM001);
        }

        // POST: MaliyetMerkezi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,DOCTYPETEXT,ISPASSIVE,COMCODE")] BSMGRNNMCCM001 bSMGRNNMCCM001)
        {
            if (id != bSMGRNNMCCM001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMCCM001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMCCM001Exists(bSMGRNNMCCM001.DOCTYPE))
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
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMCCM001.COMCODE);
            return View(bSMGRNNMCCM001);
        }

        // GET: MaliyetMerkezi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMCCM001 = await _context.BSMGRNNMCCM001
                .Include(b => b.FCOMCODE)
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMGRNNMCCM001 == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMCCM001);
        }

        // POST: MaliyetMerkezi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMCCM001 = await _context.BSMGRNNMCCM001.FindAsync(id);
            if (bSMGRNNMCCM001 != null)
            {
                _context.BSMGRNNMCCM001.Remove(bSMGRNNMCCM001);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMCCM001Exists(string id)
        {
            return _context.BSMGRNNMCCM001.Any(e => e.DOCTYPE == id);
        }
    }
}
