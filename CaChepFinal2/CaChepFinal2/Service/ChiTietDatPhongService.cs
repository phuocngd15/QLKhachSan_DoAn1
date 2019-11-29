using Microsoft.EntityFrameworkCore;
using CaChepFinal2.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace CaChepFinal2.Service
{
    public class ChiTietDatPhongService : IChiTietDatPhong
    {
        private readonly ApplicationDbContext _context;

        public ChiTietDatPhongService(ApplicationDbContext context)
        {
            _context = context;
        }
        public   void New(ChiTietPhongDatPhong dp)
        {
            _context.Add(dp);
            _context.SaveChangesAsync();
        }
        public  void Delete(int id)
        {
            var dp = GetOneById(id);
            if (dp == null)
            {
                throw new ArgumentException();
            }
            _context.Remove(dp);
            _context.SaveChangesAsync();
        }

        public void Edit(ChiTietPhongDatPhong dp)
        {
            var model = _context.ChiTietPhongDatPhongs.First(f => f.Id == dp.Id);
            _context.Entry<ChiTietPhongDatPhong>(model).State = EntityState.Detached;
            _context.Update(dp);
            _context.SaveChangesAsync();
        }
        public IQueryable<ChiTietPhongDatPhong> GetAll()
        {
            return _context.ChiTietPhongDatPhongs;
        }

        public ChiTietPhongDatPhong GetOneById(int? id)
        {
            return GetAll().FirstOrDefault(dp => dp.Id == id);
        }
        public IQueryable<ChiTietPhongDatPhong> GetByIDPhieuDatPhong(int? id)
        {
            return GetAll().Where(dp => dp.DatPhongId == id);
        }
    }
}
