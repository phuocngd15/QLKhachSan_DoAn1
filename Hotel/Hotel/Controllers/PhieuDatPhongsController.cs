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
    public class PhieuDatPhongsController : Controller
    {
        private readonly HotelDataContext _context;

        public PhieuDatPhongsController(HotelDataContext context)
        {
            _context = context;
        }

        // GET: PhieuDatPhongs
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhieuDatPhongs.ToListAsync());
        }

        // GET: PhieuDatPhongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatPhong = await _context.PhieuDatPhongs
                .FirstOrDefaultAsync(m => m.PhieuDatPhongId == id);
            if (phieuDatPhong == null)
            {
                return NotFound();
            }

            return View(phieuDatPhong);
        }

        // GET: PhieuDatPhongs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhieuDatPhongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhieuDatPhongId,TinhTrang,NgayNhanDuTinh,NgayTraDuTinh,UserId")] PhieuDatPhong phieuDatPhong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phieuDatPhong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phieuDatPhong);
        }

        // GET: PhieuDatPhongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatPhong = await _context.PhieuDatPhongs.FindAsync(id);
            if (phieuDatPhong == null)
            {
                return NotFound();
            }
            return View(phieuDatPhong);
        }

        // POST: PhieuDatPhongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhieuDatPhongId,TinhTrang,NgayNhanDuTinh,NgayTraDuTinh,UserId")] PhieuDatPhong phieuDatPhong)
        {
            if (id != phieuDatPhong.PhieuDatPhongId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phieuDatPhong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhieuDatPhongExists(phieuDatPhong.PhieuDatPhongId))
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
            return View(phieuDatPhong);
        }

        // GET: PhieuDatPhongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatPhong = await _context.PhieuDatPhongs
                .FirstOrDefaultAsync(m => m.PhieuDatPhongId == id);
            if (phieuDatPhong == null)
            {
                return NotFound();
            }

            return View(phieuDatPhong);
        }

        // POST: PhieuDatPhongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phieuDatPhong = await _context.PhieuDatPhongs.FindAsync(id);
            _context.PhieuDatPhongs.Remove(phieuDatPhong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhieuDatPhongExists(int id)
        {
            return _context.PhieuDatPhongs.Any(e => e.PhieuDatPhongId == id);
        }
    }
}
