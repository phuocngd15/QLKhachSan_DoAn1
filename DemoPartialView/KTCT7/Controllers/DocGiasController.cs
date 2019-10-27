using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KTCT7.Data;
using KTCT7.Models;

namespace KTCT7.Controllers
{
    public class DocGiasController : Controller
    {
        private readonly MvcKTCT7Context _context;

        public DocGiasController(MvcKTCT7Context context)
        {
            _context = context;
        }

        // GET: DocGias
        //public async Task<IActionResult> Index()
        //{

        //    //    return View(await _context.DocGias.ToListAsync());
        //    return View();
        //}
        public  IActionResult Index()
        {

            //    return View(await _context.DocGias.ToListAsync());
            return View();
        }
        // GET: DocGias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docGia = await _context.DocGias
                .FirstOrDefaultAsync(m => m.MaDocGia == id);
            if (docGia == null)
            {
                return NotFound();
            }

            return View(docGia);
        }

        // GET: DocGias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DocGias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDocGia,HoTen,DiaChi,SoDienThoai")] DocGia docGia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(docGia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(docGia);
        }

        // GET: DocGias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docGia = await _context.DocGias.FindAsync(id);
            if (docGia == null)
            {
                return NotFound();
            }
            return View(docGia);
        }

        // POST: DocGias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaDocGia,HoTen,DiaChi,SoDienThoai")] DocGia docGia)
        {
            if (id != docGia.MaDocGia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(docGia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocGiaExists(docGia.MaDocGia))
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
            return View(docGia);
        }

        // GET: DocGias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docGia = await _context.DocGias
                .FirstOrDefaultAsync(m => m.MaDocGia == id);
            if (docGia == null)
            {
                return NotFound();
            }

            return View(docGia);
        }

        // POST: DocGias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var docGia = await _context.DocGias.FindAsync(id);
            _context.DocGias.Remove(docGia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocGiaExists(int id)
        {
            return _context.DocGias.Any(e => e.MaDocGia == id);
        }
    }
}
