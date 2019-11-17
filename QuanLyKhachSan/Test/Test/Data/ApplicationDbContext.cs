using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<LoaiPhong> LoaiPhong { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<LoaiDichVu> LoaiDichVu { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<PhieuDatPhong> PhieuDatPhong { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<PhieuDatPhong_Phong> PhieuDatPhong_Phong { get; set; }
        public DbSet<User> User { get; set; }

    }
}
