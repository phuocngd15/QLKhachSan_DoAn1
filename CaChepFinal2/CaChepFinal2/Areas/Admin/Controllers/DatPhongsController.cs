﻿using System;
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
    public class DatPhongsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DatPhongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/DatPhongs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.datPhongs.Include(d => d.GetTrangThai);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/DatPhongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhong = await _context.datPhongs
                .Include(d => d.GetTrangThai)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datPhong == null)
            {
                return NotFound();
            }

            return View(datPhong);
        }

        // GET: Admin/DatPhongs/Create
        public IActionResult Create()
        {
            ViewData["TrangThaiId"] = new SelectList(_context.trangThais, "Id", "Id");
            return View();
        }

        // POST: Admin/DatPhongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenNguoiDat,Address,City,CMND,SDT,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,TrangThaiId")] DatPhong datPhong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(datPhong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TrangThaiId"] = new SelectList(_context.trangThais, "Id", "Id", datPhong.TrangThaiId);
            return View(datPhong);
        }

        // GET: Admin/DatPhongs/Edit/5
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
            ViewData["TrangThaiId"] = new SelectList(_context.trangThais, "Id", "Id", datPhong.TrangThaiId);
            return View(datPhong);
        }

        // POST: Admin/DatPhongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenNguoiDat,Address,City,CMND,SDT,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,TrangThaiId")] DatPhong datPhong)
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
            ViewData["TrangThaiId"] = new SelectList(_context.trangThais, "Id", "Id", datPhong.TrangThaiId);
            return View(datPhong);
        }

        // GET: Admin/DatPhongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhong = await _context.datPhongs
                .Include(d => d.GetTrangThai)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datPhong == null)
            {
                return NotFound();
            }

            return View(datPhong);
        }

        // POST: Admin/DatPhongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var datPhong = await _context.datPhongs.FindAsync(id);
            _context.datPhongs.Remove(datPhong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatPhongExists(int id)
        {
            return _context.datPhongs.Any(e => e.Id == id);
        }
    }
}