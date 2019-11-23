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
    public class ChiTietDatPhongService : IQueryBasic<ChiTietDatPhong>
    {
        private readonly ApplicationDbContext _context;

        public ChiTietDatPhongService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void New(ChiTietDatPhong dp)
        {
            _context.Add(dp);
            _context.SaveChanges();
        }
        public  void Delete(int id)
        {
            var dp = GetById(id);
            if (dp == null)
            {
                throw new ArgumentException();
            }
            _context.Remove(dp);
            _context.SaveChanges();
        }

        public void Edit(ChiTietDatPhong dp)
        {
            var model = _context.chiTietDatPhongs.First(f => f.Id == dp.Id);
            _context.Entry<ChiTietDatPhong>(model).State = EntityState.Detached;
            _context.Update(dp);
            _context.SaveChanges();
        }
        public IQueryable<ChiTietDatPhong> GetAll()
        {
            return _context.chiTietDatPhongs;
        }

        public ChiTietDatPhong GetById(int id)
        {
            return GetAll().FirstOrDefault(dp => dp.Id == id);
        }


       

    }
}
