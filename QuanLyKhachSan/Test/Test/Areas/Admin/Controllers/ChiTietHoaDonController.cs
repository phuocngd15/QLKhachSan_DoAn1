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
    public class ChiTietHoaDonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChiTietHoaDonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ChiTietHoaDon
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChiTietHoaDon.ToListAsync());
        }

        // GET: Admin/ChiTietHoaDon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.ChiTietHoaDon
                .FirstOrDefaultAsync(m => m.IdBill == id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDon);
        }

        // GET: Admin/ChiTietHoaDon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ChiTietHoaDon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBill,TenDichVu,SoLuong,GiaTienDichVu,PhieuDatPhongId")] ChiTietHoaDon chiTietHoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietHoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chiTietHoaDon);
        }

        // GET: Admin/ChiTietHoaDon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.ChiTietHoaDon.FindAsync(id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }
            return View(chiTietHoaDon);
        }

        // POST: Admin/ChiTietHoaDon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdBill,TenDichVu,SoLuong,GiaTienDichVu,PhieuDatPhongId")] ChiTietHoaDon chiTietHoaDon)
        {
            if (id != chiTietHoaDon.IdBill)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietHoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHoaDonExists(chiTietHoaDon.IdBill))
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
            return View(chiTietHoaDon);
        }

        // GET: Admin/ChiTietHoaDon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.ChiTietHoaDon
                .FirstOrDefaultAsync(m => m.IdBill == id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDon);
        }

        // POST: Admin/ChiTietHoaDon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietHoaDon = await _context.ChiTietHoaDon.FindAsync(id);
            _context.ChiTietHoaDon.Remove(chiTietHoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHoaDonExists(int id)
        {
            return _context.ChiTietHoaDon.Any(e => e.IdBill == id);
        }
    }
}
