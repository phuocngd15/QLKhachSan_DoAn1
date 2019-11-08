using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HappyHoTel.Data;
using HappyHoTel.Models;
using Microsoft.AspNetCore.Authorization;

namespace HappyHoTel.Areas.Admin.Controllers
{
    [Authorize(Roles = Role.SPAdmin)]
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
            var applicationDbContext = _context.Phongs.Include(p => p.LoaiPhongs);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Phongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.Phongs
                .Include(p => p.LoaiPhongs)
                .FirstOrDefaultAsync(m => m.PhongId == id);
            if (phong == null)
            {
                return NotFound();
            }

            return View(phong);
        }

        // GET: Admin/Phongs/Create
        public IActionResult Create()
        {
            ViewData["LoaiPhongId"] = new SelectList(_context.LoaiPhongs, "LoaiPhongId", "TenLoaiPhong");
            return View();
        }

        // POST: Admin/Phongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhongId,TenPhong,SoNguoiOToiDa,MoTaPhong,CachTinhTien,PhuThu,TinhTrangPhong,LoaiPhongId")] Phong phong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LoaiPhongId"] = new SelectList(_context.LoaiPhongs, "LoaiPhongId", "TenLoaiPhong", phong.LoaiPhongId);
            return View(phong);
        }

        // GET: Admin/Phongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.Phongs.FindAsync(id);
            if (phong == null)
            {
                return NotFound();
            }
            ViewData["LoaiPhongId"] = new SelectList(_context.LoaiPhongs, "LoaiPhongId", "TenLoaiPhong", phong.LoaiPhongId);
            return View(phong);
        }

        // POST: Admin/Phongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhongId,TenPhong,SoNguoiOToiDa,MoTaPhong,CachTinhTien,PhuThu,TinhTrangPhong,LoaiPhongId")] Phong phong)
        {
            if (id != phong.PhongId)
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
                    if (!PhongExists(phong.PhongId))
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
            ViewData["LoaiPhongId"] = new SelectList(_context.LoaiPhongs, "LoaiPhongId", "TenLoaiPhong", phong.LoaiPhongId);
            return View(phong);
        }

        // GET: Admin/Phongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.Phongs
                .Include(p => p.LoaiPhongs)
                .FirstOrDefaultAsync(m => m.PhongId == id);
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
            var phong = await _context.Phongs.FindAsync(id);
            _context.Phongs.Remove(phong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhongExists(int id)
        {
            return _context.Phongs.Any(e => e.PhongId == id);
        }
    }
}
