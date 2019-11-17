using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Data;
using Test.Models;

namespace Test.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoaiDichVuController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LoaiDichVuController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.LoaiDichVu.ToList());
        }

        //GET CREATE action method
        public IActionResult Create()
        {
            return View();
        }

        // POST CREATE  action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LoaiDichVu loaiDichVu)
        {
            if (ModelState.IsValid)
            {
                _db.Add(loaiDichVu);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiDichVu);
        }


        //GET Edit action method
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var LoaiDichVu = await _db.LoaiDichVu.FindAsync(id);
            if (LoaiDichVu == null)
            {
                return NotFound();
            }
            return View(LoaiDichVu);
        }

        //POST Edit action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LoaiDichVu LoaiDichVu)
        {
            if (id != LoaiDichVu.LoaiDichVuId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Update(LoaiDichVu);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(LoaiDichVu);
        }

        //GET Details action method
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiDichVu = await _db.LoaiDichVu.FindAsync(id);
            if (loaiDichVu == null)
            {
                return NotFound();
            }
            return View(loaiDichVu);
        }

        //GET Delete action method
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiDichVu = await _db.LoaiDichVu.FindAsync(id);
            if (loaiDichVu == null)
            {
                return NotFound();
            }
            return View(loaiDichVu);
        }

        //POST Delete action method
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiDichVu = await _db.LoaiDichVu.FindAsync(id);
            _db.LoaiDichVu.Remove(loaiDichVu);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}