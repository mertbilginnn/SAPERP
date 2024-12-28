using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Context;
using ERP.Models.Veri.Rota;

namespace ERP.Controllers
{
    public class RotaKart : Controller
    {
        private readonly AppDbContext _context;

        public RotaKart(AppDbContext context)
        {
            _context = context;
        }

        // GET: RotaKart
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMROTHEAD.Include(b => b.FBOMDOCNUM).Include(b => b.FBOMDOCTYPE).Include(b => b.FCOMCODE).Include(b => b.FMATDOCNUM).Include(b => b.FMATDOCTYPE).Include(b => b.FROTDOCTYPE).Include(b => b.FWCMDOCNUM).Include(b => b.FWCMDOCTYPE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: RotaKart/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMROTHEAD = await _context.BSMGRNNMROTHEAD
                .Include(b => b.FBOMDOCNUM)
                .Include(b => b.FBOMDOCTYPE)
                .Include(b => b.FCOMCODE)
                .Include(b => b.FMATDOCNUM)
                .Include(b => b.FMATDOCTYPE)
                .Include(b => b.FROTDOCTYPE)
                .Include(b => b.FWCMDOCNUM)
                .Include(b => b.FWCMDOCTYPE)
                .FirstOrDefaultAsync(m => m.ROTDOCNUM == id);
            if (bSMGRNNMROTHEAD == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMROTHEAD);
        }

        // GET: RotaKart/Create
        public IActionResult Create()
        {
            ViewData["BOMDOCNUM"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM");
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM");
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            ViewData["MATDOCNUM"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM");
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM");
            ViewData["ROTDOCTYPE"] = new SelectList(_context.BSMGRNNMROT001, "DOCTYPE", "DOCTYPE");
            ViewData["WCMDOCNUM"] = new SelectList(_context.BSMGRNNMWCMHEAD, "WCMDOCNUM", "WCMDOCNUM");
            ViewData["WCMDOCTYPE"] = new SelectList(_context.BSMGRNNMWCMHEAD, "WCMDOCNUM", "WCMDOCNUM");
            return View();
        }

        // POST: RotaKart/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,ROTDOCNUM,ROTDOCTYPE,ROTDOCFROM,ROTDOCUNTIL,DRAWNUM,MATDOCTYPE,MATDOCNUM,OPRNUM,WCMDOCTYPE,WCMDOCNUM,SETUPTIME,MACHINETIME,LABOURTIME,BOMDOCNUM,BOMDOCTYPE,CONTENTNUM,COMPONENT,QUANTITY,ISDELETED,ISPASSIVE")] BSMGRNNMROTHEAD bSMGRNNMROTHEAD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMROTHEAD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BOMDOCNUM"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMROTHEAD.BOMDOCNUM);
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMROTHEAD.BOMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMROTHEAD.COMCODE);
            ViewData["MATDOCNUM"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMROTHEAD.MATDOCNUM);
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMROTHEAD.MATDOCTYPE);
            ViewData["ROTDOCTYPE"] = new SelectList(_context.BSMGRNNMROT001, "DOCTYPE", "DOCTYPE", bSMGRNNMROTHEAD.ROTDOCTYPE);
            ViewData["WCMDOCNUM"] = new SelectList(_context.BSMGRNNMWCMHEAD, "WCMDOCNUM", "WCMDOCNUM", bSMGRNNMROTHEAD.WCMDOCNUM);
            ViewData["WCMDOCTYPE"] = new SelectList(_context.BSMGRNNMWCMHEAD, "WCMDOCNUM", "WCMDOCNUM", bSMGRNNMROTHEAD.WCMDOCTYPE);
            return View(bSMGRNNMROTHEAD);
        }

