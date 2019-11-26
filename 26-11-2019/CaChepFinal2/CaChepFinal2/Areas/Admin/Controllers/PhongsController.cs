using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaChepFinal2.Data;

namespace CaChepFinal2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhongsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Phongs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.phongs.Include(p => p.GetLoaiPhong);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Phongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.phongs
                .Include(p => p.GetLoaiPhong)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phong == null)
            {
                return NotFound();
            }

            return View(phong);
        }

        // GET: Admin/Phongs/Create
        public IActionResult Create()
        {
            ViewData["LoaiPhongId"] = new SelectList(_context.loaiPhongs, "Id", "Id");
            return View();
        }

        // POST: Admin/Phongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ShortDescription,Price,ImageUrl,TrangThai,LoaiPhongId")] Phong phong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LoaiPhongId"] = new SelectList(_context.loaiPhongs, "Id", "Id", phong.LoaiPhongId);
            return View(phong);
        }

        // GET: Admin/Phongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.phongs.FindAsync(id);
            if (phong == null)
            {
                return NotFound();
            }
            ViewData["LoaiPhongId"] = new SelectList(_context.loaiPhongs, "Id", "Id", phong.LoaiPhongId);
            return View(phong);
        }

        // POST: Admin/Phongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ShortDescription,Price,ImageUrl,TrangThai,LoaiPhongId")] Phong phong)
        {
            if (id != phong.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhongExists(phong.Id))
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
            ViewData["LoaiPhongId"] = new SelectList(_context.loaiPhongs, "Id", "Id", phong.LoaiPhongId);
            return View(phong);
        }

        // GET: Admin/Phongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.phongs
                .Include(p => p.GetLoaiPhong)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phong == null)
            {
                return NotFound();
            }

            return View(phong);
        }

        // POST: Admin/Phongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phong = await _context.phongs.FindAsync(id);
            _context.phongs.Remove(phong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhongExists(int id)
        {
            return _context.phongs.Any(e => e.Id == id);
        }
    }
}
