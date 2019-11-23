﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CaChepFinal.Data;

namespace CaChepFinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         public DbSet<DichVu> dichVus { get; set; }
        public DbSet<LoaiDV> loaiDVs { get; set; }
        
        public DbSet<DichVuCartItem> dichVuCartItems { get; set; }


        public DbSet<Phong> phongs { get; set; }
        public DbSet<LoaiPhong> loaiPhongs { get; set; }
        public DbSet<DatPhong> datPhongs { get; set; }
        public DbSet<ChiTietDatPhong> chiTietDatPhongs { get; set; }
        public DbSet<TrangThaiDatPhong> trangThaiDatPhongs { get; set; }


        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<ChiTietHoaDon> chiTietHoaDons { get; set; }

         public DbSet<TrangThai> trangThais { get; set; }
    }
}
