using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hotel.Data;
using Hotel.Models;

namespace Hotel.Controllers
{
    public class PhongsController : Controller
    {
        private readonly HotelDataContext _context;

        public PhongsController(HotelDataContext context)
        {
            _context = context;
        }

        // GET: Phongs
        public async Task<IActionResult> Index()
        {
            var hotelDataContext = _context.Phongs.Include(p => p.LoaiPhongs);
            return View(await hotelDataContext.ToListAsync());
        }

        // GET: Phongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.Phongs
                .Include(p => p.LoaiPhongs)
                .FirstOrDefaultAsync(m => m.PhongId == id);
            if (phong == null)
            {
                return NotFound();
            }

            return View(phong);
        }

        // GET: Phongs/Create
        public IActionResult Create()
        {
            ViewData["LoaiPhongId"] = new SelectList(_context.LoaiPhongs, "LoaiPhongId", "LoaiPhongId");
            return View();
        }

        // POST: Phongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhongId,TenPhong,SoNguoiOToiDa,MoTaPhong,CachTinhTien,PhuThu,TinhTrangPhong,LoaiPhongId")] Phong phong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LoaiPhongId"] = new SelectList(_context.LoaiPhongs, "LoaiPhongId", "LoaiPhongId", phong.LoaiPhongId);
            return View(phong);
        }

        // GET: Phongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.Phongs.FindAsync(id);
            if (phong == null)
            {
                return NotFound();
            }
            ViewData["LoaiPhongId"] = new SelectList(_context.LoaiPhongs, "LoaiPhongId", "LoaiPhongId", phong.LoaiPhongId);
            return View(phong);
        }

        // POST: Phongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhongId,TenPhong,SoNguoiOToiDa,MoTaPhong,CachTinhTien,PhuThu,TinhTrangPhong,LoaiPhongId")] Phong phong)
        {
            if (id != phong.PhongId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhongExists(phong.PhongId))
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
            ViewData["LoaiPhongId"] = new SelectList(_context.LoaiPhongs, "LoaiPhongId", "LoaiPhongId", phong.LoaiPhongId);
            return View(phong);
        }

        // GET: Phongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.Phongs
                .Include(p => p.LoaiPhongs)
                .FirstOrDefaultAsync(m => m.PhongId == id);
            if (phong == null)
            {
                return NotFound();
            }

            return View(phong);
        }

        // POST: Phongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phong = await _context.Phongs.FindAsync(id);
            _context.Phongs.Remove(phong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhongExists(int id)
        {
            return _context.Phongs.Any(e => e.PhongId == id);
        }
    }
}
