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

namespace CaChepFinal2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DichVusController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _iwebhostenvironment;
        [BindProperty]
        public DichVuViewModel DichVuVM { get; set; }
        public DichVusController(ApplicationDbContext db, IWebHostEnvironment iwebhostenvironment)
        {
            _db = db;
            _iwebhostenvironment = iwebhostenvironment;
            DichVuVM = new DichVuViewModel()
            {
                loaidichvus = _db.loaiDVs.ToList(),
                dichvus = new Data.DichVu()
            };
        }
        public async Task<IActionResult> Index()
        {
            var dichvus = _db.dichVus.Include(m => m.GetLoaiDV);
            return View(await dichvus.ToListAsync());
        }

        public IActionResult Create()
        {
            return View(DichVuVM);
        }
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if (!ModelState.IsValid)
            {
                return View(DichVuVM);
            }

            _db.dichVus.Add(DichVuVM.dichvus);
            await _db.SaveChangesAsync();

            //Image being saved

            string webRootPath = _iwebhostenvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var dichvusFromDb = _db.dichVus.Find(DichVuVM.dichvus.Id);

            if (files.Count != 0)
            {
                //Image has been uploaded
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(files[0].FileName);

                using (var filestream = new FileStream(Path.Combine(uploads, DichVuVM.dichvus.Id + extension), FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }
                dichvusFromDb.ImageUrl = @"\" + SD.ImageFolder + @"\" + DichVuVM.dichvus.Id + extension;
            }
            else
            {
                //when user does not upload image
                var uploads = Path.Combine(webRootPath, SD.ImageFolder + @"\" + SD.DefaultProductImage);
                System.IO.File.Copy(uploads, webRootPath + @"\" + SD.ImageFolder + @"\" + DichVuVM.dichvus.Id + ".png");
                dichvusFromDb.ImageUrl = @"\" + SD.ImageFolder + @"\" + DichVuVM.dichvus.Id + ".png";
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

            DichVuVM.dichvus = await _db.dichVus.Include(m => m.GetLoaiDV).SingleOrDefaultAsync(m => m.Id == id);

            if (DichVuVM.dichvus == null)
            {
                return NotFound();
            }

            return View(DichVuVM);
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

                var dichvusFromDb = _db.dichVus.Where(m => m.Id == DichVuVM.dichvus.Id).FirstOrDefault();

                if (files.Count > 0 && files[0] != null)
                {
                    //if user uploads a new image
                    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                    var extension_new = Path.GetExtension(files[0].FileName);
                    var extension_old = Path.GetExtension(dichvusFromDb.ImageUrl);

                    if (System.IO.File.Exists(Path.Combine(uploads, DichVuVM.dichvus.Id + extension_old)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads, DichVuVM.dichvus.Id + extension_old));
                    }
                    using (var filestream = new FileStream(Path.Combine(uploads, DichVuVM.dichvus.Id + extension_new), FileMode.Create))
                    {
                        files[0].CopyTo(filestream);
                    }
                    DichVuVM.dichvus.ImageUrl = @"\" + SD.ImageFolder + @"\" + DichVuVM.dichvus.Id + extension_new;
                }

                if (DichVuVM.dichvus.ImageUrl != null)
                {
                    dichvusFromDb.ImageUrl = DichVuVM.dichvus.ImageUrl;
                }

                dichvusFromDb.Name = DichVuVM.dichvus.Name;
                dichvusFromDb.Price = DichVuVM.dichvus.Price;
                dichvusFromDb.ShortDescription = DichVuVM.dichvus.ShortDescription;
                dichvusFromDb.LoaiDVId = DichVuVM.dichvus.LoaiDVId;
                dichvusFromDb.InStock = DichVuVM.dichvus.InStock;
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(DichVuVM);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DichVuVM.dichvus = await _db.dichVus.Include(m => m.GetLoaiDV).SingleOrDefaultAsync(m => m.Id == id);

            if (DichVuVM.dichvus == null)
            {
                return NotFound();
            }

            return View(DichVuVM);
        }

        //GET : Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DichVuVM.dichvus = await _db.dichVus.Include(m => m.GetLoaiDV).SingleOrDefaultAsync(m => m.Id == id);

            if (DichVuVM.dichvus == null)
            {
                return NotFound();
            }

            return View(DichVuVM);
        }

        //POST : Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            string webRootPath = _iwebhostenvironment.WebRootPath;
            DichVu dichvus = await _db.dichVus.FindAsync(id);

            if (dichvus == null)
            {
                return NotFound();
            }
            else
            {
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(dichvus.ImageUrl);

                if (System.IO.File.Exists(Path.Combine(uploads, dichvus.Id + extension)))
                {
                    System.IO.File.Delete(Path.Combine(uploads, dichvus.Id + extension));
                }
                _db.dichVus.Remove(dichvus);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
        }

    }
}