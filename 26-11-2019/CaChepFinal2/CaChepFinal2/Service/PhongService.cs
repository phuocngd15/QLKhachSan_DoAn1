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
    public class PhongService : IPhong
    {
        private readonly ApplicationDbContext _context;

        public PhongService(ApplicationDbContext context)
        {
            _context = context;
        }
        public  void New(Phong dp)
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

        public  void Edit(Phong dp)
        {
            var model = _context.phongs.First(f => f.Id == dp.Id);
            _context.Entry<Phong>(model).State = EntityState.Detached;
            _context.Update(dp);
             _context.SaveChangesAsync();
        }
        public IQueryable<Phong> GetAll()
        {
            return _context.phongs;
        }

        public Phong GetOneById(int? id)
        {
            return GetAll().FirstOrDefault(dp => dp.Id == id);
        }


        public IQueryable<Phong> SearchByName(string name)
        {
            return _context.phongs
            .Where(d => d.Name.Contains(name));
        }
         public IQueryable<Phong> PriceDecs()
        {
            return _context.phongs.OrderByDescending(c=>c.Price);
        }
        public IQueryable<Phong> PriceIncre()
        {
            return _context.phongs.OrderBy(c=>c.Price).Include(c=>c.GetLoaiPhong);
        }

    }
}
