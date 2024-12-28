using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Context;
using ERP.Models.Veri.UrunAgac;

namespace ERP.Controllers
{
    public class UrunAgacKart : Controller
    {
        private readonly AppDbContext _context;

        public UrunAgacKart(AppDbContext context)
        {
            _context = context;
        }

        // GET: UrunAgacKart
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BSMGRNNMBOMHEAD.Include(b => b.DOCTYPE).Include(b => b.FCOMCODE).Include(b => b.FMATDOCNUM).Include(b => b.FMATDOCTYPE);
            return View(await appDbContext.ToListAsync());
        }

        // GET: UrunAgacKart/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMBOMHEAD = await _context.BSMGRNNMBOMHEAD
                .Include(b => b.DOCTYPE)
                .Include(b => b.FCOMCODE)
                .Include(b => b.FMATDOCNUM)
                .Include(b => b.FMATDOCTYPE)
                .FirstOrDefaultAsync(m => m.BOMDOCNUM == id);
            if (bSMGRNNMBOMHEAD == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMBOMHEAD);
        }

        // GET: UrunAgacKart/Create
        public IActionResult Create()
        {
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOM001, "DOCTYPE", "DOCTYPE");
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE");
            ViewData["MATDOCNUM"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM");
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM");
            return View();
        }

        // POST: UrunAgacKart/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,BOMDOCNUM,BOMDOCTYPE,BOMDOCFROM,BOMDOCUNTIL,MATDOCNUM,MATDOCTYPE,QUANTITY,CONTENTNUM,COMPONENT,ISDELETED,ISPASSIVE,DRAWNUM")] BSMGRNNMBOMHEAD bSMGRNNMBOMHEAD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMGRNNMBOMHEAD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOM001, "DOCTYPE", "DOCTYPE", bSMGRNNMBOMHEAD.BOMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMBOMHEAD.COMCODE);
            ViewData["MATDOCNUM"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMBOMHEAD.MATDOCNUM);
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMBOMHEAD.MATDOCTYPE);
            return View(bSMGRNNMBOMHEAD);
        }

        // GET: UrunAgacKart/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMBOMHEAD = await _context.BSMGRNNMBOMHEAD.FindAsync(id);
            if (bSMGRNNMBOMHEAD == null)
            {
                return NotFound();
            }
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOM001, "DOCTYPE", "DOCTYPE", bSMGRNNMBOMHEAD.BOMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMBOMHEAD.COMCODE);
            ViewData["MATDOCNUM"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMBOMHEAD.MATDOCNUM);
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMBOMHEAD.MATDOCTYPE);
            return View(bSMGRNNMBOMHEAD);
        }

        // POST: UrunAgacKart/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,BOMDOCNUM,BOMDOCTYPE,BOMDOCFROM,BOMDOCUNTIL,MATDOCNUM,MATDOCTYPE,QUANTITY,CONTENTNUM,COMPONENT,ISDELETED,ISPASSIVE,DRAWNUM")] BSMGRNNMBOMHEAD bSMGRNNMBOMHEAD)
        {
            if (id != bSMGRNNMBOMHEAD.BOMDOCNUM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMGRNNMBOMHEAD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMGRNNMBOMHEADExists(bSMGRNNMBOMHEAD.BOMDOCNUM))
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
            ViewData["BOMDOCTYPE"] = new SelectList(_context.BSMGRNNMBOM001, "DOCTYPE", "DOCTYPE", bSMGRNNMBOMHEAD.BOMDOCTYPE);
            ViewData["COMCODE"] = new SelectList(_context.BSMGRNNMGEN001, "COMCODE", "COMCODE", bSMGRNNMBOMHEAD.COMCODE);
            ViewData["MATDOCNUM"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMBOMHEAD.MATDOCNUM);
            ViewData["MATDOCTYPE"] = new SelectList(_context.BSMGRNNMMATHEAD, "MATDOCNUM", "MATDOCNUM", bSMGRNNMBOMHEAD.MATDOCTYPE);
            return View(bSMGRNNMBOMHEAD);
        }

        // GET: UrunAgacKart/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bSMGRNNMBOMHEAD = await _context.BSMGRNNMBOMHEAD
                .Include(b => b.DOCTYPE)
                .Include(b => b.FCOMCODE)
                .Include(b => b.FMATDOCNUM)
                .Include(b => b.FMATDOCTYPE)
                .FirstOrDefaultAsync(m => m.BOMDOCNUM == id);
            if (bSMGRNNMBOMHEAD == null)
            {
                return NotFound();
            }

            return View(bSMGRNNMBOMHEAD);
        }

        // POST: UrunAgacKart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bSMGRNNMBOMHEAD = await _context.BSMGRNNMBOMHEAD.FindAsync(id);
            if (bSMGRNNMBOMHEAD != null)
            {
                _context.BSMGRNNMBOMHEAD.Remove(bSMGRNNMBOMHEAD);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMGRNNMBOMHEADExists(string id)
        {
            return _context.BSMGRNNMBOMHEAD.Any(e => e.BOMDOCNUM == id);
        }
    }
}
