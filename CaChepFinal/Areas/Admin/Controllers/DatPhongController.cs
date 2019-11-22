using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaChepFinal.Data;
using CaChepFinal.Models.DataModels;
using CaChepFinal.Models.ViewModels;

namespace CaChepFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DatPhongController : Controller
    {
        private readonly ApplicationDbContext _context;
         public DatPhongController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Index gom nhieu thanh phan: DatPhong, ChiTietDatPhong,
        public async Task<IActionResult> Index()
        {
            // var datPhongs = await _context.datPhongs.ToListAsync();
            var datPhongTongHop = new DatPhongTongHop
            {
                datPhongs = await _context.datPhongs.ToListAsync(),
                chiTietDatPhongs = await _context.chiTietDatPhongs.ToListAsync()
            };
            return View(datPhongTongHop);

        }
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/DatPhong2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DatPhongTongHop aModel ,[Bind("Id,TenNguoiDat,Address,City,CMND,SDT,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,UserId")] DatPhong datPhong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aModel.newDatPhong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aModel.newDatPhong);
        }


    }
}