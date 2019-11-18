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
    public class PhieuDatPhongsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhieuDatPhongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/PhieuDatPhongs
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhieuDatPhong.ToListAsync());
        }

        // GET: Admin/PhieuDatPhongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatPhong = await _context.PhieuDatPhong
                .FirstOrDefaultAsync(m => m.PhieuDatPhongId == id);
            if (phieuDatPhong == null)
            {
                return NotFound();
            }

            return View(phieuDatPhong);
        }

        // GET: Admin/PhieuDatPhongs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PhieuDatPhongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhieuDatPhongId,TinhTrang,NgayNhanDuTinh,NgayTraDuTinh,UserId")] PhieuDatPhong phieuDatPhong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phieuDatPhong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phieuDatPhong);
        }

        // GET: Admin/PhieuDatPhongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatPhong = await _context.PhieuDatPhong.FindAsync(id);
            if (phieuDatPhong == null)
            {
                return NotFound();
            }
            return View(phieuDatPhong);
        }

        // POST: Admin/PhieuDatPhongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhieuDatPhongId,TinhTrang,NgayNhanDuTinh,NgayTraDuTinh,UserId")] PhieuDatPhong phieuDatPhong)
        {
            if (id != phieuDatPhong.PhieuDatPhongId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phieuDatPhong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhieuDatPhongExists(phieuDatPhong.PhieuDatPhongId))
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
            return View(phieuDatPhong);
        }

        // GET: Admin/PhieuDatPhongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatPhong = await _context.PhieuDatPhong
                .FirstOrDefaultAsync(m => m.PhieuDatPhongId == id);
            if (phieuDatPhong == null)
            {
                return NotFound();
            }

            return View(phieuDatPhong);
        }

        // POST: Admin/PhieuDatPhongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phieuDatPhong = await _context.PhieuDatPhong.FindAsync(id);
            _context.PhieuDatPhong.Remove(phieuDatPhong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhieuDatPhongExists(int id)
        {
            return _context.PhieuDatPhong.Any(e => e.PhieuDatPhongId == id);
        }
    }
}
