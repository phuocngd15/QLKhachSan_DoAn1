using System;
using System.Collections.Generic;
using System.Text;
using HappyHoTel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HappyHoTel.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PhieuDatPhong_Phong>()
                .HasKey(c => new { c.PhieuDatPhongId, c.PhongId });
            //modelBuilder.Entity<ChiTietHoaDon>().HasNoKey();



        }

        public DbSet<Phong> Phongs { get; set; }
        public DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<LoaiDichVu> LoaiDichVu { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<PhieuDatPhong> PhieuDatPhongs { get; set; }
        public DbSet<PhieuDatPhong_Phong> PhieuDatPhongPhongs { get; set; }
    }
}
