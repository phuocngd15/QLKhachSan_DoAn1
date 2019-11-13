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
    }
}