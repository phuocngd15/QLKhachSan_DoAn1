using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaChepFinal2.Areas.Admin.Models;
using CaChepFinal2.Data;
using CaChepFinal2.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CaChepFinal2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DatPhongController : Controller
    {
        #region Service

        private readonly IDatPhong _datphongsv;
        private readonly IChiTietDichVuDatPhong _chiTietDichVuDatPhongsv;
        private readonly IChiTietPhongDatPhong _chiTietPhongDatPhongsv;
        private readonly IPhong _phong;
        private readonly ITrangThaiDatPhong _TrangThaiDatPhongsv;
        private readonly ITrangThai _TrangThaisv;
        private readonly IDichVu _dichVusv;

        #endregion

        [BindProperty]
        public DatPhongCartVM _DatPhongCart { get; set; }

        #region contructor

        public DatPhongController(IDatPhong datPhong, IChiTietDichVuDatPhong chiTietDichVuDatPhong, IChiTietPhongDatPhong chiTietPhongDatPhong, ITrangThai trangThai,IPhong phong,IDichVu dichVu)
        {
            _datphongsv = datPhong;
            _chiTietDichVuDatPhongsv = chiTietDichVuDatPhong;
            _chiTietPhongDatPhongsv = chiTietPhongDatPhong;
            _TrangThaisv = trangThai;
            _phong = phong;
            _dichVusv = dichVu;
            _DatPhongCart = new DatPhongCartVM()
            {
                LsPhongDatPhongs =new List<Phong>(),
                LsDichVuDatPhongs =new List<DichVu>(),
            };
            // _mapper = new Mapper();
        }

        #endregion
        
        
        // GET: DatPhong
        public ActionResult Index(DatPhongIndexVM datPhongIndex, string sortOrder)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            // index chua search
            var listdatphong = _datphongsv.GetAll();
            switch (sortOrder)
            {
                case "name_desc":
                    listdatphong = listdatphong.OrderByDescending(s => s.TenNguoiDat);
                    break;
                case "Date":
                    listdatphong = listdatphong.OrderBy(s => s.ThoiGianNhanPhongDuKien);
                    break;
                case "date_desc":
                    listdatphong = listdatphong.OrderByDescending(s => s.ThoiGianNhanPhongDuKien);
                    break;
                default:
                    listdatphong = listdatphong.OrderBy(s => s.TenNguoiDat);
                    break;
            }



            if (datPhongIndex.newDatPhong == null)
            {
                var newdatPhongTongHop = new DatPhongIndexVM
                {
                    datPhongs = listdatphong.Include(i => i.GetTrangThai).ToList(),
                    chiTietDatPhongs = null,
                    ListNameTrangThai = new SelectList(_TrangThaisv.GetlistNameTrangThai().ToList()),
                };
                return View(newdatPhongTongHop);
            }
            // tìm kiếm theo trạng thái
            var datphong = _datphongsv.GetAll();
            if (!string.IsNullOrEmpty(datPhongIndex.CMND))
            {
                datphong = datphong.Where(s => s.CMND.Contains(datPhongIndex.CMND));
            }
            if (!string.IsNullOrEmpty(datPhongIndex.TrangThai)) // giả tạo một tí, giả trình trạng phòng là kiểu string.
            {
                datphong = datphong.Where(u => u.GetTrangThai.Name == datPhongIndex.TrangThai);
            }

            if (datPhongIndex.newDatPhong.ThoiGianNhanPhongDuKien != default)
            {
                datphong = datphong
                    .Where(u => u.ThoiGianNhanPhongDuKien == datPhongIndex.newDatPhong.ThoiGianNhanPhongDuKien.Date)
                    .Include(i => i.GetTrangThai);

            }

            var newdatPhong = new DatPhongIndexVM
            {
                datPhongs = datphong.ToList(),
                chiTietDatPhongs = null,
                ListNameTrangThai = new SelectList(_TrangThaisv.GetlistNameTrangThai().ToList()),
            };
            return View(newdatPhong);

            //   return View(datPhongIndex);
        }

        // GET: DatPhong/Details/5
        // Chức năng details
        public ActionResult DetailsDatPhong(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhongDetails = new DatPhongDetails
            {
                GetDatPhong = _datphongsv.GetOneById(id),
                ChiTietPhongDatPhongs = _chiTietPhongDatPhongsv.GetByIDPhieuDatPhong(id).ToList(),
                ChiTietDichVuDatPhongs = _chiTietDichVuDatPhongsv.GetByIDPhieuDatPhong(id).ToList(),

            };
            if (datPhongDetails.GetDatPhong == null)
            {
                return NotFound();
            }


            //public DatPhong DatPhong { get; set; }

            return View(datPhongDetails);
        }

        // button create dat phòng
        public ActionResult CreateDatPhong()
        {
            
            List<int> lstsPhongCart = HttpContext.Session.Get<List<int>>("ssPhongCart");
            if (lstsPhongCart == null) return View(_DatPhongCart);
            if (lstsPhongCart.Count > 0)
            {
                foreach (int cartItem in lstsPhongCart)
                {
                    Phong listPhongDat = _phong.GetOneById(cartItem);
                    _DatPhongCart.LsPhongDatPhongs.Add(listPhongDat);
                }
            }
            List<int> lstsDichVuCart = HttpContext.Session.Get<List<int>>("ssDichVuCart");
            if (lstsDichVuCart == null ) return View(_DatPhongCart);
            if (lstsDichVuCart.Count > 0)
            {
                foreach (int cartItem in lstsDichVuCart)
                {
                    DichVu oneDichVu = _dichVusv.GetOneById(cartItem);
                    _DatPhongCart.LsDichVuDatPhongs.Add(oneDichVu);
                }
            }
            
            return View(_DatPhongCart);

        }


        // đưa tới form fill thông tin phiếu đặt phòng
        //public IActionResult CreateDatPhongXacNhan()
        //{
        //    ViewData["TrangThaiId"] = new SelectList(_context.trangThais, "Id", "Id");
        //    return View();
        //}

        // POST: Admin/DatPhongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // button create ở page xác nhận phiếu đặt phòng
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> CreateDatPhongXacNhan([Bind("Id,TenNguoiDat,Address,City,CMND,SDT,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,TrangThaiId")] DatPhong datPhong)
        //{
        //    // đọc dữ liệu từ 2 session, và tiến hành ghi phiếu đặt phòng tương ứng
        //    List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssPhongCart");
        //    List<int> lstCartItems = HttpContext.Session.Get<List<int>>("ssPhongCart");
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(datPhong);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["TrangThaiId"] = new SelectList(_context.trangThais, "Id", "Id", datPhong.TrangThaiId);
        //    return View(datPhong);
        //}

        // POST: DatPhong/Create
      
       



        #region Session Phong

        public async  Task<IActionResult> IndexPhong()
        {
            //var listPhong =  _phong.GetAll().Include(m => m.GetLoaiPhong.Name);
            var lsPhongs = _phong.GetAll().Include(p => p.GetLoaiPhong);
            return View(await lsPhongs.ToListAsync());

        } 
        public async Task<IActionResult> DetailsPhong(int id)
        {
            var product = _phong.GetOneById(id);

            return View(product);
        }
        
        [HttpPost, ActionName("DetailsPhong")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DetailsPost(int id)
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssPhongCart");
            if (lstShoppingCart == null)
            {
                lstShoppingCart = new List<int>();
            }
            lstShoppingCart.Add(id);
            HttpContext.Session.Set("ssPhongCart", lstShoppingCart);

            return RedirectToAction("CreateDatPhong", "DatPhong", new { area = "Admin" });

        }
        public IActionResult RemovePhongFromCart(int id)
        {
            List<int> lstCartItems = HttpContext.Session.Get<List<int>>("ssPhongCart");

            if (lstCartItems.Count > 0)
            {
                if (lstCartItems.Contains(id))
                {
                    lstCartItems.Remove(id);
                }
            }

            HttpContext.Session.Set("ssPhongCart", lstCartItems);
            //return RedirectToAction();
            return RedirectToAction("CreateDatPhong", "DatPhong", new { area = "Admin" });
        }

        #endregion

        #region Session DichVu

        public async Task<IActionResult> IndexDichVu()
        {
            var lsDichVus = _dichVusv.GetAll().Include(p => p.GetLoaiDV);
            return View(await lsDichVus.ToListAsync());
        }

        public async Task<IActionResult> DetailsDichVu(int id)
        {
            var dichVu = _dichVusv.GetOneById(id);

            return View(dichVu);
        }

        [HttpPost, ActionName("DetailsDichVu")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DetailsDichVuDetails(int id)
        {
            List<int> lsDichvuCart = HttpContext.Session.Get<List<int>>("ssDichVuCart");
            if (lsDichvuCart == null)
            {
                lsDichvuCart = new List<int>();
            }
            lsDichvuCart.Add(id);
            HttpContext.Session.Set("ssDichVuCart", lsDichvuCart);

            return RedirectToAction("CreateDatPhong", "DatPhong", new { area = "Admin" });
            // return RedirectToAction();

        }
        public IActionResult RemoveDVFromCart(int id)
        {
            List<int> lstCartItems = HttpContext.Session.Get<List<int>>("ssDichVuCart");

            if (lstCartItems.Count > 0)
            {
                if (lstCartItems.Contains(id))
                {
                    lstCartItems.Remove(id);
                }
            }

            HttpContext.Session.Set("ssDichVuCart", lstCartItems);
            // return RedirectToAction();
            return RedirectToAction("CreateDatPhong", "DatPhong", new { area = "Admin" });
        }

        #endregion

    }

}