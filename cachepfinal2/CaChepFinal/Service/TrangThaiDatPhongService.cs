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
    {        private readonly ApplicationDbContext _context;

        public TrangThaiDatPhongService(ApplicationDbContext context)
        {
            _context = context;
        }

        void ITrangThaiDatPhong.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void ITrangThaiDatPhong.Edit(TrangThaiDatPhong a)
        {
            throw new NotImplementedException();
        }

        IQueryable<TrangThaiDatPhong> ITrangThaiDatPhong.GetAll()
        {
            throw new NotImplementedException();
        }

        TrangThaiDatPhong ITrangThaiDatPhong.GetOneById(int? id)
        {
            throw new NotImplementedException();
        }

        void ITrangThaiDatPhong.New(TrangThaiDatPhong a)
        {
            throw new NotImplementedException();
        }
    }
}
