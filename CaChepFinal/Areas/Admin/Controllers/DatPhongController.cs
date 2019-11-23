using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaChepFinal.Data;

using CaChepFinal.Models.ViewModels;
using CaChepFinal.Service;
using CaChepFinal;
namespace CaChepFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DatPhongController : Controller
    {
        private readonly IDatPhong _datphong;
        private readonly IChiTietDatPhong _chitietDatPhong;
        private readonly Mapper _mapper; // dung de Mampping DataModel vs ViewModel

        public DatPhongController(IDatPhong datPhong, IChiTietDatPhong chiTietDatPhong)
        {
            _datphong = datPhong;
            _chitietDatPhong = chiTietDatPhong;
            _mapper = new Mapper();
        }

        // Index gom nhieu thanh phan: DatPhong, ChiTietDatPhong,
        public IActionResult Index()
        {
            // var datPhongs = await _context.datPhongs.ToListAsync();
            var datPhongTongHop = new DatPhongTongHop
            {
                datPhongs = _datphong.GetAll().ToList(),
                chiTietDatPhongs = _chitietDatPhong.GetAll().ToList()
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
        public IActionResult Create(DatPhongTongHop aModel, [Bind("Id,TenNguoiDat,Address,City,CMND,SDT,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,UserId")] DatPhong datPhong)
        {

            if (ModelState.IsValid)
            {
                _datphong.New(aModel.newDatPhong);

                var soNgayO = (datPhong.ThoiGianTraPhongDuKien.Date - datPhong.ThoiGianNhanPhongDuKien.Date).TotalDays;
                while (soNgayO != 0)
                {
                    // Id
                    // DatPhongId
                    // PhongId
                    // TongSoNgay { get; set; }
                    // GiaTienMotNgay { get; set; }
                    // Phong Phong { get; set; }
                    // DatPhong DatPhong { get; set; }

                    // _chitietDatPhong.New()
                 }

                return RedirectToAction(nameof(Index));
            }
            return View(aModel.newDatPhong);
        }


    }
}