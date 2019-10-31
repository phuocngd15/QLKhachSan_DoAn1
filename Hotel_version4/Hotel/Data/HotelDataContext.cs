using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Data
{
    public class HotelDataContext : DbContext
    {
        #region KhaiBaoTabble

        public DbSet<Account> Accounts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Phong> Phongs { get; set; }

        public DbSet<LoaiPhong> LoaiPhongs { get; set; }

        public DbSet<DichVu> DichVus { get; set; }

        public DbSet<LoaiDichVu> LoaiDichVus { get; set; }

        public DbSet<PhieuDatPhong> PhieuDatPhongs { get; set; }

        public DbSet<Bill> Bills { get; set; }

        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public DbSet<PhieuDatPhong_Phong> PhieuDatPhongPhongs { get; set; }

        #endregion

        public HotelDataContext(DbContextOptions<HotelDataContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhieuDatPhong_Phong>()
                .HasKey(c => new {c.PhieuDatPhongId, c.PhongId});
            modelBuilder.Entity<ChiTietHoaDon>().HasNoKey();



        }
        public DbSet<Hotel.Models.SystemAccount> SystemAccount { get; set; }

    }
}
