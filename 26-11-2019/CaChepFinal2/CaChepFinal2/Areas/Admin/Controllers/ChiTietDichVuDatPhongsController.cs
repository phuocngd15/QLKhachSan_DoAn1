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
    public class ChiTietDichVuDatPhongsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChiTietDichVuDatPhongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ChiTietDichVuDatPhongs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ChiTietDichVuDatPhongs.Include(c => c.GetDatPhong).Include(c => c.GetDichVu);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/ChiTietDichVuDatPhongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietDichVuDatPhong = await _context.ChiTietDichVuDatPhongs
                .Include(c => c.GetDatPhong)
                .Include(c => c.GetDichVu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietDichVuDatPhong == null)
            {
                return NotFound();
            }

            return View(chiTietDichVuDatPhong);
        }

        // GET: Admin/ChiTietDichVuDatPhongs/Create
        public IActionResult Create()
        {
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id");
            ViewData["DichVuId"] = new SelectList(_context.dichVus, "Id", "Id");
            return View();
        }

        // POST: Admin/ChiTietDichVuDatPhongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DatPhongId,DichVuId,SoLuong,GiaTien")] ChiTietDichVuDatPhong chiTietDichVuDatPhong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietDichVuDatPhong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", chiTietDichVuDatPhong.DatPhongId);
            ViewData["DichVuId"] = new SelectList(_context.dichVus, "Id", "Id", chiTietDichVuDatPhong.DichVuId);
            return View(chiTietDichVuDatPhong);
        }

        // GET: Admin/ChiTietDichVuDatPhongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietDichVuDatPhong = await _context.ChiTietDichVuDatPhongs.FindAsync(id);
            if (chiTietDichVuDatPhong == null)
            {
                return NotFound();
            }
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", chiTietDichVuDatPhong.DatPhongId);
            ViewData["DichVuId"] = new SelectList(_context.dichVus, "Id", "Id", chiTietDichVuDatPhong.DichVuId);
            return View(chiTietDichVuDatPhong);
        }

        // POST: Admin/ChiTietDichVuDatPhongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DatPhongId,DichVuId,SoLuong,GiaTien")] ChiTietDichVuDatPhong chiTietDichVuDatPhong)
        {
            if (id != chiTietDichVuDatPhong.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietDichVuDatPhong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietDichVuDatPhongExists(chiTietDichVuDatPhong.Id))
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
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", chiTietDichVuDatPhong.DatPhongId);
            ViewData["DichVuId"] = new SelectList(_context.dichVus, "Id", "Id", chiTietDichVuDatPhong.DichVuId);
            return View(chiTietDichVuDatPhong);
        }

        // GET: Admin/ChiTietDichVuDatPhongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietDichVuDatPhong = await _context.ChiTietDichVuDatPhongs
                .Include(c => c.GetDatPhong)
                .Include(c => c.GetDichVu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietDichVuDatPhong == null)
            {
                return NotFound();
            }

            return View(chiTietDichVuDatPhong);
        }

        // POST: Admin/ChiTietDichVuDatPhongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietDichVuDatPhong = await _context.ChiTietDichVuDatPhongs.FindAsync(id);
            _context.ChiTietDichVuDatPhongs.Remove(chiTietDichVuDatPhong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietDichVuDatPhongExists(int id)
        {
            return _context.ChiTietDichVuDatPhongs.Any(e => e.Id == id);
        }
    }
}
