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
    public class DichVuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DichVuController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/DichVu
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DichVu.Include(d => d.LoaiDichVu);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/DichVu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dichVu = await _context.DichVu
                .Include(d => d.LoaiDichVu)
                .FirstOrDefaultAsync(m => m.DichVuId == id);
            if (dichVu == null)
            {
                return NotFound();
            }

            return View(dichVu);
        }

        // GET: Admin/DichVu/Create
        public IActionResult Create()
        {
            ViewData["LoaiDichVuId"] = new SelectList(_context.LoaiDichVu, "LoaiDichVuId", "LoaiDichVuId");
            return View();
        }

        // POST: Admin/DichVu/Create
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
            ViewData["LoaiDichVuId"] = new SelectList(_context.LoaiDichVu, "LoaiDichVuId", "LoaiDichVuId", dichVu.LoaiDichVuId);
            return View(dichVu);
        }

        // GET: Admin/DichVu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dichVu = await _context.DichVu.FindAsync(id);
            if (dichVu == null)
            {
                return NotFound();
            }
            ViewData["LoaiDichVuId"] = new SelectList(_context.LoaiDichVu, "LoaiDichVuId", "LoaiDichVuId", dichVu.LoaiDichVuId);
            return View(dichVu);
        }

        // POST: Admin/DichVu/Edit/5
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
            ViewData["LoaiDichVuId"] = new SelectList(_context.LoaiDichVu, "LoaiDichVuId", "LoaiDichVuId", dichVu.LoaiDichVuId);
            return View(dichVu);
        }

        // GET: Admin/DichVu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dichVu = await _context.DichVu
                .Include(d => d.LoaiDichVu)
                .FirstOrDefaultAsync(m => m.DichVuId == id);
            if (dichVu == null)
            {
                return NotFound();
            }

            return View(dichVu);
        }

        // POST: Admin/DichVu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dichVu = await _context.DichVu.FindAsync(id);
            _context.DichVu.Remove(dichVu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DichVuExists(int id)
        {
            return _context.DichVu.Any(e => e.DichVuId == id);
        }
    }
}
