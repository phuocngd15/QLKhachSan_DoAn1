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
    public class LoaiDichVusController : Controller
    {
        private readonly HotelDataContext _context;

        public LoaiDichVusController(HotelDataContext context)
        {
            _context = context;
        }

        // GET: LoaiDichVus
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiDichVus.ToListAsync());
        }

        // GET: LoaiDichVus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiDichVu = await _context.LoaiDichVus
                .FirstOrDefaultAsync(m => m.LoaiDichVuId == id);
            if (loaiDichVu == null)
            {
                return NotFound();
            }

            return View(loaiDichVu);
        }

        // GET: LoaiDichVus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoaiDichVus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoaiDichVuId,TenLoaiDichVu")] LoaiDichVu loaiDichVu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiDichVu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiDichVu);
        }

        // GET: LoaiDichVus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiDichVu = await _context.LoaiDichVus.FindAsync(id);
            if (loaiDichVu == null)
            {
                return NotFound();
            }
            return View(loaiDichVu);
        }

        // POST: LoaiDichVus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoaiDichVuId,TenLoaiDichVu")] LoaiDichVu loaiDichVu)
        {
            if (id != loaiDichVu.LoaiDichVuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiDichVu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiDichVuExists(loaiDichVu.LoaiDichVuId))
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
            return View(loaiDichVu);
        }

        // GET: LoaiDichVus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiDichVu = await _context.LoaiDichVus
                .FirstOrDefaultAsync(m => m.LoaiDichVuId == id);
            if (loaiDichVu == null)
            {
                return NotFound();
            }

            return View(loaiDichVu);
        }

        // POST: LoaiDichVus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiDichVu = await _context.LoaiDichVus.FindAsync(id);
            _context.LoaiDichVus.Remove(loaiDichVu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiDichVuExists(int id)
        {
            return _context.LoaiDichVus.Any(e => e.LoaiDichVuId == id);
        }
    }
}
