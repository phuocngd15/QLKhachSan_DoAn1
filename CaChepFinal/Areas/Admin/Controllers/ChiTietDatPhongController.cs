using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaChepFinal.Data;


namespace CaChepFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChiTietDatPhongController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChiTietDatPhongController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ChiTietDatPhong
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.chiTietDatPhongs.Include(c => c.DatPhong).Include(c => c.Phong);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/ChiTietDatPhong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietDatPhong = await _context.chiTietDatPhongs
                .Include(c => c.DatPhong)
                .Include(c => c.Phong)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietDatPhong == null)
            {
                return NotFound();
            }

            return View(chiTietDatPhong);
        }

        // GET: Admin/ChiTietDatPhong/Create
        public IActionResult Create()
        {
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id");
            ViewData["PhongId"] = new SelectList(_context.phongs, "Id", "Id");
            return View();
        }

        // POST: Admin/ChiTietDatPhong/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DatPhongId,PhongId,TongSoNgay,GiaTienMotNgay")] ChiTietDatPhong chiTietDatPhong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietDatPhong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", chiTietDatPhong.DatPhongId);
            ViewData["PhongId"] = new SelectList(_context.phongs, "Id", "Id", chiTietDatPhong.PhongId);
            return View(chiTietDatPhong);
        }

        // GET: Admin/ChiTietDatPhong/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietDatPhong = await _context.chiTietDatPhongs.FindAsync(id);
            if (chiTietDatPhong == null)
            {
                return NotFound();
            }
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", chiTietDatPhong.DatPhongId);
            ViewData["PhongId"] = new SelectList(_context.phongs, "Id", "Id", chiTietDatPhong.PhongId);
            return View(chiTietDatPhong);
        }

        // POST: Admin/ChiTietDatPhong/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DatPhongId,PhongId,TongSoNgay,GiaTienMotNgay")] ChiTietDatPhong chiTietDatPhong)
        {
            if (id != chiTietDatPhong.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietDatPhong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietDatPhongExists(chiTietDatPhong.Id))
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
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", chiTietDatPhong.DatPhongId);
            ViewData["PhongId"] = new SelectList(_context.phongs, "Id", "Id", chiTietDatPhong.PhongId);
            return View(chiTietDatPhong);
        }

        // GET: Admin/ChiTietDatPhong/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietDatPhong = await _context.chiTietDatPhongs
                .Include(c => c.DatPhong)
                .Include(c => c.Phong)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietDatPhong == null)
            {
                return NotFound();
            }

            return View(chiTietDatPhong);
        }

        // POST: Admin/ChiTietDatPhong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietDatPhong = await _context.chiTietDatPhongs.FindAsync(id);
            _context.chiTietDatPhongs.Remove(chiTietDatPhong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietDatPhongExists(int id)
        {
            return _context.chiTietDatPhongs.Any(e => e.Id == id);
        }
    }
}
