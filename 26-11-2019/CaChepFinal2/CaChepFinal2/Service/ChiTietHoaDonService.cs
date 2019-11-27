using Microsoft.EntityFrameworkCore;

using CaChepFinal2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CaChepFinal2.Service
{
    public class ChiTietHoaDonService : IChiTietHoaDon
    {
        private readonly ApplicationDbContext _context;

        public ChiTietHoaDonService(ApplicationDbContext context)
        {
            _context = context;
        }
        public  void New(ChiTietDichVuDatPhong dp)
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

        public   void Edit(ChiTietDichVuDatPhong dp)
        {
            var model = _context.ChiTietDichVuDatPhongs.First(f => f.Id == dp.Id);
            _context.Entry<ChiTietDichVuDatPhong>(model).State = EntityState.Detached;
            _context.Update(dp);
             _context.SaveChangesAsync();
        }
        public IQueryable<ChiTietDichVuDatPhong> GetAll()
        {
            return _context.ChiTietDichVuDatPhongs;
        }

        public ChiTietDichVuDatPhong GetOneById(int? id)
        {
            return GetAll().FirstOrDefault(dp => dp.Id == id);
        }


        // public IQueryable<ChiTietHoaDon> getLDatPhongByNow()
        // {
        //     return _context.chiTietHoaDons
        //     .Where(d => d..Date == DateTime.Now.Date);
        // }
        
        
    }
}
