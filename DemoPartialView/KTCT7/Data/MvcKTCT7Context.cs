using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTCT7.Models;

namespace KTCT7.Data
{
    public class MvcKTCT7Context:DbContext
    {
        public MvcKTCT7Context()
        {

        }
        public MvcKTCT7Context(DbContextOptions<MvcKTCT7Context> options)
             : base(options)
        {
        }


        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<PhieuMuon> PhieuMuons { get; set; }

    }
}
