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
        private readonly IDatPhong _datphongsv;
        private readonly IChiTietDichVuDatPhong _chiTietDichVuDatPhongsv;
        private readonly IChiTietPhongDatPhong _chiTietPhongDatPhongsv;
        private readonly IPhong _phong;
        private readonly ITrangThaiDatPhong _TrangThaiDatPhongsv;
        private readonly ITrangThai _TrangThaisv;
        private readonly IDichVu _dichVusv;

        [BindProperty]
        public DatPhongCartVM _DatPhongCart { get; set; }

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
        // GET: DatPhong
        public ActionResult Index(DatPhongIndexVM datPhongIndex)
        {
            // index chua search
            if (datPhongIndex.newDatPhong == null)
            {
                var newdatPhongTongHop = new DatPhongIndexVM
                {
                    datPhongs = _datphongsv.GetAll().Include(i => i.GetTrangThai).ToList(),
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
        // online view
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

        // POST: DatPhong/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDatPhong([Bind("Id,TenNguoiDat,Address,City,CMND,SDT,TienDatCoc,ThoiGianNhanPhongDuKien,ThoiGianTraPhongDuKien,UserId")] DatPhong datPhong)
        {
            var newdatPhongTongHop = new DatPhongDetails
            {
                GetDatPhong = datPhong,
                ChiTietDichVuDatPhongs = null,
                ChiTietPhongDatPhongs = null,
            };

            try
            {
                if (ModelState.IsValid)
                {
                    _datphongsv.New(datPhong);
                   // await _context.SaveChangesAsync();
                   
                }
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View(newdatPhongTongHop);
            }

          //  return View();
        }

        // từ addPhong -> DetailsPhong -> Addto Bag
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

            //return RedirectToAction("CreateDatPhong", "DatPhong", new { area = "Admin" });
            return RedirectToAction();

        }

    }

}