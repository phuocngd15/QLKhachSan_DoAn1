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
    public class DichVusController : Controller
    {
        private readonly HotelDataContext _context;

        public DichVusController(HotelDataContext context)
        {
            _context = context;
        }

        // GET: DichVus
        public async Task<IActionResult> Index()
        {
            var hotelDataContext = _context.DichVus.Include(d => d.LoaiDichVu);
            return View(await hotelDataContext.ToListAsync());
        }

        // GET: DichVus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dichVu = await _context.DichVus
                .Include(d => d.LoaiDichVu)
                .FirstOrDefaultAsync(m => m.DichVuId == id);
            if (dichVu == null)
            {
                return NotFound();
            }

            return View(dichVu);
        }

        // GET: DichVus/Create
        public IActionResult Create()
        {
            ViewData["LoaiDichVuId"] = new SelectList(_context.LoaiDichVus, "LoaiDichVuId", "LoaiDichVuId");
            return View();
        }

        // POST: DichVus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DichVuId,TenDichVu,GiaBan,GiaNhap,LoaiDichVuId")] DichVu dichVu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dichVu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LoaiDichVuId"] = new SelectList(_context.LoaiDichVus, "LoaiDichVuId", "LoaiDichVuId", dichVu.LoaiDichVuId);
            return View(dichVu);
        }

        // GET: DichVus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dichVu = await _context.DichVus.FindAsync(id);
            if (dichVu == null)
            {
                return NotFound();
            }
            ViewData["LoaiDichVuId"] = new SelectList(_context.LoaiDichVus, "LoaiDichVuId", "LoaiDichVuId", dichVu.LoaiDichVuId);
            return View(dichVu);
        }

        // POST: DichVus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DichVuId,TenDichVu,GiaBan,GiaNhap,LoaiDichVuId")] DichVu dichVu)
        {
            if (id != dichVu.DichVuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dichVu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DichVuExists(dichVu.DichVuId))
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
            ViewData["LoaiDichVuId"] = new SelectList(_context.LoaiDichVus, "LoaiDichVuId", "LoaiDichVuId", dichVu.LoaiDichVuId);
            return View(dichVu);
        }

        // GET: DichVus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dichVu = await _context.DichVus
                .Include(d => d.LoaiDichVu)
                .FirstOrDefaultAsync(m => m.DichVuId == id);
            if (dichVu == null)
            {
                return NotFound();
            }

            return View(dichVu);
        }

        // POST: DichVus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dichVu = await _context.DichVus.FindAsync(id);
            _context.DichVus.Remove(dichVu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DichVuExists(int id)
        {
            return _context.DichVus.Any(e => e.DichVuId == id);
        }
    }
}
