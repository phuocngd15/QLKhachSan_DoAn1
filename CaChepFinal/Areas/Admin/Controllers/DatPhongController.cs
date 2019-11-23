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
using CaChepFinal.Service;

namespace CaChepFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DatPhongController : Controller
    {
       private readonly DatPhongService _datphong;
       private readonly ChiTietDatPhongService _chitietDatPhong;
        public DatPhongController(DatPhongService datphong)
        {
            _datphong = datphong;
        }

        // Index gom nhieu thanh phan: DatPhong, ChiTietDatPhong,
        public async Task<IActionResult> Index()
        {
            // var datPhongs = await _context.datPhongs.ToListAsync();
            var datPhongTongHop = new DatPhongTongHop
            {
                datPhongs = await _datphong.GetAll().ToListAsync(),
                chiTietDatPhongs = null
            };
            return View(datPhongTongHop);

        }
        //get :Admin/DatPhong/create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/DatPhong2/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DatPhongTongHop aModel, [Bind("Id,TenNguoiDat,Address,City,CMND,SDT,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,UserId")] DatPhong datPhong)
        {
            if (ModelState.IsValid)
            {
                _datphong.New(aModel.newDatPhong);
               // await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aModel.newDatPhong);
        }


    }
}