        // GET: RotaKart/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMROTHEAD = await _context.BSMGRNNMROTHEAD.FindAsync(id);
            if (bSMGRNNMROTHEAD == null)
            {
                return NotFound();
            }
            ViewData["BOMDOCNUM"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMROTHEAD.BOMDOCNUM);
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMROTHEAD.BOMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMROTHEAD.COMCODE);
            ViewData["MATDOCNUM"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMROTHEAD.MATDOCNUM);
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMROTHEAD.MATDOCTYPE);
            ViewData["ROTDOCTYPE"] = new SelectList(_context.BSMGRNNMROT001, "DOCTYPE", "DOCTYPE", bSMGRNNMROTHEAD.ROTDOCTYPE);
            ViewData["WCMDOCNUM"] = new SelectList(_context.BSMGRNNMWCMHEAD, "WCMDOCNUM", "WCMDOCNUM", bSMGRNNMROTHEAD.WCMDOCNUM);
            ViewData["WCMDOCTYPE"] = new SelectList(_context.BSMGRNNMWCMHEAD, "WCMDOCNUM", "WCMDOCNUM", bSMGRNNMROTHEAD.WCMDOCTYPE);
            return View(bSMGRNNMROTHEAD);
        }

        // POST: RotaKart/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,ROTDOCNUM,ROTDOCTYPE,ROTDOCFROM,ROTDOCUNTIL,DRAWNUM,MATDOCTYPE,MATDOCNUM,OPRNUM,WCMDOCTYPE,WCMDOCNUM,SETUPTIME,MACHINETIME,LABOURTIME,BOMDOCNUM,BOMDOCTYPE,CONTENTNUM,COMPONENT,QUANTITY,ISDELETED,ISPASSIVE")] BSMGRNNMROTHEAD bSMGRNNMROTHEAD)
        {
            if (id != bSMGRNNMROTHEAD.ROTDOCNUM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMROTHEAD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMROTHEADExists(bSMGRNNMROTHEAD.ROTDOCNUM))
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
            ViewData["BOMDOCNUM"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMROTHEAD.BOMDOCNUM);
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMROTHEAD.BOMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMROTHEAD.COMCODE);
            ViewData["MATDOCNUM"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMROTHEAD.MATDOCNUM);
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMROTHEAD.MATDOCTYPE);
            ViewData["ROTDOCTYPE"] = new SelectList(_context.BSMGRNNMROT001, "DOCTYPE", "DOCTYPE", bSMGRNNMROTHEAD.ROTDOCTYPE);
            ViewData["WCMDOCNUM"] = new SelectList(_context.BSMGRNNMWCMHEAD, "WCMDOCNUM", "WCMDOCNUM", bSMGRNNMROTHEAD.WCMDOCNUM);
            ViewData["WCMDOCTYPE"] = new SelectList(_context.BSMGRNNMWCMHEAD, "WCMDOCNUM", "WCMDOCNUM", bSMGRNNMROTHEAD.WCMDOCTYPE);
            return View(bSMGRNNMROTHEAD);
        }

        // GET: RotaKart/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMROTHEAD = await _context.BSMGRNNMROTHEAD
                .Include(b => b.FBOMDOCNUM)
                .Include(b => b.FBOMDOCTYPE)
                .Include(b => b.FCOMCODE)
                .Include(b => b.FMATDOCNUM)
                .Include(b => b.FMATDOCTYPE)
                .Include(b => b.FROTDOCTYPE)
                .Include(b => b.FWCMDOCNUM)
                .Include(b => b.FWCMDOCTYPE)
                .FirstOrDefaultAsync(m => m.ROTDOCNUM == id);
            if (bSMGRNNMROTHEAD == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMROTHEAD);
        }

        // POST: RotaKart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMROTHEAD = await _context.BSMGRNNMROTHEAD.FindAsync(id);
            if (bSMGRNNMROTHEAD != null)
            {
                _context.BSMGRNNMROTHEAD.Remove(bSMGRNNMROTHEAD);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMROTHEADExists(string id)
        {
            return _context.BSMGRNNMROTHEAD.Any(e => e.ROTDOCNUM == id);
        }
    }
}
