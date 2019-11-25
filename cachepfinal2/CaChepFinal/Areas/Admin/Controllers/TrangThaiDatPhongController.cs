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
    public class TrangThaiDatPhongController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrangThaiDatPhongController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/TrangThaiDatPhong
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.trangThaiDatPhongs.Include(t => t.GetDatPhong).Include(t => t.GetTrangThai);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/TrangThaiDatPhong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trangThaiDatPhong = await _context.trangThaiDatPhongs
                .Include(t => t.GetDatPhong)
                .Include(t => t.GetTrangThai)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trangThaiDatPhong == null)
            {
                return NotFound();
            }

            return View(trangThaiDatPhong);
        }

        // GET: Admin/TrangThaiDatPhong/Create
        public IActionResult Create()
        {
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id");
            ViewData["TrangThaiId"] = new SelectList(_context.trangThais, "Id", "Id");
            return View();
        }

        // POST: Admin/TrangThaiDatPhong/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DatPhongId,TrangThaiId,ThoiGian")] TrangThaiDatPhong trangThaiDatPhong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trangThaiDatPhong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", trangThaiDatPhong.DatPhongId);
            ViewData["TrangThaiId"] = new SelectList(_context.trangThais, "Id", "Id", trangThaiDatPhong.TrangThaiId);
            return View(trangThaiDatPhong);
        }

        // GET: Admin/TrangThaiDatPhong/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trangThaiDatPhong = await _context.trangThaiDatPhongs.FindAsync(id);
            if (trangThaiDatPhong == null)
            {
                return NotFound();
            }
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", trangThaiDatPhong.DatPhongId);
            ViewData["TrangThaiId"] = new SelectList(_context.trangThais, "Id", "Id", trangThaiDatPhong.TrangThaiId);
            return View(trangThaiDatPhong);
        }

        // POST: Admin/TrangThaiDatPhong/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DatPhongId,TrangThaiId,ThoiGian")] TrangThaiDatPhong trangThaiDatPhong)
        {
            if (id != trangThaiDatPhong.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trangThaiDatPhong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrangThaiDatPhongExists(trangThaiDatPhong.Id))
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
            ViewData["DatPhongId"] = new SelectList(_context.datPhongs, "Id", "Id", trangThaiDatPhong.DatPhongId);
            ViewData["TrangThaiId"] = new SelectList(_context.trangThais, "Id", "Id", trangThaiDatPhong.TrangThaiId);
            return View(trangThaiDatPhong);
        }

        // GET: Admin/TrangThaiDatPhong/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trangThaiDatPhong = await _context.trangThaiDatPhongs
                .Include(t => t.GetDatPhong)
                .Include(t => t.GetTrangThai)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trangThaiDatPhong == null)
            {
                return NotFound();
            }

            return View(trangThaiDatPhong);
        }

        // POST: Admin/TrangThaiDatPhong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trangThaiDatPhong = await _context.trangThaiDatPhongs.FindAsync(id);
            _context.trangThaiDatPhongs.Remove(trangThaiDatPhong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrangThaiDatPhongExists(int id)
        {
            return _context.trangThaiDatPhongs.Any(e => e.Id == id);
        }
    }
}
