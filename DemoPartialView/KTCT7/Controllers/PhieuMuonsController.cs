using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KTCT7.Data;
using KTCT7.Models;

namespace KTCT7.Controllers
{
    public class PhieuMuonsController : Controller
    {
        private readonly MvcKTCT7Context _context;

        public PhieuMuonsController(MvcKTCT7Context context)
        {
            _context = context;
        }

        // GET: PhieuMuons
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhieuMuons.ToListAsync());
        }

        // GET: PhieuMuons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuMuon = await _context.PhieuMuons
                .FirstOrDefaultAsync(m => m.SoPhieu == id);
            if (phieuMuon == null)
            {
                return NotFound();
            }

            return View(phieuMuon);
        }

        // GET: PhieuMuons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhieuMuons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SoPhieu,NgayMuon,NgayTra,MaDocGia")] PhieuMuon phieuMuon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phieuMuon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phieuMuon);
        }

        // GET: PhieuMuons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuMuon = await _context.PhieuMuons.FindAsync(id);
            if (phieuMuon == null)
            {
                return NotFound();
            }
            return View(phieuMuon);
        }

        // POST: PhieuMuons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SoPhieu,NgayMuon,NgayTra,MaDocGia")] PhieuMuon phieuMuon)
        {
            if (id != phieuMuon.SoPhieu)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phieuMuon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhieuMuonExists(phieuMuon.SoPhieu))
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
            return View(phieuMuon);
        }

        // GET: PhieuMuons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuMuon = await _context.PhieuMuons
                .FirstOrDefaultAsync(m => m.SoPhieu == id);
            if (phieuMuon == null)
            {
                return NotFound();
            }

            return View(phieuMuon);
        }

        // POST: PhieuMuons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phieuMuon = await _context.PhieuMuons.FindAsync(id);
            _context.PhieuMuons.Remove(phieuMuon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhieuMuonExists(int id)
        {
            return _context.PhieuMuons.Any(e => e.SoPhieu == id);
        }
    }
}
