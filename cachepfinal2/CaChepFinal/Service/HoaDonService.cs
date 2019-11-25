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
    public class HoaDonService : IHoaDon
    {
         private readonly ApplicationDbContext _context;

        public HoaDonService(ApplicationDbContext context)
        {
            _context = context;
        }

        void IHoaDon.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void IHoaDon.Edit(HoaDon DatPhong)
        {
            throw new NotImplementedException();
        }

        IQueryable<HoaDon> IHoaDon.GetAll()
        {
            throw new NotImplementedException();
        }

        HoaDon IHoaDon.GetOneById(int? id)
        {
            throw new NotImplementedException();
        }

        void IHoaDon.New(HoaDon DatPhong)
        {
            throw new NotImplementedException();
        }
    }
}