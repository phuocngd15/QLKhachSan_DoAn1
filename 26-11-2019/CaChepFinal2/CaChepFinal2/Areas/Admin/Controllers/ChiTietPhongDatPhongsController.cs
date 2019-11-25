using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaChepFinal2.Data;

namespace CaChepFinal2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChiTietPhongDatPhongsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChiTietPhongDatPhongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ChiTietPhongDatPhongs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ChiTietPhongDatPhongs.Include(c => c.DatPhong).Include(c => c.Phong);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/ChiTietPhongDatPhongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietPhongDatPhong = await _context.ChiTietPhongDatPhongs
                .Include(c => c.DatPhong)
                .Include(c => c.Phong)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietPhongDatPhong == null)
            {
                return NotFound();
            }

            return View(chiTietPhongDatPhong);
        }

        // GET: Admin/ChiTietPhongDatPhongs/Create
        public IActionResult Create()
        {
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id");
            ViewData["PhongId"] = new SelectList(_context.phongs, "Id", "Id");
            return View();
        }

        // POST: Admin/ChiTietPhongDatPhongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DatPhongId,PhongId,TongSoNgay,GiaTienMotNgay")] ChiTietPhongDatPhong chiTietPhongDatPhong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietPhongDatPhong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", chiTietPhongDatPhong.DatPhongId);
            ViewData["PhongId"] = new SelectList(_context.phongs, "Id", "Id", chiTietPhongDatPhong.PhongId);
            return View(chiTietPhongDatPhong);
        }

        // GET: Admin/ChiTietPhongDatPhongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietPhongDatPhong = await _context.ChiTietPhongDatPhongs.FindAsync(id);
            if (chiTietPhongDatPhong == null)
            {
                return NotFound();
            }
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", chiTietPhongDatPhong.DatPhongId);
            ViewData["PhongId"] = new SelectList(_context.phongs, "Id", "Id", chiTietPhongDatPhong.PhongId);
            return View(chiTietPhongDatPhong);
        }

        // POST: Admin/ChiTietPhongDatPhongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DatPhongId,PhongId,TongSoNgay,GiaTienMotNgay")] ChiTietPhongDatPhong chiTietPhongDatPhong)
        {
            if (id != chiTietPhongDatPhong.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietPhongDatPhong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietPhongDatPhongExists(chiTietPhongDatPhong.Id))
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
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", chiTietPhongDatPhong.DatPhongId);
            ViewData["PhongId"] = new SelectList(_context.phongs, "Id", "Id", chiTietPhongDatPhong.PhongId);
            return View(chiTietPhongDatPhong);
        }

        // GET: Admin/ChiTietPhongDatPhongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietPhongDatPhong = await _context.ChiTietPhongDatPhongs
                .Include(c => c.DatPhong)
                .Include(c => c.Phong)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietPhongDatPhong == null)
            {
                return NotFound();
            }

            return View(chiTietPhongDatPhong);
        }

        // POST: Admin/ChiTietPhongDatPhongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietPhongDatPhong = await _context.ChiTietPhongDatPhongs.FindAsync(id);
            _context.ChiTietPhongDatPhongs.Remove(chiTietPhongDatPhong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietPhongDatPhongExists(int id)
        {
            return _context.ChiTietPhongDatPhongs.Any(e => e.Id == id);
        }
    }
}
