using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using Test.Data;
using Test.Models;
using Test.Models.ViewModel;
using Test.Utility;

namespace Test.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhongController : Controller
    {
        private readonly ApplicationDbContext _db;

        private readonly IWebHostEnvironment _iWebHostEnvironment;
        [BindProperty]
        public PhongViewModel PhongVM { get; set; }
        public PhongController(ApplicationDbContext db, IWebHostEnvironment iWebHostEnvironment)
        {
            _db = db;
            _iWebHostEnvironment = iWebHostEnvironment;
            PhongVM = new PhongViewModel()
            {
                LoaiPhongs = _db.LoaiPhong.ToList(),
                Phong = new Models.Phong()
            };
        }

        public async Task<IActionResult> Index()
        {
            var phong = _db.Phong.Include(m => m.LoaiPhongs);
            return View(await phong.ToListAsync());
        }

        //Get create Phong
        public IActionResult Create()
        {
            ViewData["LoaiPhongId"] = new SelectList(_db.Set<LoaiPhong>(), "LoaiPhongId", "TenLoaiPhong");
            return View(PhongVM);
        }

        //Post Create Phong
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if (!ModelState.IsValid)
            {
                return View(PhongVM);
            }
            _db.Phong.Add(PhongVM.Phong);
            await _db.SaveChangesAsync();

            //Image

            string webRootPath = _iWebHostEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var productsFromDb = _db.Phong.Find(PhongVM.Phong.PhongId);

            if (files.Count != 0)
            {
                //Image has been uploaded
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(files[0].FileName);

                using (var filestream = new FileStream(Path.Combine(uploads, PhongVM.Phong.PhongId + extension), FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + PhongVM.Phong.PhongId + extension;
            }
            else
            {
                //when user does not upload image
                var uploads = Path.Combine(webRootPath, SD.ImageFolder + @"\" + SD.DefaultRoomImage);
                System.IO.File.Copy(uploads, webRootPath + @"\" + SD.ImageFolder + @"\" + PhongVM.Phong.PhongId + ".png");
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + PhongVM.Phong.PhongId + ".png";
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PhongVM.Phong = await _db.Phong.Include(m => m.LoaiPhongs).SingleOrDefaultAsync(m => m.PhongId == id);
            ViewData["LoaiPhongId"] = new SelectList(_db.Set<LoaiPhong>(), "LoaiPhongId", "TenLoaiPhong");

            if (PhongVM.Phong == null)
            {
                return NotFound();
            }

            return View(PhongVM);
        }
        //POST Edit action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Phong phong)
        {

            if (ModelState.IsValid)
            {
                string webRootPath = _iWebHostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                var phongFromDb = _db.Phong.Where(m => m.PhongId == PhongVM.Phong.PhongId).FirstOrDefault();

                if (files.Count > 0 && files[0] != null)
                {
                    //if user uploads a new image
                    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                    var extension_new = Path.GetExtension(files[0].FileName);
                    var extension_old = Path.GetExtension(phongFromDb.Image);

                    if (System.IO.File.Exists(Path.Combine(uploads, PhongVM.Phong.PhongId + extension_old)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads, PhongVM.Phong.PhongId + extension_old));
                    }
                    using (var filestream = new FileStream(Path.Combine(uploads, PhongVM.Phong.PhongId + extension_new), FileMode.Create))
                    {
                        files[0].CopyTo(filestream);
                    }
                    PhongVM.Phong.Image = @"\" + SD.ImageFolder + @"\" + PhongVM.Phong.PhongId + extension_new;
                }

                if (PhongVM.Phong.Image != null)
                {
                    phongFromDb.Image = PhongVM.Phong.Image;
                }

                phongFromDb.TenPhong = PhongVM.Phong.TenPhong;
                phongFromDb.SoNguoiOToiDa = PhongVM.Phong.SoNguoiOToiDa;
                phongFromDb.MoTaPhong = PhongVM.Phong.MoTaPhong;
                phongFromDb.CachTinhTien = PhongVM.Phong.CachTinhTien;
                phongFromDb.PhuThu = PhongVM.Phong.PhuThu;
                phongFromDb.TinhTrangPhong = PhongVM.Phong.TinhTrangPhong;
                phongFromDb.LoaiPhongId = PhongVM.Phong.LoaiPhongId;
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(PhongVM);
        }

        //GET : Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PhongVM.Phong = await _db.Phong.Include(m => m.LoaiPhongs).SingleOrDefaultAsync(m => m.PhongId == id);

            if (PhongVM.Phong == null)
            {
                return NotFound();
            }

            return View(PhongVM);
        }

        //GET : Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PhongVM.Phong = await _db.Phong.Include(m => m.LoaiPhongs).SingleOrDefaultAsync(m => m.PhongId == id);

            if (PhongVM.Phong == null)
            {
                return NotFound();
            }

            return View(PhongVM);
        }

        //POST : Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            string webRootPath = _iWebHostEnvironment.WebRootPath;
            Phong phong = await _db.Phong.FindAsync(id);

            if (phong == null)
            {
                return NotFound();
            }
            else
            {
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(phong.Image);

                if (System.IO.File.Exists(Path.Combine(uploads, phong.PhongId + extension)))
                {
                    System.IO.File.Delete(Path.Combine(uploads, phong.PhongId + extension));
                }
                _db.Phong.Remove(phong);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }


        }
    }
}