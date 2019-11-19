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
using Test.Models;
using Test.Models.ViewModel;


namespace Test.Controllers
{
    [Area("Customer")]
    public class DatPhongController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DatPhongController(ApplicationDbContext context)
        {
            _context = context;
        }
        // tim kiếm
        public async Task<IActionResult> Index(PhongTinhTrangViewModel aModel, [Bind("NgayNhanDuTinh,NgayTraDuTinh")] PhieuDatPhong phieuDatPhong)
        {
            //
            // tại là kiểu tình trạng phòng là int, có thể lưu kiểu phòng là string, và kèm theo cái numericDown;
            IQueryable<string> loaiPhongQuery = from m in _context.LoaiPhong
                                                orderby m.TenLoaiPhong descending
                                                select m.TenLoaiPhong;
            //var commentsOfMembers = _context.PhieuDatPhongPhong.w
            //    .SelectMany(m => m.PhongPhieuDatPhongs.Select(mc => mc.ph))
            //    .ToList();


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
                                       (a <= m.NgayNhanDuTinh && m.NgayTraDuTinh <=b ) &&
                                       (m.TinhTrang ==false) // tim phong ma phieu dat phong con cho`.
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
                // phongs = phongs.FromSql($"EXECUTE dbo.spTimPhongByTinhTrang {aModel.TinhTrang}");
            }

            // phongs = phongs.Include(p => p.LoaiPhongs);
            var phongTinhTrangVm = new PhongTinhTrangViewModel
            {
                LoaiPhongSelectList = new SelectList(await loaiPhongQuery.Distinct().ToListAsync()),
                Phongs = await phongs.ToListAsync()
            };

            return View(phongTinhTrangVm);
        }
        //Get datphong
        public async Task<IActionResult> DatPhong(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var phong = from m in _context.Phong
                        select m;
            phong = phong.Where(p => p.PhongId == id).Include(p => p.LoaiPhongs);
            //phong = await _context.Phongs
            //   .Include(p => p.LoaiPhongs)
            //   .FirstOrDefaultAsync(m => m.PhongId == id);
            if (phong == null)
            {
                return NotFound();
            }
            var phongTinhTrangVm = new PhongTinhTrangViewModel
            {
                //  TinhTrangSelectList = new SelectList(await tinhtrangQuery.Distinct().ToListAsync()),
                Phongs = await phong.ToListAsync()
            };
            return View(phongTinhTrangVm);
        }
        // post cập nhật đặt phòng
        [HttpPost, ActionName("DatPhong")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DatPhongConfirmed(int id)
        {
            //var phong = await _context.Phongs.FindAsync(id);
            //_context.Phongs.Remove(phong);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}