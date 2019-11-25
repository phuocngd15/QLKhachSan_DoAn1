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
    public class DatPhongService : IDatPhong
    {
        private readonly ApplicationDbContext _context;

        public DatPhongService(ApplicationDbContext context)
        {
            _context = context;
        }
        public  void New(DatPhong dp)
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

        public   void Edit(DatPhong dp)
        {
            var model = _context.datPhongs.First(f => f.Id == dp.Id);
            _context.Entry<DatPhong>(model).State = EntityState.Detached;
            _context.Update(dp);
             _context.SaveChangesAsync();
        }
        public IQueryable<DatPhong> GetAll()
        {
            return _context.datPhongs;
        }

        public DatPhong GetOneById(int? id)
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
        public IQueryable<ChiTietDatPhong> SearchChiTietDatPhongOfPhieuDP(DatPhong datPhong)
        {
            return _context.chiTietDatPhongs
            .Where(d => d.DatPhong == datPhong);
        }
        public IQueryable<ChiTietDatPhong> SearchDatPhongByTinhTrangName(TrangThaiDatPhong tinhtrang)
        {
            

            return _context.datPhongs
            .Where(x => x.tinh == aModel.TinhTrang);
        }
        SelectList TinhTrangNameSelectList()
        {
            IQueryable<string> tinhtrangNameQuery = from m in _context.TrangThaiDatPhong
                                                    orderby m.TinhTrangName descending
                                                    select m.TinhTrangName;
            return tinhtrangNameQuery;       }

    }
}
