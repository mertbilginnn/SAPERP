using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Context;
using ERP.Models.Veri.Malzeme;

namespace ERP.Controllers
{
    public class MalzemeKartController : Controller
    {
        private readonly AppDbContext _context;

        public MalzemeKartController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MalzemeKart
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMMATHEAD.Include(b => b.FBOMDOCNUM).Include(b => b.FBOMDOCTYPE).Include(b => b.FBWUNIT).Include(b => b.FCOMCODE).Include(b => b.FLANCODE).Include(b => b.FMATDOCTYPE).Include(b => b.FNWUNIT).Include(b => b.FROTDOCTYPE).Include(b => b.FSTUNIT);
            return View(await appDbContext.ToListAsync());
        }

        // GET: MalzemeKart/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMMATHEAD = await _context.BSMGRNNMMATHEAD
                .Include(b => b.FBOMDOCNUM)
                .Include(b => b.FBOMDOCTYPE)
                .Include(b => b.FBWUNIT)
                .Include(b => b.FCOMCODE)
                .Include(b => b.FLANCODE)
                .Include(b => b.FMATDOCTYPE)
                .Include(b => b.FNWUNIT)
                .Include(b => b.FROTDOCTYPE)
                .Include(b => b.FSTUNIT)
                .FirstOrDefaultAsync(m => m.MATDOCNUM == id);
            if (bSMGRNNMMATHEAD == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMMATHEAD);
        }

        // GET: MalzemeKart/Create
        public IActionResult Create()
        {
            ViewData["BOMDOCNUM"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM");
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM");
            ViewData["BWUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE");
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE");
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMAT001, "DOCTYPE", "DOCTYPE");
            ViewData["NWUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE");
            ViewData["ROTDOCTYPE"] = new SelectList(_context.BSMGRNNMROT001, "DOCTYPE", "DOCTYPE");
            ViewData["STUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE");
            ViewBag.FirmaListesi = _context.BSMGRNNMGEN001
                 .Select(f => new { f.COMCODE, f.COMTEXT })
                 .ToList();

            return View();
        }

        // POST: MalzemeKart/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,MATDOCNUM,MATDOCTYPE,MATDOCFROM,MATDOCUNTIL,SUPPLYTYPE,STUNIT,NETWEIGHT,NWUNIT,BRUTWEIGHT,BWUNIT,ISBOM,BOMDOCNUM,BOMDOCTYPE,ISROUTE,ROTDOCTYPE,ROTDOCNUM,ISDELETED,ISPASSIVE,LANCODE,MATSTEXT,MATLTEXT")] BSMGRNNMMATHEAD bSMGRNNMMATHEAD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMMATHEAD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BOMDOCNUM"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMMATHEAD.BOMDOCNUM);
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMMATHEAD.BOMDOCTYPE);
            ViewData["BWUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE", bSMGRNNMMATHEAD.BWUNIT);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMMATHEAD.COMCODE);
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE", bSMGRNNMMATHEAD.LANCODE);
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMAT001, "DOCTYPE", "DOCTYPE", bSMGRNNMMATHEAD.MATDOCTYPE);
            ViewData["NWUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE", bSMGRNNMMATHEAD.NWUNIT);
            ViewData["ROTDOCTYPE"] = new SelectList(_context.BSMGRNNMROT001, "DOCTYPE", "DOCTYPE", bSMGRNNMMATHEAD.ROTDOCTYPE);
            ViewData["STUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE", bSMGRNNMMATHEAD.STUNIT);
            return View(bSMGRNNMMATHEAD);
        }

        // GET: MalzemeKart/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMMATHEAD = await _context.BSMGRNNMMATHEAD.FindAsync(id);
            if (bSMGRNNMMATHEAD == null)
            {
                return NotFound();
            }
            ViewData["BOMDOCNUM"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMMATHEAD.BOMDOCNUM);
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMMATHEAD.BOMDOCTYPE);
            ViewData["BWUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE", bSMGRNNMMATHEAD.BWUNIT);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMMATHEAD.COMCODE);
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE", bSMGRNNMMATHEAD.LANCODE);
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMAT001, "DOCTYPE", "DOCTYPE", bSMGRNNMMATHEAD.MATDOCTYPE);
            ViewData["NWUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE", bSMGRNNMMATHEAD.NWUNIT);
            ViewData["ROTDOCTYPE"] = new SelectList(_context.BSMGRNNMROT001, "DOCTYPE", "DOCTYPE", bSMGRNNMMATHEAD.ROTDOCTYPE);
            ViewData["STUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE", bSMGRNNMMATHEAD.STUNIT);
            return View(bSMGRNNMMATHEAD);
        }

        // POST: MalzemeKart/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,MATDOCNUM,MATDOCTYPE,MATDOCFROM,MATDOCUNTIL,SUPPLYTYPE,STUNIT,NETWEIGHT,NWUNIT,BRUTWEIGHT,BWUNIT,ISBOM,BOMDOCNUM,BOMDOCTYPE,ISROUTE,ROTDOCTYPE,ROTDOCNUM,ISDELETED,ISPASSIVE,LANCODE,MATSTEXT,MATLTEXT")] BSMGRNNMMATHEAD bSMGRNNMMATHEAD)
        {
            if (id != bSMGRNNMMATHEAD.MATDOCNUM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMMATHEAD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMMATHEADExists(bSMGRNNMMATHEAD.MATDOCNUM))
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
            ViewData["BOMDOCNUM"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMMATHEAD.BOMDOCNUM);
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOMHEAD, "BOMDOCNUM", "BOMDOCNUM", bSMGRNNMMATHEAD.BOMDOCTYPE);
            ViewData["BWUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE", bSMGRNNMMATHEAD.BWUNIT);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMMATHEAD.COMCODE);
            ViewData["LANCODE"] = new SelectList(_context.BSMGRNNMGEN002, "LANCODE", "LANCODE", bSMGRNNMMATHEAD.LANCODE);
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMAT001, "DOCTYPE", "DOCTYPE", bSMGRNNMMATHEAD.MATDOCTYPE);
            ViewData["NWUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE", bSMGRNNMMATHEAD.NWUNIT);
            ViewData["ROTDOCTYPE"] = new SelectList(_context.BSMGRNNMROT001, "DOCTYPE", "DOCTYPE", bSMGRNNMMATHEAD.ROTDOCTYPE);
            ViewData["STUNIT"] = new SelectList(_context.BSMGRNNMGEN005, "UNITCODE", "UNITCODE", bSMGRNNMMATHEAD.STUNIT);
            return View(bSMGRNNMMATHEAD);
        }

        // GET: MalzemeKart/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMMATHEAD = await _context.BSMGRNNMMATHEAD
                .Include(b => b.FBOMDOCNUM)
                .Include(b => b.FBOMDOCTYPE)
                .Include(b => b.FBWUNIT)
                .Include(b => b.FCOMCODE)
                .Include(b => b.FLANCODE)
                .Include(b => b.FMATDOCTYPE)
                .Include(b => b.FNWUNIT)
                .Include(b => b.FROTDOCTYPE)
                .Include(b => b.FSTUNIT)
                .FirstOrDefaultAsync(m => m.MATDOCNUM == id);
            if (bSMGRNNMMATHEAD == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMMATHEAD);
        }

        // POST: MalzemeKart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMMATHEAD = await _context.BSMGRNNMMATHEAD.FindAsync(id);
            if (bSMGRNNMMATHEAD != null)
            {
                _context.BSMGRNNMMATHEAD.Remove(bSMGRNNMMATHEAD);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMMATHEADExists(string id)
        {
            return _context.BSMGRNNMMATHEAD.Any(e => e.MATDOCNUM == id);
        }
    }
}
