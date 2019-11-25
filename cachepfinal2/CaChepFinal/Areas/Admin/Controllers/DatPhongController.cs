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
        private readonly IDatPhong _datphongsv;
        private readonly IChiTietDatPhong _chitietDatPhongsv;
        private readonly ITrangThaiDatPhong _TrangThaiDatPhongsv;
        private readonly ITrangThai _TrangThaisv;


        private readonly Mapper _mapper; // dung de Mampping DataModel vs ViewModel

        public DatPhongController(IDatPhong datPhong, IChiTietDatPhong chiTietDatPhong)
        {
            _datphongsv = datPhong;
            _chitietDatPhongsv = chiTietDatPhong;
            _mapper = new Mapper();
        }

        // Index gom nhieu thanh phan: DatPhong, ChiTietDatPhong,
        public IActionResult Index(DatPhongTongHop datPhongTongHop)
        {
            // var datPhongs = await _context.datPhongs.ToListAsync();
            if (datPhongTongHop.chiTietDatPhongs == null && datPhongTongHop.datPhongs == null)
            {
                var newdatPhongTongHop = new DatPhongTongHop
                {
                    datPhongs = _datphongsv.GetAll().OrderByDescending(c => c.ThoiGianNhanPhongDuKien).ToList(),
                    chiTietDatPhongs = null
                };
                return View(newdatPhongTongHop);
            }
            return View(datPhongTongHop);

        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // tao 1 list dat phong, va them 1 dong record vao list;
            var OnedatPhongFromDB = _datphongsv.GetOneById(id);
            var newdatPhongs = new List<DatPhong>();
            newdatPhongs.Add(OnedatPhongFromDB);

            var chiTietDatPhong = _chitietDatPhongsv.GetByIDPhieuDatPhong(id);
            var newchitietdatphong = chiTietDatPhong.ToList();


            var datPhongTongHop = new DatPhongTongHop
            {
                datPhongs = newdatPhongs,
                chiTietDatPhongs = newchitietdatphong
            };

            if (OnedatPhongFromDB == null)
            {
                return NotFound();
            }

            return View("DatPhongDetail", datPhongTongHop);
        }
        //get :Admin/DatPhong/create
        public IActionResult CreateDatPhong()
        {
            return View();
        }

        // POST: Admin/DatPhong2/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateDatPhong(DatPhongTongHop aModel, [Bind("Id,TenNguoiDat,Address,City,CMND,SDT,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,UserId")] DatPhong datPhong)
        {
            if (ModelState.IsValid)
            {
                _datphongsv.New(aModel.newDatPhong);
                return RedirectToAction(nameof(Index));
            }
            return View(aModel.newDatPhong);
        }




    }
}