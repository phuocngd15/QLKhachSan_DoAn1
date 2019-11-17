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
    public class LoaiPhongController : Controller
    {
       
        private readonly ApplicationDbContext _db;
        public LoaiPhongController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.LoaiPhong.ToList());
        }

        //GET create action method
        public IActionResult Create()
        {

            return View();
        }

        //POST create action method
        [HttpPost]
        [ValidateAntiForgeryToken]
         public async Task<IActionResult> Create(LoaiPhong loaiPhong)
         {
            if(ModelState.IsValid)
            {
                _db.Add(loaiPhong);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiPhong);
         }

        //GET Edit action method
        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            var loaiPhong = await _db.LoaiPhong.FindAsync(id);
            if(loaiPhong == null)
            {
                return NotFound();
            }
            return View(loaiPhong);
        }

        //POST Edit action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LoaiPhong loaiPhong)
        {
            if(id!=loaiPhong.LoaiPhongId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Update(loaiPhong);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiPhong);
        }


        //GET Details action method
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiPhong = await _db.LoaiPhong.FindAsync(id);
            if (loaiPhong == null)
            {
                return NotFound();
            }
            return View(loaiPhong);
        }


        //GET Delete action method
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound(); 
            }

            var loaiPhong = await _db.LoaiPhong.FindAsync(id);
            if (loaiPhong == null)
            {
                return NotFound();
            }
            return View(loaiPhong);
        }

        //POST Delete action method
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiPhong = await _db.LoaiPhong.FindAsync(id);
            _db.LoaiPhong.Remove(loaiPhong);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}