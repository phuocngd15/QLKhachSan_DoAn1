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
    public class DichVuService : IDichVu
    {
        private readonly ApplicationDbContext _context;

        public DichVuService(ApplicationDbContext context)
        {
            _context = context;
        }

		public void  Delete(int id)
		{
            var dv = GetById(id);
            if(dv == null)
            {
                throw new ArgumentException();
            }
            _context.Remove(dv);
            _context.SaveChangesAsync();
		}

		public  void Edit(DichVu dv)
        {
            var model = _context.dichVus.First(f => f.Id == dv.Id);
            _context.Entry<DichVu>(model).State = EntityState.Detached;
            _context.Update(dv);
            _context.SaveChangesAsync();
        }
		public IQueryable<DichVu> GetAll()
        {
            return _context.dichVus
                .Include(dv => dv.GetLoaiDV );
        }

        public DichVu GetById(int id)
        {
            return GetAll().FirstOrDefault(dv => dv.Id == id);
        }

        public  void New(DichVu dv)
        {
            _context.Add(dv);
            _context.SaveChangesAsync();
        }
         public IQueryable<DichVu> SearchByName(string dv)
        {
            return _context.dichVus.Where(d=>d.Name.Contains(dv));
           
        }
        public IQueryable<DichVu> getLDatPhongByCMND(string CMND)
        {
            return _context.dichVus;
        }
        public IQueryable<DichVu> getLDatPhongBySDT(string SDT)
        {
            return _context.dichVus;
        }
    }
}
