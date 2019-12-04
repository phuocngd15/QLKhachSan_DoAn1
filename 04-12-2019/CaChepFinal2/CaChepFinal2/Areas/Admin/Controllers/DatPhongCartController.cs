using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaChepFinal2.Areas.Admin.Models;
using CaChepFinal2.Data;
using CaChepFinal2.Data.DataModel;
using CaChepFinal2.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaChepFinal2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DatPhongCartController : Controller
    {
        private readonly ApplicationDbContext _Context;
        public DatPhongCartVM _DatPhongCart { get; set; }
        public DatPhongCartController(ApplicationDbContext dbContext)
        {
            _Context = dbContext;
            _DatPhongCart = new DatPhongCartVM()
            {
                LsPhongDatPhongs = new List<Phong>(),
                LsDichVuDatPhongs = new List<DichVu>(),
            };
        }
            public IActionResult Index()
        {
            List<int> lstsPhongCart = HttpContext.Session.Get<List<int>>("ssPhongCart");
            if (lstsPhongCart == null) return View(_DatPhongCart);
            if (lstsPhongCart.Count > 0)
            {
                foreach (int cartItem in lstsPhongCart)
                {
                    Phong listPhongDat = _Context.Phongs.Find(cartItem);
                    _DatPhongCart.LsPhongDatPhongs.Add(listPhongDat);
                }
            }
            List<int> lstsDichVuCart = HttpContext.Session.Get<List<int>>("ssDichVuCart");
            if (lstsDichVuCart == null) return View(_DatPhongCart);
            if (lstsDichVuCart.Count > 0)
            {
                foreach (int cartItem in lstsDichVuCart)
                {
                    DichVu oneDichVu = _Context.DichVus.Find(cartItem);
                    _DatPhongCart.LsDichVuDatPhongs.Add(oneDichVu);
                }
            }

            return View(_DatPhongCart);
        }
            public async Task<IActionResult> GetListPhong()
            {
                //var listPhong =  _phong.GetAll().Include(m => m.GetLoaiPhong.Name);
                var lsPhongs = _Context.Phongs.Include(p => p.LoaiPhong);
            return RedirectToAction("Index", "Phongs", new { area = "Admin" });

        }
    }
}