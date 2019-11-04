using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyHoTel.Data;
using HappyHoTel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel.Resolution;

namespace HappyHoTel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoaiPhongController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoaiPhongController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        
        public IActionResult Index()
        {
            return View(_db.LoaiPhongs.ToList());
        }
        
        public IActionResult Create()
        {
            return View();
        }
        // Post create action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LoaiPhong loaiPhong)
        {
            if (ModelState.IsValid)
            { 
                _db.Add(loaiPhong);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(loaiPhong);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {  return NotFound();}

            var loaiphong = await _db.LoaiPhongs.FindAsync(id);
            if (loaiphong == null)
                return NotFound();
            return View(loaiphong);
        }
        // Post Edit action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,LoaiPhong loaiPhong)
        {
            if (id != loaiPhong.LoaiPhongId) return NotFound();
            if (ModelState.IsValid)
            {
                _db.Add(loaiPhong);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(loaiPhong);
        }

    }
}