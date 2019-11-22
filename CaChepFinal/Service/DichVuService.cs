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
    public class DichVuService : IDichVu
    {
        private readonly ApplicationDbContext _context;

        public DichVuService(ApplicationDbContext context)
        {
            _context = context;
        }

		public void DeleteDichVu(int id)
		{
            var dv = GetById(id);
            if(dv == null)
            {
                throw new ArgumentException();
            }
            _context.Remove(dv);
            _context.SaveChanges();
		}

		public void EditDichVu(DichVu dv)
        {
            var model = _context.dichVus.First(f => f.Id == dv.Id);
            _context.Entry<DichVu>(model).State = EntityState.Detached;
            _context.Update(dv);
            _context.SaveChanges();
        }
		public IEnumerable<DichVu> GetAll()
        {
            return _context.dichVus
                .Include(dv => dv.GetLoaiDV );
        }

        public DichVu GetById(int id)
        {
            return GetAll().FirstOrDefault(dv => dv.Id == id);
        }

        public void NewDichVu(DichVu dv)
        {
            _context.Add(dv);
            _context.SaveChanges();
        }
    }
}
