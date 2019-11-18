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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PhongPhieuDatPhong>()
                .HasKey(bc => new { bc.PhongId, bc.PhieuDatPhongId });
            modelBuilder.Entity<PhongPhieuDatPhong>()
                .HasOne(bc => bc.phong)
                .WithMany(b => b.PhongPhieuDatPhongs)
                .HasForeignKey(bc => bc.PhongId);
            modelBuilder.Entity<PhongPhieuDatPhong>()
                .HasOne(bc => bc.phieuDatPhong)
                .WithMany(c => c.PhongPhieuDatPhongs)
                .HasForeignKey(bc => bc.PhieuDatPhongId);
        }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<LoaiPhong> LoaiPhong { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<LoaiDichVu> LoaiDichVu { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<PhieuDatPhong> PhieuDatPhong { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<User> User { get; set; }
        public  DbSet<PhongPhieuDatPhong> ChiTietPhieuDatPhongs { get; set; }

    }
}
