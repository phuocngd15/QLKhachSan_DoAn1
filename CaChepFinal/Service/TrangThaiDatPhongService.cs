using Microsoft.EntityFrameworkCore;

using CaChepFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace CaChepFinal.Service
{
    public class TrangThaiDatPhongService : ITrangThaiDatPhong
    {
        // model gồm 1 phiếu đặt phòng, một ô tình trạng, một date, một nút tìm kiếm, nút submit
        private readonly ApplicationDbContext _context;

        public TrangThaiDatPhongService(ApplicationDbContext context)
        {
            _context = context;
        }
        IQueryable<TrangThaiDatPhong> GetAll()
        {
            return _context.TrangThaiDatPhong;
        }


        // id có 2 loại, id của phiếu đặt phòng, id của trạng thái. 0: datphong, 1: trạng thái
        TrangThaiDatPhong GetOneById(int? id)
        {
           
                return GetAll().FirstOrDefault(dp => dp.Id == id);
          

        }
        void New(TrangThaiDatPhong a)
        {
            _context.Add(dp);
            _context.SaveChangesAsync();
        }

        void Edit(TrangThaiDatPhong a)
        {
            var model = _context.phongs.First(f => f.Id == dp.Id);
            _context.Entry<TrangThaiDatPhong>(model).State = EntityState.Detached;
            _context.Update(dp);
            _context.SaveChangesAsync();
        }
        void Delete(int id)
        {
            var dp = GetOneById(id);
            if (dp == null)
            {
                throw new ArgumentException();
            }
            _context.Remove(dp);
            _context.SaveChangesAsync();
        }


        public IQueryable<TrangThaiDatPhong> SearchByName(string name)
        {
            return _context.TrangThaiDatPhong
            .Where(d => d.Name.Contains(name));
        }
        public IEquatable<String> TinhTrangName()
        {
         
        }
        public IQueryable<Phong> PriceDecs()
        {
            return _context.phongs.OrderByDescending(c => c.Price);
        }
        public IQueryable<Phong> PriceIncre()
        {
            return _context.phongs.OrderBy(c => c.Price).Include(c => c.GetLoaiPhong);
        }
    }
}