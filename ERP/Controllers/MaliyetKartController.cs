using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Context;
using ERP.Models.Veri.Maliyet;

namespace ERP.Controllers
{
    public class MaliyetKartController : Controller
    {
        private readonly AppDbContext _context;

        public MaliyetKartController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MaliyetKart
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMCCMHEAD.Include(b => b.DOCTYPE).Include(b => b.FCOMCODE).Include(b => b.FLANCODE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: MaliyetKart/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMCCMHEAD = await _context.BSMGRNNMCCMHEAD
                .Include(b => b.DOCTYPE)
                .Include(b => b.FCOMCODE)
                .Include(b => b.FLANCODE)
                .FirstOrDefaultAsync(m => m.CCMDOCNUM == id);
            if (bSMGRNNMCCMHEAD == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMCCMHEAD);
        }

        // GET: MaliyetKart/Create
        public IActionResult Create()
        {
            ViewData["CCMDOCTYPE"] = new SelectList(_context.BSMGRNNMCCM001, "DOCTYPE", "DOCTYPE");
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE");
            return View();
        }

        // POST: MaliyetKart/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,CCMDOCNUM,CCMDOCTYPE,CCMDOCFROM,CCMDOCUNTIL,MAINCCMDOCNUM,MAINCCMDOCTYPE,ISDELETED,ISPASSIVE,LANCODE,CCMSTEXT,CCMLTEXT")] BSMGRNNMCCMHEAD bSMGRNNMCCMHEAD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMCCMHEAD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CCMDOCTYPE"] = new SelectList(_context.BSMGRNNMCCM001, "DOCTYPE", "DOCTYPE", bSMGRNNMCCMHEAD.CCMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMCCMHEAD.COMCODE);
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE", bSMGRNNMCCMHEAD.LANCODE);
            return View(bSMGRNNMCCMHEAD);
        }

        // GET: MaliyetKart/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMCCMHEAD = await _context.BSMGRNNMCCMHEAD.FindAsync(id);
            if (bSMGRNNMCCMHEAD == null)
            {
                return NotFound();
            }
            ViewData["CCMDOCTYPE"] = new SelectList(_context.BSMGRNNMCCM001, "DOCTYPE", "DOCTYPE", bSMGRNNMCCMHEAD.CCMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMCCMHEAD.COMCODE);
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE", bSMGRNNMCCMHEAD.LANCODE);
            return View(bSMGRNNMCCMHEAD);
        }

        // POST: MaliyetKart/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,CCMDOCNUM,CCMDOCTYPE,CCMDOCFROM,CCMDOCUNTIL,MAINCCMDOCNUM,MAINCCMDOCTYPE,ISDELETED,ISPASSIVE,LANCODE,CCMSTEXT,CCMLTEXT")] BSMGRNNMCCMHEAD bSMGRNNMCCMHEAD)
        {
            if (id != bSMGRNNMCCMHEAD.CCMDOCNUM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMCCMHEAD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMCCMHEADExists(bSMGRNNMCCMHEAD.CCMDOCNUM))
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
            ViewData["CCMDOCTYPE"] = new SelectList(_context.BSMGRNNMCCM001, "DOCTYPE", "DOCTYPE", bSMGRNNMCCMHEAD.CCMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMCCMHEAD.COMCODE);
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE", bSMGRNNMCCMHEAD.LANCODE);
            return View(bSMGRNNMCCMHEAD);
        }

        // GET: MaliyetKart/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMCCMHEAD = await _context.BSMGRNNMCCMHEAD
                .Include(b => b.DOCTYPE)
                .Include(b => b.FCOMCODE)
                .Include(b => b.FLANCODE)
                .FirstOrDefaultAsync(m => m.CCMDOCNUM == id);
            if (bSMGRNNMCCMHEAD == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMCCMHEAD);
        }

        // POST: MaliyetKart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMCCMHEAD = await _context.BSMGRNNMCCMHEAD.FindAsync(id);
            if (bSMGRNNMCCMHEAD != null)
            {
                _context.BSMGRNNMCCMHEAD.Remove(bSMGRNNMCCMHEAD);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMCCMHEADExists(string id)
        {
            return _context.BSMGRNNMCCMHEAD.Any(e => e.CCMDOCNUM == id);
        }
    }
}
