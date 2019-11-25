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
    public class LoaiDvService : ILoaiDv
    {
         private readonly ApplicationDbContext _context;

        public LoaiDvService(ApplicationDbContext context)
        {
            _context = context;
        }

        void ILoaiDv.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void ILoaiDv.Edit(LoaiDV LoaiDv)
        {
            throw new NotImplementedException();
        }

        IQueryable<LoaiDV> ILoaiDv.GetAll()
        {
            throw new NotImplementedException();
        }

        LoaiDV ILoaiDv.GetOneById(int? id)
        {
            throw new NotImplementedException();
        }

        void ILoaiDv.New(LoaiDV LoaiDv)
        {
            throw new NotImplementedException();
        }
    }
}
