using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CaChepFinal2.Data;
using CaChepFinal2.Data.DataModel.ViewModel;
using CaChepFinal2.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;

namespace CaChepFinal2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhongsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _iwebhostenvironment;

        [BindProperty]
        public PhongViewModel PhongVM { get; set; }
        public PhongsController(ApplicationDbContext db, IWebHostEnvironment iwebHostEnvironment)
        {
            _db = db;
            _iwebhostenvironment = iwebHostEnvironment;
            PhongVM = new PhongViewModel()
            {
                loaiphongs = _db.loaiPhongs.ToList(),
                phongs = new Data.Phong()
            };
        }
        public async Task<IActionResult> Index()
        {
            var phongs = _db.phongs.Include(m => m.GetLoaiPhong);
            return View(await phongs.ToListAsync());
        }



        public IActionResult Create()
        {
            return View(PhongVM);
        }
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if (!ModelState.IsValid)
            {
                return View(PhongVM);
            }

            _db.phongs.Add(PhongVM.phongs);
            await _db.SaveChangesAsync();

            //Image being saved

            string webRootPath = _iwebhostenvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var phongsFromDb = _db.phongs.Find(PhongVM.phongs.Id);

            if (files.Count != 0)
            {
                //Image has been uploaded
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(files[0].FileName);

                using (var filestream = new FileStream(Path.Combine(uploads, PhongVM.phongs.Id + extension), FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }
                phongsFromDb.ImageUrl = @"\" + SD.ImageFolder + @"\" + PhongVM.phongs.Id + extension;
            }
            else
            {
                //when user does not upload image
                var uploads = Path.Combine(webRootPath, SD.ImageFolder + @"\" + SD.DefaultProductImage);
                System.IO.File.Copy(uploads, webRootPath + @"\" + SD.ImageFolder + @"\" + PhongVM.phongs.Id + ".png");
                phongsFromDb.ImageUrl = @"\" + SD.ImageFolder + @"\" + PhongVM.phongs.Id + ".png";
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

        //GET : Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PhongVM.phongs = await _db.phongs.Include(m => m.GetLoaiPhong).SingleOrDefaultAsync(m => m.Id == id);

            if (PhongVM.phongs == null)
            {
                return NotFound();
            }

            return View(PhongVM);
        }


        //Post : Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _iwebhostenvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                var phongFromDb = _db.phongs.Where(m => m.Id == PhongVM.phongs.Id).FirstOrDefault();

                if (files.Count > 0 && files[0] != null)
                {
                    //if user uploads a new image
                    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                    var extension_new = Path.GetExtension(files[0].FileName);
                    var extension_old = Path.GetExtension(phongFromDb.ImageUrl);

                    if (System.IO.File.Exists(Path.Combine(uploads, PhongVM.phongs.Id + extension_old)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads, PhongVM.phongs.Id + extension_old));
                    }
                    using (var filestream = new FileStream(Path.Combine(uploads, PhongVM.phongs.Id + extension_new), FileMode.Create))
                    {
                        files[0].CopyTo(filestream);
                    }
                    PhongVM.phongs.ImageUrl = @"\" + SD.ImageFolder + @"\" + PhongVM.phongs.Id + extension_new;
                }

                if (PhongVM.phongs.ImageUrl != null)
                {
                    phongFromDb.ImageUrl = PhongVM.phongs.ImageUrl;
                }

                phongFromDb.Name = PhongVM.phongs.Name;
                phongFromDb.Price = PhongVM.phongs.Price;
                phongFromDb.ShortDescription = PhongVM.phongs.ShortDescription;
                phongFromDb.LoaiPhongId = PhongVM.phongs.LoaiPhongId;
                phongFromDb.TrangThai = PhongVM.phongs.TrangThai;
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

            PhongVM.phongs = await _db.phongs.Include(m => m.GetLoaiPhong).SingleOrDefaultAsync(m => m.Id == id);

            if (PhongVM.phongs == null)
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

            PhongVM.phongs = await _db.phongs.Include(m => m.GetLoaiPhong).SingleOrDefaultAsync(m => m.Id == id);

            if (PhongVM.phongs == null)
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
            string webRootPath = _iwebhostenvironment.WebRootPath;
            Phong phongs = await _db.phongs.FindAsync(id);

            if (phongs == null)
            {
                return NotFound();
            }
            else
            {
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(phongs.ImageUrl);

                if (System.IO.File.Exists(Path.Combine(uploads, phongs.Id + extension)))
                {
                    System.IO.File.Delete(Path.Combine(uploads, phongs.Id + extension));
                }
                _db.phongs.Remove(phongs);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
        }

    }
}