using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaChepFinal.Data;
using CaChepFinal.Models.DataModels;

namespace CaChepFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DatPhong2Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public DatPhong2Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/DatPhong2
        public async Task<IActionResult> Index()
        {
            return View(await _context.datPhongs.ToListAsync());
        }

        // GET: Admin/DatPhong2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhong = await _context.datPhongs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datPhong == null)
            {
                return NotFound();
            }

            return View(datPhong);
        }

        // GET: Admin/DatPhong2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/DatPhong2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenNguoiDat,Address,City,CMND,SDT,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,UserId")] DatPhong datPhong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(datPhong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(datPhong);
        }

        // GET: Admin/DatPhong2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhong = await _context.datPhongs.FindAsync(id);
            if (datPhong == null)
            {
                return NotFound();
            }
            return View(datPhong);
        }

        // POST: Admin/DatPhong2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenNguoiDat,Address,City,CMND,SDT,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,UserId")] DatPhong datPhong)
        {
            if (id != datPhong.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(datPhong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatPhongExists(datPhong.Id))
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
            return View(datPhong);
        }

        // GET: Admin/DatPhong2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhong = await _context.datPhongs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datPhong == null)
            {
                return NotFound();
            }

            return View(datPhong);
        }

        // POST: Admin/DatPhong2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var datPhong = await _context.datPhongs.FindAsync(id);
            _context.datPhongs.Remove(datPhong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


// xem co ton tai phong khong de get, update
// dung de kt try catch
        private bool DatPhongExists(int id)  
        {
            return _context.datPhongs.Any(e => e.Id == id);
        }
    }
}
