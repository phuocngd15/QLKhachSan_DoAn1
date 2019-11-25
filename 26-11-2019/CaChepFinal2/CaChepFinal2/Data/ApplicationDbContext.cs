using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CaChepFinal2.Data
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
            modelBuilder.Entity<LoaiDV>().HasData(
                new LoaiDV
                {
                    Id = 1,
                    Name = "Thuc An",
                    Description = "notthing",
                    ImageUrl = null,
                },
                new LoaiDV
                {
                    Id = 2,
                    Name = "Nuoc Uong",
                    Description = "notthing",
                    ImageUrl = null,
                }
            );
            modelBuilder.Entity<DichVu>().HasData(
                new DichVu
                {
                    Id = 1,
                    Name = "NuocTangLuc",
                    LoaiDVId = 1,
                    ShortDescription = null,
                    ImageUrl = null,
                    InStock = 100,
                    Price = 15000,

                },
                new DichVu
                {
                    Id = 2,
                    Name = "NuocSuoi",
                    LoaiDVId = 1,
                    ShortDescription = null,
                    ImageUrl = null,
                    InStock = 100,
                    Price = 15000,

                }
            );
            modelBuilder.Entity<LoaiPhong>().HasData(
                new LoaiPhong
                {
                    Id = 1,
                    Name = "Phong Don",
                    Description = null,
                    ImageUrl = null,


                },
                new LoaiPhong
                {
                    Id = 2,
                    Name = "Phong Doi",
                    Description = null,
                    ImageUrl = null,


                }
            );
            modelBuilder.Entity<Phong>().HasData(
                new Phong
                {
                    Id = 1,
                    Name = "A101",
                    LoaiPhongId = 1,
                    Price = 150000,
                    ShortDescription = null,
                    TrangThai = 1,
                    ImageUrl = null,

                },
                new Phong
                {
                    Id = 2,
                    Name = "A102",
                    LoaiPhongId = 1,
                    Price = 150000,
                    ShortDescription = null,
                    TrangThai = 1,
                    ImageUrl = null
                },
                new Phong
                {
                    Id = 3,
                    Name = "A103",
                    LoaiPhongId = 2,
                    Price = 150000,
                    ShortDescription = null,
                    TrangThai = 1,
                    ImageUrl = null
                },
                new Phong
                {
                    Id = 4,
                    Name = "A104",
                    LoaiPhongId = 2,
                    Price = 170000,
                    ShortDescription = null,
                    TrangThai = 1,
                    ImageUrl = null
                }
            );
            modelBuilder.Entity<TrangThai>().HasData(
                new TrangThai
                {
                    Id = 1,
                    Name = "Chưa Nhận",

                },
                new TrangThai
                {
                    Id = 2,
                    Name = "Đã Nhận",

                },
                new TrangThai
                {
                    Id = 3,
                    Name = "Đã Thanh Toán",
                }

            );
            modelBuilder.Entity<DatPhong>().HasData(
                new DatPhong
                {
                    Id = 1,
                    TenNguoiDat = "Nguyen Phuoc",
                    Address = "149",
                    CMND = "281212914",
                    TrangThaiId = 1,
                    SDT = "0937536545",
                    ThoiGianNhanPhongDuKien = new DateTime(2019,11,22),
                    ThoiGianTraPhongDuKien = new DateTime(2019, 11, 24),

                },
                new DatPhong
                {
                    Id = 2,
                    TenNguoiDat = "Nguyen Truc",
                    Address = "149",
                    CMND = "281212914",
                    TrangThaiId = 1,
                    SDT = "01264079970",
                    ThoiGianNhanPhongDuKien = new DateTime(2019, 11, 23),
                    ThoiGianTraPhongDuKien = new DateTime(2019, 11, 25),

                }
            );
            modelBuilder.Entity<ChiTietPhongDatPhong>().HasData(
                new ChiTietPhongDatPhong
                {
                    Id = 1,
                    DatPhongId = 1,
                    PhongId = 1,
                    GiaTienMotNgay = 150000,
                    TongSoNgay = 3,

                },
                new ChiTietPhongDatPhong
                {
                    Id = 2,
                    DatPhongId = 1,
                    PhongId = 2,
                    GiaTienMotNgay = 150000,
                    TongSoNgay = 2,

                }
            );
            modelBuilder.Entity<ChiTietDichVuDatPhong>().HasData(
                new ChiTietDichVuDatPhong
                {
                    Id = 1,
                    DatPhongId = 1,
                    DichVuId = 1,
                    SoLuong = 2


                },
                new ChiTietDichVuDatPhong
                {
                    Id = 2,
                    DatPhongId = 1,
                    DichVuId = 2,
                    SoLuong = 2


                }
            );
        }
        public DbSet<DichVu> dichVus { get; set; }
        public DbSet<LoaiDV> loaiDVs { get; set; }

        public DbSet<DichVuCartItem> dichVuCartItems { get; set; }


        public DbSet<Phong> phongs { get; set; }
        public DbSet<LoaiPhong> loaiPhongs { get; set; }
        public DbSet<DatPhong> datPhongs { get; set; }
        public DbSet<ChiTietPhongDatPhong> ChiTietPhongDatPhongs { get; set; }


        // public DbSet<TrangThaiDatPhong> trangThaiDatPhongs { get; set; }


        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<ChiTietDichVuDatPhong> ChiTietDichVuDatPhongs { get; set; }

        public DbSet<TrangThai> trangThais { get; set; }
    }
}
