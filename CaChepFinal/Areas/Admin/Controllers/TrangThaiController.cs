using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaChepFinal.Data;
using CaChepFinal.Models.DataModels;

namespace CaChepFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TrangThaiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrangThaiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/TrangThai
        public async Task<IActionResult> Index()
        {
            return View(await _context.trangThais.ToListAsync());
        }

        // GET: Admin/TrangThai/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trangThai = await _context.trangThais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trangThai == null)
            {
                return NotFound();
            }

            return View(trangThai);
        }

        // GET: Admin/TrangThai/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/TrangThai/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] TrangThai trangThai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trangThai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trangThai);
        }

        // GET: Admin/TrangThai/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trangThai = await _context.trangThais.FindAsync(id);
            if (trangThai == null)
            {
                return NotFound();
            }
            return View(trangThai);
        }

        // POST: Admin/TrangThai/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] TrangThai trangThai)
        {
            if (id != trangThai.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trangThai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrangThaiExists(trangThai.Id))
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
            return View(trangThai);
        }

        // GET: Admin/TrangThai/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trangThai = await _context.trangThais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trangThai == null)
            {
                return NotFound();
            }

            return View(trangThai);
        }

        // POST: Admin/TrangThai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trangThai = await _context.trangThais.FindAsync(id);
            _context.trangThais.Remove(trangThai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrangThaiExists(int id)
        {
            return _context.trangThais.Any(e => e.Id == id);
        }
    }
}
