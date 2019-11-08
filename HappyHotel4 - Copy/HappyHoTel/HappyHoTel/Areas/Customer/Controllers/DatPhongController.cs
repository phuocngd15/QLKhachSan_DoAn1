using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HappyHoTel.Data;
using HappyHoTel.Models.ViewModel;

namespace HappyHoTel.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class DatPhongController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DatPhongController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(PhongTinhTrangViewModel aModel)
        {
            // tại là kiểu tình trạng phòng là int, có thể lưu kiểu phòng là string, và kèm theo cái numericDown;
            IQueryable<string> tinhtrangQuery = from m in _context.Phongs
                orderby m.TinhTrangPhong descending 
                select m.TinhTrangPhong;

            var phongs = from m in _context.Phongs
                select m;
            // nếu tên phòng có thì lọc tên phòng
            if (!string.IsNullOrEmpty(aModel.SearchString))
            {
                phongs = phongs.Where(s => s.TenPhong.Contains(aModel.SearchString));
            }
            // nếu tình trạng có thì lọc thêm một lần
            if (!string.IsNullOrEmpty(aModel.TinhTrang)) // giả tạo một tí, giả trình trạng phòng là kiểu string.
            {
                phongs = phongs.Where(x => x.TinhTrangPhong == aModel.TinhTrang);
              // phongs = phongs.FromSql($"EXECUTE dbo.spTimPhongByTinhTrang {aModel.TinhTrang}");
            }

            phongs = phongs.Include(p => p.LoaiPhongs);
            var phongTinhTrangVm = new PhongTinhTrangViewModel
            {
                TinhTrangSelectList = new SelectList(await tinhtrangQuery.Distinct().ToListAsync()),
                Phongs = await phongs.ToListAsync()
            };

            //return View(await movies.ToListAsync());
            //var applicationDbContext = _context.Phongs.Include(p => p.LoaiPhongs);
            return View(phongTinhTrangVm);
        } 
        // GET: Admin/Phongs
        public async Task<IActionResult> TimKiemPhongByName(string searchString)
        {
            var movies = from m in _context.Phongs
                select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.TenPhong.Contains(searchString));
            }
            movies = movies.Include(p => p.LoaiPhongs);
           
            
            return View(await movies.ToListAsync());
        }
        public async Task<IActionResult> DatPhong(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var phong = from m in _context.Phongs
                select m;
            phong = phong.Where(p => p.PhongId == id).Include(p => p.LoaiPhongs);
             //phong = await _context.Phongs
             //   .Include(p => p.LoaiPhongs)
             //   .FirstOrDefaultAsync(m => m.PhongId == id);
            if (phong == null)
            {
                return NotFound();
            }
            var phongTinhTrangVm = new PhongTinhTrangViewModel
            {
              //  TinhTrangSelectList = new SelectList(await tinhtrangQuery.Distinct().ToListAsync()),
                Phongs = await phong.ToListAsync()
            };
            return View(phongTinhTrangVm);
        }

        [HttpPost, ActionName("DatPhong")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DatPhongConfirmed(int id)
        {
            //var phong = await _context.Phongs.FindAsync(id);
            //_context.Phongs.Remove(phong);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}