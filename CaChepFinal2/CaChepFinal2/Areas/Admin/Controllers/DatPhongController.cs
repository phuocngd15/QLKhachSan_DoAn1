using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaChepFinal2.Areas.Admin.Models;
using CaChepFinal2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaChepFinal2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DatPhongController : Controller
    {
        private readonly IDatPhong _datphongsv;
        private readonly IChiTietDatPhong _chitietDatPhongsv;
        private readonly ITrangThaiDatPhong _TrangThaiDatPhongsv;
        private readonly ITrangThai _TrangThaisv;

        public DatPhongController(IDatPhong datPhong, IChiTietDatPhong chiTietDatPhong)
        {
            _datphongsv = datPhong;
            _chitietDatPhongsv = chiTietDatPhong;
           // _mapper = new Mapper();
        }
        // GET: DatPhong
        public ActionResult Index(DatPhongIndexVM datPhongIndex)
        {
            if (datPhongIndex.chiTietDatPhongs == null && datPhongIndex.datPhongs == null)
            {
                var newdatPhongTongHop = new DatPhongIndexVM
                {
                    datPhongs = _datphongsv.GetAll().OrderByDescending(c => c.ThoiGianNhanPhongDuKien).ToList(),
                    chiTietDatPhongs = null

                };
                return View(newdatPhongTongHop);
            }

            return View(datPhongIndex);
        }

        // GET: DatPhong/Details/5
        public ActionResult Details(int id)
        {
            return View();
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