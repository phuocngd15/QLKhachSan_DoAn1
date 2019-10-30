﻿// <auto-generated />
using System;
using Hotel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hotel.Migrations
{
    [DbContext(typeof(HotelDataContext))]
    [Migration("20191025161526_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hotel.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NgayDangKy")
                        .HasColumnType("datetime2");

                    b.Property<int>("NguoiDungId")
                        .HasColumnType("int");

                    b.Property<string>("PassWords")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Hotel.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NgayNhanThucTe")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTraThucTe")
                        .HasColumnType("datetime2");

                    b.Property<int>("PhieuDatPhongId")
                        .HasColumnType("int");

                    b.Property<decimal>("TienDatCoc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TongTienThanhToan")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BillId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Hotel.Models.ChiTietHoaDon", b =>
                {
                    b.Property<int>("IdBill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<decimal>("GiaTienDichVuDecimal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PhieuDatPhongId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenDichVu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBill");

                    b.HasIndex("BillId");

                    b.ToTable("ChiTietHoaDons");
                });

            modelBuilder.Entity("Hotel.Models.DichVu", b =>
                {
                    b.Property<int>("DichVuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("LoaiDichVuId")
                        .HasColumnType("int");

                    b.Property<string>("TenDichVu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DichVuId");

                    b.HasIndex("LoaiDichVuId");

                    b.ToTable("DichVus");
                });

            modelBuilder.Entity("Hotel.Models.LoaiDichVu", b =>
                {
                    b.Property<int>("LoaiDichVuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoaiDichVu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoaiDichVuId");

                    b.ToTable("LoaiDichVus");
                });

            modelBuilder.Entity("Hotel.Models.LoaiPhong", b =>
                {
                    b.Property<int>("LoaiPhongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MoTaLoaiPhong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoaiPhong")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoaiPhongId");

                    b.ToTable("LoaiPhongs");
                });

            modelBuilder.Entity("Hotel.Models.PhieuDatPhong", b =>
                {
                    b.Property<int>("PhieuDatPhongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhanDuTinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTraDuTinh")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PhieuDatPhongId");

                    b.HasIndex("AccountId");

                    b.ToTable("PhieuDatPhongs");
                });

            modelBuilder.Entity("Hotel.Models.PhieuDatPhong_Phong", b =>
                {
                    b.Property<int>("PhieuDatPhongId")
                        .HasColumnType("int");

                    b.Property<int>("PhongId")
                        .HasColumnType("int");

                    b.HasKey("PhieuDatPhongId", "PhongId");

                    b.HasIndex("PhongId");

                    b.ToTable("PhieuDatPhongPhongs");
                });

            modelBuilder.Entity("Hotel.Models.Phong", b =>
                {
                    b.Property<int>("PhongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CachTinhTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("LoaiPhongId")
                        .HasColumnType("int");

                    b.Property<string>("MoTaPhong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PhuThu")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SoNguoiOToiDa")
                        .HasColumnType("int");

                    b.Property<string>("TenPhong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TinhTrangPhong")
                        .HasColumnType("int");

                    b.HasKey("PhongId");

                    b.HasIndex("LoaiPhongId");

                    b.ToTable("Phongs");
                });

            modelBuilder.Entity("Hotel.Models.User", b =>
                {
                    b.Property<int>("NguoiDungId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("CmndNguoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailNguoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTenNguoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SdtNguoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NguoiDungId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Hotel.Models.ChiTietHoaDon", b =>
                {
                    b.HasOne("Hotel.Models.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillId");
                });

            modelBuilder.Entity("Hotel.Models.DichVu", b =>
                {
                    b.HasOne("Hotel.Models.LoaiDichVu", "LoaiDichVu")
                        .WithMany("DichVus")
                        .HasForeignKey("LoaiDichVuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hotel.Models.PhieuDatPhong", b =>
                {
                    b.HasOne("Hotel.Models.Account", "Account")
                        .WithMany("PhieuDatPhongs")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("Hotel.Models.PhieuDatPhong_Phong", b =>
                {
                    b.HasOne("Hotel.Models.PhieuDatPhong", "PhieuDatPhongs")
                        .WithMany()
                        .HasForeignKey("PhieuDatPhongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.Models.Phong", "Phongs")
                        .WithMany()
                        .HasForeignKey("PhongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hotel.Models.Phong", b =>
                {
                    b.HasOne("Hotel.Models.LoaiPhong", "LoaiPhongs")
                        .WithMany("Phongs")
                        .HasForeignKey("LoaiPhongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
