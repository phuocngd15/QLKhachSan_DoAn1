using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaChepFinal2.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaChepFinal2.Data;
using CaChepFinal2.Data.DataModel;

namespace CaChepFinal2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DatPhongsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DatPhongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/DatPhongs
        public async Task<IActionResult> Index(ReservationIndexModel reservation, string sortOrder)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateNhanSortParm"] = sortOrder == "DateNhan" ? "datenhan_desc" : "DateNhan";
            ViewData["DateTraSortParm"] = sortOrder == "DateTra" ? "datetra_desc" : "DateTra";
            ViewData["TongTienSortParm"] = sortOrder == "TongTien" ? "TongTien_desc" : "TongTien";
            // index chua search
            //  var listdatphong = _datphongsv.GetAll();
            var listdatphong = from m in _context.DatPhongs select m;
            switch (sortOrder)
            {
                case "name_desc":
                    listdatphong = listdatphong.OrderByDescending(s => s.TenNguoiDat);
                    break;
                case "DateNhan":
                    listdatphong = listdatphong.OrderBy(s => s.ThoiGianNhanPhongDuKien);
                    break;
                case "datenhan_desc":
                    listdatphong = listdatphong.OrderByDescending(s => s.ThoiGianNhanPhongDuKien);
                    break;
                case "DateTra":
                    listdatphong = listdatphong.OrderBy(s => s.ThoiGianTraPhongDuKien);
                    break;
                case "datetra_desc":
                    listdatphong = listdatphong.OrderByDescending(s => s.ThoiGianTraPhongDuKien);
                    break;
                case "TongTien_desc":
                    listdatphong = listdatphong.OrderByDescending(s => s.TongTien);
                    break;
                case "TongTien":
                    listdatphong = listdatphong.OrderBy(s => s.TongTien);
                    break;
                default:
                    listdatphong = listdatphong.OrderBy(s => s.TenNguoiDat);
                    break;
            }

            // tìm kiếm theo cmnd
            if (!string.IsNullOrEmpty(reservation.CMND))
            {
                listdatphong = listdatphong.Where(s => s.Cmnd.Contains(reservation.CMND));
            }
            // tìm kiếm theo thời gian nhận
            if (reservation.ThoiGianNhan != default)
            {
                listdatphong = from m in listdatphong
                    where 
                          (m.ThoiGianNhanPhongDuKien.Date <= reservation.ThoiGianNhan.Date) &&
                          (reservation.ThoiGianNhan.Date <= m.ThoiGianTraPhongDuKien.Date)
                               select m;
            }


            // tìm kiếm theo ???

            // tạo đối tượng trả về cho view.
            var GetDataforReservation2 = new ReservationIndexModel
            {
                LisDatPhongs = listdatphong.ToList()

            };
            return View(GetDataforReservation2);
        }

        // GET: Admin/DatPhongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhongDetails = new DatPhongDetailsMD
            {
                DatPhong = _context.DatPhongs.Find(id),
                ChiTietDatPhongs = _context.ChiTietDatPhongs.Where(i=>i.DatPhongId==id).Include(i=>i.DatPhong).Include(c=>c.Phong).Include(b=>b.TrangThai).OrderBy(d=>d.ThoiGian.Date).ToList(),
                ChiTietDichVuDatPhongs = _context.ChiTietDichVuDatPhongs.Where(i=>i.DatPhongId==id).Include(i=>i.DichVu).ToList(),

            };
            if (datPhongDetails.DatPhong == null)
            {
                return NotFound();
            }
            //  _dbContext.trangThais.Where(i=>i.Name)

            //public DatPhong DatPhong { get; set; }

            return View(datPhongDetails);
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int id,DatPhongDetailsMD ab)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var listChiTietDatPhongFromDb =  _context.ChiTietDatPhongs
                        .Where(i=>i.DatPhongId==ab.DatPhong.Id && i.PhongId==id
                                  && i.ThoiGian >=DateTime.Today.Date)
                        .ToList();
                    foreach (var i in listChiTietDatPhongFromDb)
                    {
                        if(i.TrangThaiId==1 && i.TrangThai.Id !=3 )
                            i.TrangThaiId = 2;
                        else
                        {
                            i.TrangThaiId = 3;
                        }
                        _context.Update(i);
                        await _context.SaveChangesAsync();
                    }
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatPhongExists(ab.DatPhong.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                if(ab.ChiTietDatPhongs.Any(i=>i.TrangThai.Id==2))
                    return RedirectToAction(nameof(Index));
                else
                {// chạy thẳng qua doccument luôn
                   // return View("HoaDon",obj: hoadon);
                }
            }

            return View(ab);

        }





        // GET: Admin/DatPhongs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/DatPhongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenNguoiDat,Address,Cmnd,Sdt,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,TongTien,AccoutId")] DatPhong datPhong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(datPhong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(datPhong);
        }

        // GET: Admin/DatPhongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhong = await _context.DatPhongs.FindAsync(id);
            if (datPhong == null)
            {
                return NotFound();
            }
            return View(datPhong);
        }

        // POST: Admin/DatPhongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenNguoiDat,Address,Cmnd,Sdt,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,TongTien,AccoutId")] DatPhong datPhong)
        {
            if (id != datPhong.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(datPhong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatPhongExists(datPhong.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(datPhong);
        }

        // GET: Admin/DatPhongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhong = await _context.DatPhongs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datPhong == null)
            {
                return NotFound();
            }

            return View(datPhong);
        }

        // POST: Admin/DatPhongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var datPhong = await _context.DatPhongs.FindAsync(id);
            _context.DatPhongs.Remove(datPhong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatPhongExists(int id)
        {
            return _context.DatPhongs.Any(e => e.Id == id);
        }
    }
}
