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
        public  void New(ChiTietHoaDon dp)
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

        public   void Edit(ChiTietHoaDon dp)
        {
            var model = _context.chiTietHoaDons.First(f => f.Id == dp.Id);
            _context.Entry<ChiTietHoaDon>(model).State = EntityState.Detached;
            _context.Update(dp);
             _context.SaveChangesAsync();
        }
        public IQueryable<ChiTietHoaDon> GetAll()
        {
            return _context.chiTietHoaDons;
        }

        public ChiTietHoaDon GetOneById(int? id)
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
