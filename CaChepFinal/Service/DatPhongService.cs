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
    public class DatPhongService : IQueryBasic<DatPhong>
    {
        private readonly ApplicationDbContext _context;

        public DatPhongService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void New(DatPhong dp)
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

        public void Edit(DatPhong dp)
        {
            var model = _context.datPhongs.First(f => f.Id == dp.Id);
            _context.Entry<DatPhong>(model).State = EntityState.Detached;
            _context.Update(dp);
            _context.SaveChanges();
        }
        public IQueryable<DatPhong> GetAll()
        {
            return _context.datPhongs;
        }

        public DatPhong GetById(int id)
        {
            return GetAll().FirstOrDefault(dp => dp.Id == id);
        }


        public IQueryable<DatPhong> getLDatPhongByNow()
        {
            return _context.datPhongs
            .Where(d => d.ThoiGianNhanPhongDuKien.Date == DateTime.Now.Date);
        }
        public IQueryable<DatPhong> getLDatPhongByCMND(string CMND)
        {
            return _context.datPhongs.Where(d => d.TenNguoiDat.Contains(CMND));
        }
        public IQueryable<DatPhong> getLDatPhongBySDT(string SDT)
        {
            return _context.datPhongs.Where(d => d.SDT.Contains(SDT));
        }

    }
}
