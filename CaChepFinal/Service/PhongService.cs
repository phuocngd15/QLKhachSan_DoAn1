using Microsoft.EntityFrameworkCore;
using CaChepFinal.Models.DataModels;
using CaChepFinal.Models.IDataModels;
using CaChepFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CaChepFinal.Service
{
    public class PhongService : IQueryBasic<Phong>,IQueryByName<Phong>
    {
        private readonly ApplicationDbContext _context;

        public PhongService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void New(Phong dp)
        {
            _context.Add(dp);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var dp = GetById(id);
            if (dp == null)
            {
                throw new ArgumentException();
            }
            _context.Remove(dp);
            _context.SaveChanges();
        }

        public void Edit(Phong dp)
        {
            var model = _context.phongs.First(f => f.Id == dp.Id);
            _context.Entry<Phong>(model).State = EntityState.Detached;
            _context.Update(dp);
            _context.SaveChanges();
        }
        public IQueryable<Phong> GetAll()
        {
            return _context.phongs;
        }

        public Phong GetById(int id)
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
