using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test.Data;
using Test.Models;

namespace Test.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhongPhieuDatPhongsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhongPhieuDatPhongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/PhongPhieuDatPhongs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ChiTietPhieuDatPhongs.Include(p => p.phieuDatPhong).Include(p => p.phong);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/PhongPhieuDatPhongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongPhieuDatPhong = await _context.ChiTietPhieuDatPhongs
                .Include(p => p.phieuDatPhong)
                .Include(p => p.phong)
                .FirstOrDefaultAsync(m => m.PhongId == id);
            if (phongPhieuDatPhong == null)
            {
                return NotFound();
            }

            return View(phongPhieuDatPhong);
        }

        // GET: Admin/PhongPhieuDatPhongs/Create
        public IActionResult Create()
        {
            ViewData["PhieuDatPhongId"] = new SelectList(_context.PhieuDatPhong, "PhieuDatPhongId", "PhieuDatPhongId");
            ViewData["PhongId"] = new SelectList(_context.Phong, "PhongId", "PhongId");
            return View();
        }

        // POST: Admin/PhongPhieuDatPhongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhongId,PhieuDatPhongId")] PhongPhieuDatPhong phongPhieuDatPhong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phongPhieuDatPhong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PhieuDatPhongId"] = new SelectList(_context.PhieuDatPhong, "PhieuDatPhongId", "PhieuDatPhongId", phongPhieuDatPhong.PhieuDatPhongId);
            ViewData["PhongId"] = new SelectList(_context.Phong, "PhongId", "PhongId", phongPhieuDatPhong.PhongId);
            return View(phongPhieuDatPhong);
        }

        // GET: Admin/PhongPhieuDatPhongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongPhieuDatPhong = await _context.ChiTietPhieuDatPhongs.FindAsync(id);
            if (phongPhieuDatPhong == null)
            {
                return NotFound();
            }
            ViewData["PhieuDatPhongId"] = new SelectList(_context.PhieuDatPhong, "PhieuDatPhongId", "PhieuDatPhongId", phongPhieuDatPhong.PhieuDatPhongId);
            ViewData["PhongId"] = new SelectList(_context.Phong, "PhongId", "PhongId", phongPhieuDatPhong.PhongId);
            return View(phongPhieuDatPhong);
        }

        // POST: Admin/PhongPhieuDatPhongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhongId,PhieuDatPhongId")] PhongPhieuDatPhong phongPhieuDatPhong)
        {
            if (id != phongPhieuDatPhong.PhongId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phongPhieuDatPhong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhongPhieuDatPhongExists(phongPhieuDatPhong.PhongId))
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
            ViewData["PhieuDatPhongId"] = new SelectList(_context.PhieuDatPhong, "PhieuDatPhongId", "PhieuDatPhongId", phongPhieuDatPhong.PhieuDatPhongId);
            ViewData["PhongId"] = new SelectList(_context.Phong, "PhongId", "PhongId", phongPhieuDatPhong.PhongId);
            return View(phongPhieuDatPhong);
        }

        // GET: Admin/PhongPhieuDatPhongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongPhieuDatPhong = await _context.ChiTietPhieuDatPhongs
                .Include(p => p.phieuDatPhong)
                .Include(p => p.phong)
                .FirstOrDefaultAsync(m => m.PhongId == id);
            if (phongPhieuDatPhong == null)
            {
                return NotFound();
            }

            return View(phongPhieuDatPhong);
        }

        // POST: Admin/PhongPhieuDatPhongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phongPhieuDatPhong = await _context.ChiTietPhieuDatPhongs.FindAsync(id);
            _context.ChiTietPhieuDatPhongs.Remove(phongPhieuDatPhong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhongPhieuDatPhongExists(int id)
        {
            return _context.ChiTietPhieuDatPhongs.Any(e => e.PhongId == id);
        }
    }
}
