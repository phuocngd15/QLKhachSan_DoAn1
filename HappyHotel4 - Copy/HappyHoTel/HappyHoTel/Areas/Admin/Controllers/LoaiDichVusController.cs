using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HappyHoTel.Data;
using HappyHoTel.Models;
using Microsoft.AspNetCore.Authorization;

namespace HappyHoTel.Areas.Admin.Controllers
{
    [Authorize(Roles = Role.SPAdmin)]
    [Area("Admin")]
    public class LoaiDichVusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoaiDichVusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/LoaiDichVus
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiDichVu.ToListAsync());
        }

        // GET: Admin/LoaiDichVus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiDichVu = await _context.LoaiDichVu
                .FirstOrDefaultAsync(m => m.LoaiDichVuId == id);
            if (loaiDichVu == null)
            {
                return NotFound();
            }

            return View(loaiDichVu);
        }

        // GET: Admin/LoaiDichVus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiDichVus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoaiDichVuId,TenLoaiDichVu")] LoaiDichVu loaiDichVu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiDichVu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiDichVu);
        }

        // GET: Admin/LoaiDichVus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiDichVu = await _context.LoaiDichVu.FindAsync(id);
            if (loaiDichVu == null)
            {
                return NotFound();
            }
            return View(loaiDichVu);
        }

        // POST: Admin/LoaiDichVus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoaiDichVuId,TenLoaiDichVu")] LoaiDichVu loaiDichVu)
        {
            if (id != loaiDichVu.LoaiDichVuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiDichVu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiDichVuExists(loaiDichVu.LoaiDichVuId))
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
            return View(loaiDichVu);
        }

        // GET: Admin/LoaiDichVus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiDichVu = await _context.LoaiDichVu
                .FirstOrDefaultAsync(m => m.LoaiDichVuId == id);
            if (loaiDichVu == null)
            {
                return NotFound();
            }

            return View(loaiDichVu);
        }

        // POST: Admin/LoaiDichVus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiDichVu = await _context.LoaiDichVu.FindAsync(id);
            _context.LoaiDichVu.Remove(loaiDichVu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiDichVuExists(int id)
        {
            return _context.LoaiDichVu.Any(e => e.LoaiDichVuId == id);
        }
    }
}
