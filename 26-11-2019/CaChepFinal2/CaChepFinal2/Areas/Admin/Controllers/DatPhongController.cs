using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaChepFinal2.Areas.Admin.Models;
using CaChepFinal2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CaChepFinal2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DatPhongController : Controller
    {
        private readonly IDatPhong _datphongsv;
        private readonly IChiTietDichVuDatPhong _chiTietDichVuDatPhongsv;
        private readonly IChiTietPhongDatPhong _chiTietPhongDatPhongsv;

        private readonly ITrangThaiDatPhong _TrangThaiDatPhongsv;
        private readonly ITrangThai _TrangThaisv;

        public DatPhongController(IDatPhong datPhong, IChiTietDichVuDatPhong chiTietDichVuDatPhong, IChiTietPhongDatPhong chiTietPhongDatPhong,ITrangThai trangThai)
        {
            _datphongsv = datPhong;
            _chiTietDichVuDatPhongsv = chiTietDichVuDatPhong;
            _chiTietPhongDatPhongsv = chiTietPhongDatPhong;
            _TrangThaisv = trangThai;
            // _mapper = new Mapper();
        }
        // GET: DatPhong
        public ActionResult Index(DatPhongIndexVM datPhongIndex)
        {
            // index chua search
            if (datPhongIndex.datPhongs == null)
            {
                var newdatPhongTongHop = new DatPhongIndexVM
                {
                    datPhongs = _datphongsv.GetAll().OrderByDescending(c => c.ThoiGianNhanPhongDuKien).ToList(),
                    chiTietDatPhongs = null,
                    ListNameTrangThai =new SelectList(_TrangThaisv.GetlistNameTrangThai().ToList()),
                };
                return View(newdatPhongTongHop);
            }

            return View(datPhongIndex);
        }

        // GET: DatPhong/Details/5

        // online view
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            

            var datPhongDetails = new DatPhongDetails
            {
                GetDatPhong= _datphongsv.GetOneById(id),
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



        // GET: DatPhong/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatPhong/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DatPhong/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DatPhong/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DatPhong/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DatPhong/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }

}