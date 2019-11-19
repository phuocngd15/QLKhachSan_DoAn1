using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Test.Data;
using Test.Extensions;
using Test.Models;
using Test.Models.ViewModel;


namespace Test.Controllers
{
    [Area("Customer")]
    public class DatPhongController : Controller
    {
        private readonly ApplicationDbContext _context;
        private PhongTinhTrangViewModel _phongTinhTrangView;
        public DatPhongController(ApplicationDbContext context)
        {
            _context = context;
            _phongTinhTrangView = new PhongTinhTrangViewModel()
            {
                ListPhongDat = new List<Phong>()
            };
        }
        // tim kiếm
        public async Task<IActionResult> Index(PhongTinhTrangViewModel aModel, [Bind("NgayNhanDuTinh,NgayTraDuTinh")] PhieuDatPhong phieuDatPhong)
        {

            // tại là kiểu tình trạng phòng là int, có thể lưu kiểu phòng là string, và kèm theo cái numericDown;
            IQueryable<string> loaiPhongQuery = from m in _context.LoaiPhong
                                                orderby m.TenLoaiPhong descending
                                                select m.TenLoaiPhong;

            var phongs = from m in _context.Phong
                         select m;

            if (!phieuDatPhong.NgayNhanDuTinh.Equals(default))
            {
                // chua dong ket noi hay sao ne
                var a = aModel.PhieuDatPhong.NgayNhanDuTinh;
                var b = aModel.PhieuDatPhong.NgayTraDuTinh;

                var phieuDatid = from m in _context.PhieuDatPhong
                                 where ((m.NgayNhanDuTinh <= b && b < m.NgayTraDuTinh) ||
                                        (m.NgayNhanDuTinh < a && a <= m.NgayTraDuTinh)) ||
                                       (a <= m.NgayNhanDuTinh && m.NgayTraDuTinh <= b) &&
                                       (m.TinhTrang == false) // tim phong ma phieu dat phong con cho`.
                                 select m.PhieuDatPhongId;
                var phongid = _context.ChiTietPhieuDatPhongs.Where(p => phieuDatid.Contains(p.PhieuDatPhongId))
                    .Select(p => p.PhongId);
                phongs = phongs.Where(s => !phongid.Any(c => c == s.PhongId));

            }
            // nếu tên phòng có thì lọc tên phòng
            if (!string.IsNullOrEmpty(aModel.SearchString))
            {
                phongs = phongs.Where(s => s.TenPhong.Contains(aModel.SearchString));
            }
            // nếu tình trạng có thì lọc thêm một lần
            if (!string.IsNullOrEmpty(aModel.LoaiPhong)) // giả tạo một tí, giả trình trạng phòng là kiểu string.
            {
                int loaiPhongId = _context
                    .LoaiPhong
                    .Where(u => u.TenLoaiPhong == aModel.LoaiPhong)
                    .Select(u => u.LoaiPhongId)
                    .SingleOrDefault();
                phongs = phongs.Where(x => x.LoaiPhongId == loaiPhongId);
            }

            phongs = phongs.Include(p => p.LoaiPhongs);


            // xu li listdatphong cua phieu dat phong
            List<int> lsPhongDat = HttpContext.Session.Get<List<int>>("sslistPhong");
            if(lsPhongDat != null)
            {
            
                foreach (int phongIdItem in lsPhongDat)
                {
                    var phong = _context.Phong.Where(p => p.PhongId == phongIdItem).FirstOrDefault();
                    _phongTinhTrangView.ListPhongDat.Add(phong);
                }
            }


            _phongTinhTrangView.LoaiPhongSelectList = new SelectList(await loaiPhongQuery.Distinct().ToListAsync());
            _phongTinhTrangView.Phongs = await phongs.ToListAsync();

            return View(_phongTinhTrangView);
        }
        //Get datphong
        public async Task<IActionResult> DatPhong(int? id, PhongTinhTrangViewModel aModel)
        {
            if (id == null)
            {
                return NotFound();
            }
            var phong = await _context.Phong
                .Include(p => p.LoaiPhongs)
                .FirstOrDefaultAsync(m => m.PhongId == id);
            if (phong == null)
            {
                return NotFound();
            }
            var phongTinhTrangVm = new PhongTinhTrangViewModel
            {
                //  TinhTrangSelectList = new SelectList(await tinhtrangQuery.Distinct().ToListAsync()),
                // Phongs = await phong.ToListAsync()
            };
            return View(phongTinhTrangVm);
        }
        // post cập nhật đặt phòng
        [HttpPost, ActionName("DatPhong")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DatPhongConfirmed(int id, [Bind("NgayNhanDuTinh,NgayTraDuTinh")] PhieuDatPhong phieuDatPhong)
        {
            // var phong = await _context.Phong.FindAsync(id);
            // phieuDatPhong.TinhTrang = false;
            // _context.PhieuDatPhong.Add(phieuDatPhong);
            //await _context.SaveChangesAsync();

            //int phieuDatPhongIdAdded = phieuDatPhong.PhieuDatPhongId;

            //// tao mot doi tuong la phieu dat phong
            //// them doi tuong do vào bảng phiếu đặt phòng.

            //// tao phieu dat phong
            //// them phong vao phieu dat phong
            //// _
            //await _context.SaveChangesAsync();

            List<int> lsPhongDat = HttpContext.Session.Get<List<int>>("sslistPhong");
            if (lsPhongDat == null)
            {
                lsPhongDat = new List<int>();
            }
            lsPhongDat.Add(id);
            HttpContext.Session.Set("sslistPhong", lsPhongDat);

            return RedirectToAction("Index", "DatPhong", new { area = "Customer" });
        }


    }
}