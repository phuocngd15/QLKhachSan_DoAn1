using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HappyHoTel.Data;
using HappyHoTel.Models;

namespace HappyHoTel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhieuDatPhong_PhongController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhieuDatPhong_PhongController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/PhieuDatPhong_Phong
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PhieuDatPhongPhongs.Include(p => p.Phongs);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/PhieuDatPhong_Phong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatPhong_Phong = await _context.PhieuDatPhongPhongs
                .Include(p => p.Phongs)
                .FirstOrDefaultAsync(m => m.PhieuDatPhongId == id);
            if (phieuDatPhong_Phong == null)
            {
                return NotFound();
            }

            return View(phieuDatPhong_Phong);
        }

        // GET: Admin/PhieuDatPhong_Phong/Create
        public IActionResult Create()
        {
            ViewData["PhongId"] = new SelectList(_context.Phongs, "PhongId", "PhongId");
            return View();
        }

        // POST: Admin/PhieuDatPhong_Phong/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhongId,PhieuDatPhongId")] PhieuDatPhong_Phong phieuDatPhong_Phong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phieuDatPhong_Phong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PhongId"] = new SelectList(_context.Phongs, "PhongId", "PhongId", phieuDatPhong_Phong.PhongId);
            return View(phieuDatPhong_Phong);
        }

        // GET: Admin/PhieuDatPhong_Phong/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatPhong_Phong = await _context.PhieuDatPhongPhongs.FindAsync(id);
            if (phieuDatPhong_Phong == null)
            {
                return NotFound();
            }
            ViewData["PhongId"] = new SelectList(_context.Phongs, "PhongId", "PhongId", phieuDatPhong_Phong.PhongId);
            return View(phieuDatPhong_Phong);
        }

        // POST: Admin/PhieuDatPhong_Phong/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhongId,PhieuDatPhongId")] PhieuDatPhong_Phong phieuDatPhong_Phong)
        {
            if (id != phieuDatPhong_Phong.PhieuDatPhongId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phieuDatPhong_Phong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhieuDatPhong_PhongExists(phieuDatPhong_Phong.PhieuDatPhongId))
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
            ViewData["PhongId"] = new SelectList(_context.Phongs, "PhongId", "PhongId", phieuDatPhong_Phong.PhongId);
            return View(phieuDatPhong_Phong);
        }

        // GET: Admin/PhieuDatPhong_Phong/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatPhong_Phong = await _context.PhieuDatPhongPhongs
                .Include(p => p.Phongs)
                .FirstOrDefaultAsync(m => m.PhieuDatPhongId == id);
            if (phieuDatPhong_Phong == null)
            {
                return NotFound();
            }

            return View(phieuDatPhong_Phong);
        }

        // POST: Admin/PhieuDatPhong_Phong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phieuDatPhong_Phong = await _context.PhieuDatPhongPhongs.FindAsync(id);
            _context.PhieuDatPhongPhongs.Remove(phieuDatPhong_Phong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhieuDatPhong_PhongExists(int id)
        {
            return _context.PhieuDatPhongPhongs.Any(e => e.PhieuDatPhongId == id);
        }
    }
}
