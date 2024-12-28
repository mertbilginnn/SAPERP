using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Context;
using ERP.Models.Veri.IsMerkez;

namespace ERP.Controllers
{
    public class IsMerkezKart : Controller
    {
        private readonly AppDbContext _context;

        public IsMerkezKart(AppDbContext context)
        {
            _context = context;
        }

        // GET: IsMerkezKart
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMWCMHEAD.Include(b => b.DOCTYPE).Include(b => b.FCCMDOCNUM).Include(b => b.FCCMDOCTYPE).Include(b => b.FCOMCODE).Include(b => b.FLANCODE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: IsMerkezKart/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMWCMHEAD = await _context.BSMGRNNMWCMHEAD
                .Include(b => b.DOCTYPE)
                .Include(b => b.FCCMDOCNUM)
                .Include(b => b.FCCMDOCTYPE)
                .Include(b => b.FCOMCODE)
                .Include(b => b.FLANCODE)
                .FirstOrDefaultAsync(m => m.WCMDOCNUM == id);
            if (bSMGRNNMWCMHEAD == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMWCMHEAD);
        }

        // GET: IsMerkezKart/Create
        public IActionResult Create()
        {
            ViewData["WCMDOCTYPE"] = new SelectList(_context.BSMGRNNMWCM001, "DOCTYPE", "DOCTYPE");
            ViewData["CCMDOCNUM"] = new SelectList(_context.BSMGRNNMCCMHEAD, "CCMDOCNUM", "CCMDOCNUM");
            ViewData["CCMDOCTYPE"] = new SelectList(_context.BSMGRNNMCCMHEAD, "CCMDOCNUM", "CCMDOCNUM");
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE");
            return View();
        }

        // POST: IsMerkezKart/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,WCMDOCNUM,WCMDOCTYPE,WCMDOCFROM,WCMDOCUNTIL,MAINWCMDOCTYPE,MAINWCMDOCNUM,CCMDOCNUM,CCMDOCTYPE,WORKTIME,ISDELETED,ISPASSIVE,WCMSTEXT,WCMLTWXT,LANCODE,OPRDOCTYPE")] BSMGRNNMWCMHEAD bSMGRNNMWCMHEAD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMWCMHEAD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["WCMDOCTYPE"] = new SelectList(_context.BSMGRNNMWCM001, "DOCTYPE", "DOCTYPE", bSMGRNNMWCMHEAD.WCMDOCTYPE);
            ViewData["CCMDOCNUM"] = new SelectList(_context.BSMGRNNMCCMHEAD, "CCMDOCNUM", "CCMDOCNUM", bSMGRNNMWCMHEAD.CCMDOCNUM);
            ViewData["CCMDOCTYPE"] = new SelectList(_context.BSMGRNNMCCMHEAD, "CCMDOCNUM", "CCMDOCNUM", bSMGRNNMWCMHEAD.CCMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMWCMHEAD.COMCODE);
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE", bSMGRNNMWCMHEAD.LANCODE);
            return View(bSMGRNNMWCMHEAD);
        }

        // GET: IsMerkezKart/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMWCMHEAD = await _context.BSMGRNNMWCMHEAD.FindAsync(id);
            if (bSMGRNNMWCMHEAD == null)
            {
                return NotFound();
            }
            ViewData["WCMDOCTYPE"] = new SelectList(_context.BSMGRNNMWCM001, "DOCTYPE", "DOCTYPE", bSMGRNNMWCMHEAD.WCMDOCTYPE);
            ViewData["CCMDOCNUM"] = new SelectList(_context.BSMGRNNMCCMHEAD, "CCMDOCNUM", "CCMDOCNUM", bSMGRNNMWCMHEAD.CCMDOCNUM);
            ViewData["CCMDOCTYPE"] = new SelectList(_context.BSMGRNNMCCMHEAD, "CCMDOCNUM", "CCMDOCNUM", bSMGRNNMWCMHEAD.CCMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMWCMHEAD.COMCODE);
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE", bSMGRNNMWCMHEAD.LANCODE);
            return View(bSMGRNNMWCMHEAD);
        }

        // POST: IsMerkezKart/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,WCMDOCNUM,WCMDOCTYPE,WCMDOCFROM,WCMDOCUNTIL,MAINWCMDOCTYPE,MAINWCMDOCNUM,CCMDOCNUM,CCMDOCTYPE,WORKTIME,ISDELETED,ISPASSIVE,WCMSTEXT,WCMLTWXT,LANCODE,OPRDOCTYPE")] BSMGRNNMWCMHEAD bSMGRNNMWCMHEAD)
        {
            if (id != bSMGRNNMWCMHEAD.WCMDOCNUM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMWCMHEAD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMWCMHEADExists(bSMGRNNMWCMHEAD.WCMDOCNUM))
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
            ViewData["WCMDOCTYPE"] = new SelectList(_context.BSMGRNNMWCM001, "DOCTYPE", "DOCTYPE", bSMGRNNMWCMHEAD.WCMDOCTYPE);
            ViewData["CCMDOCNUM"] = new SelectList(_context.BSMGRNNMCCMHEAD, "CCMDOCNUM", "CCMDOCNUM", bSMGRNNMWCMHEAD.CCMDOCNUM);
            ViewData["CCMDOCTYPE"] = new SelectList(_context.BSMGRNNMCCMHEAD, "CCMDOCNUM", "CCMDOCNUM", bSMGRNNMWCMHEAD.CCMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMWCMHEAD.COMCODE);
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE", bSMGRNNMWCMHEAD.LANCODE);
            return View(bSMGRNNMWCMHEAD);
        }

        // GET: IsMerkezKart/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMWCMHEAD = await _context.BSMGRNNMWCMHEAD
                .Include(b => b.DOCTYPE)
                .Include(b => b.FCCMDOCNUM)
                .Include(b => b.FCCMDOCTYPE)
                .Include(b => b.FCOMCODE)
                .Include(b => b.FLANCODE)
                .FirstOrDefaultAsync(m => m.WCMDOCNUM == id);
            if (bSMGRNNMWCMHEAD == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMWCMHEAD);
        }

        // POST: IsMerkezKart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMWCMHEAD = await _context.BSMGRNNMWCMHEAD.FindAsync(id);
            if (bSMGRNNMWCMHEAD != null)
            {
                _context.BSMGRNNMWCMHEAD.Remove(bSMGRNNMWCMHEAD);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMWCMHEADExists(string id)
        {
            return _context.BSMGRNNMWCMHEAD.Any(e => e.WCMDOCNUM == id);
        }
    }
}
