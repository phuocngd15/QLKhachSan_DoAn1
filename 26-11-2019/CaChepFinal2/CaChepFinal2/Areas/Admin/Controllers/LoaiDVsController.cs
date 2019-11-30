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
    public class LoaiDVsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoaiDVsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/LoaiDVs
        public async Task<IActionResult> Index()
        {
            return View(await _context.loaiDVs.ToListAsync());
        }

        // GET: Admin/LoaiDVs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiDV = await _context.loaiDVs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loaiDV == null)
            {
                return NotFound();
            }

            return View(loaiDV);
        }

        // GET: Admin/LoaiDVs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiDVs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,ImageUrl")] LoaiDV loaiDV)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiDV);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiDV);
        }

        // GET: Admin/LoaiDVs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiDV = await _context.loaiDVs.FindAsync(id);
            if (loaiDV == null)
            {
                return NotFound();
            }
            return View(loaiDV);
        }

        // POST: Admin/LoaiDVs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,ImageUrl")] LoaiDV loaiDV)
        {
            if (id != loaiDV.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiDV);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiDVExists(loaiDV.Id))
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
            return View(loaiDV);
        }

        // GET: Admin/LoaiDVs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiDV = await _context.loaiDVs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loaiDV == null)
            {
                return NotFound();
            }

            return View(loaiDV);
        }

        // POST: Admin/LoaiDVs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiDV = await _context.loaiDVs.FindAsync(id);
            _context.loaiDVs.Remove(loaiDV);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiDVExists(int id)
        {
            return _context.loaiDVs.Any(e => e.Id == id);
        }
    }
}