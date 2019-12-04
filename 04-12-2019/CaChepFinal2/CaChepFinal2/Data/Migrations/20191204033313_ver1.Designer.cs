﻿// <auto-generated />
using System;
using CaChepFinal2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CaChepFinal2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191204033313_ver1")]
    partial class ver1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.ChiTietDatPhong", b =>
                {
                    b.Property<int>("DatPhongId")
                        .HasColumnType("int");

                    b.Property<int>("PhongId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrangThaiId")
                        .HasColumnType("int");

                    b.HasKey("DatPhongId", "PhongId", "ThoiGian");

                    b.HasIndex("PhongId");

                    b.HasIndex("TrangThaiId");

                    b.ToTable("ChiTietDatPhongs");

                    b.HasData(
                        new
                        {
                            DatPhongId = 1,
                            PhongId = 1,
                            ThoiGian = new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 3
                        },
                        new
                        {
                            DatPhongId = 1,
                            PhongId = 2,
                            ThoiGian = new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 3
                        },
                        new
                        {
                            DatPhongId = 1,
                            PhongId = 1,
                            ThoiGian = new DateTime(2019, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 3
                        },
                        new
                        {
                            DatPhongId = 1,
                            PhongId = 2,
                            ThoiGian = new DateTime(2019, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 3
                        },
                        new
                        {
                            DatPhongId = 1,
                            PhongId = 1,
                            ThoiGian = new DateTime(2019, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 3
                        },
                        new
                        {
                            DatPhongId = 1,
                            PhongId = 2,
                            ThoiGian = new DateTime(2019, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 3
                        },
                        new
                        {
                            DatPhongId = 2,
                            PhongId = 3,
                            ThoiGian = new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 2,
                            PhongId = 4,
                            ThoiGian = new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 2,
                            PhongId = 3,
                            ThoiGian = new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 2,
                            PhongId = 4,
                            ThoiGian = new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 2,
                            PhongId = 3,
                            ThoiGian = new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 2,
                            PhongId = 4,
                            ThoiGian = new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 2,
                            PhongId = 3,
                            ThoiGian = new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 2,
                            PhongId = 4,
                            ThoiGian = new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 3,
                            PhongId = 5,
                            ThoiGian = new DateTime(2019, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 3,
                            PhongId = 6,
                            ThoiGian = new DateTime(2019, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 3,
                            PhongId = 5,
                            ThoiGian = new DateTime(2019, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 3,
                            PhongId = 6,
                            ThoiGian = new DateTime(2019, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 3,
                            PhongId = 5,
                            ThoiGian = new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        },
                        new
                        {
                            DatPhongId = 3,
                            PhongId = 6,
                            ThoiGian = new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrangThaiId = 1
                        });
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.ChiTietDichVuDatPhong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DatPhongId")
                        .HasColumnType("int");

                    b.Property<int>("DichVuId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DatPhongId");

                    b.HasIndex("DichVuId");

                    b.ToTable("ChiTietDichVuDatPhongs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatPhongId = 1,
                            DichVuId = 1,
                            SoLuong = 2
                        },
                        new
                        {
                            Id = 2,
                            DatPhongId = 1,
                            DichVuId = 2,
                            SoLuong = 2
                        });
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.ChuongTrinh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsTang")
                        .HasColumnType("bit");

                    b.Property<string>("TenChuongTrinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TiLeThayDoiGia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ChuongTrinhs");
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.DatPhong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("AccoutId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cmnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguoiDat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoiGianNhanPhongDuKien")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianTraPhongDuKien")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TienDatCoc")
                        .HasColumnType("Money");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("Money");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("DatPhongs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "149",
                            Cmnd = "281212911",
                            Sdt = "0937536545",
                            TenNguoiDat = "Nguyen Phuoc",
                            ThoiGianNhanPhongDuKien = new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThoiGianTraPhongDuKien = new DateTime(2019, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TienDatCoc = 50000m,
                            TongTien = 7000000m
                        },
                        new
                        {
                            Id = 2,
                            Address = "149",
                            Cmnd = "281212910",
                            Sdt = "01264079973",
                            TenNguoiDat = "Nguyen Truc",
                            ThoiGianNhanPhongDuKien = new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThoiGianTraPhongDuKien = new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TienDatCoc = 50000m,
                            TongTien = 4000000m
                        },
                        new
                        {
                            Id = 3,
                            Address = "22",
                            Cmnd = "281212915",
                            Sdt = "01626364802",
                            TenNguoiDat = "Phan Tuyen",
                            ThoiGianNhanPhongDuKien = new DateTime(2019, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThoiGianTraPhongDuKien = new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TienDatCoc = 50000m,
                            TongTien = 5000000m
                        });
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.DichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InStock")
                        .HasColumnType("int");

                    b.Property<int>("LoaiDvid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("Money");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LoaiDvid");

                    b.ToTable("DichVus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InStock = 100,
                            LoaiDvid = 1,
                            Name = "NuocTangLuc",
                            Price = 15000m
                        },
                        new
                        {
                            Id = 2,
                            InStock = 100,
                            LoaiDvid = 1,
                            Name = "NuocSuoi",
                            Price = 15000m
                        });
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.HinhPhong", b =>
                {
                    b.Property<int>("HinhId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HinhUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhongId")
                        .HasColumnType("int");

                    b.HasKey("HinhId");

                    b.HasIndex("PhongId");

                    b.ToTable("HinhPhongs");
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.LoaiDichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiDichVus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "notthing",
                            Name = "Thuc An"
                        },
                        new
                        {
                            Id = 2,
                            Description = "notthing",
                            Name = "Nuoc Uong"
                        });
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.LoaiPhong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiPhongs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Phong Don"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Phong Doi"
                        });
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.Phong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChuongTrinhId")
                        .HasColumnType("int");

                    b.Property<int?>("LoaiPhongId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("Money");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChuongTrinhId");

                    b.HasIndex("LoaiPhongId");

                    b.ToTable("Phongs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LoaiPhongId = 1,
                            Name = "A101",
                            Price = 150000m,
                            ShortDescription = "notthing"
                        },
                        new
                        {
                            Id = 2,
                            LoaiPhongId = 1,
                            Name = "A102",
                            Price = 150000m,
                            ShortDescription = "notthing"
                        },
                        new
                        {
                            Id = 3,
                            LoaiPhongId = 2,
                            Name = "A103",
                            Price = 150000m,
                            ShortDescription = "notthing"
                        },
                        new
                        {
                            Id = 4,
                            LoaiPhongId = 2,
                            Name = "A104",
                            Price = 0m,
                            ShortDescription = "notthing"
                        },
                        new
                        {
                            Id = 5,
                            LoaiPhongId = 1,
                            Name = "A105",
                            Price = 150000m,
                            ShortDescription = "notthing"
                        },
                        new
                        {
                            Id = 6,
                            LoaiPhongId = 2,
                            Name = "A106",
                            Price = 150000m,
                            ShortDescription = "notthing"
                        },
                        new
                        {
                            Id = 7,
                            LoaiPhongId = 2,
                            Name = "A107",
                            Price = 150000m,
                            ShortDescription = "notthing"
                        },
                        new
                        {
                            Id = 8,
                            LoaiPhongId = 2,
                            Name = "A108",
                            Price = 150000m,
                            ShortDescription = "notthing"
                        });
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.TrangThai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrangThais");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chưa Nhận"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Đã Nhận"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Đã Thanh Toán"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.Account", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Account");
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.ChiTietDatPhong", b =>
                {
                    b.HasOne("CaChepFinal2.Data.DataModel.DatPhong", "DatPhong")
                        .WithMany("ChiTietDatPhong")
                        .HasForeignKey("DatPhongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaChepFinal2.Data.DataModel.Phong", "Phong")
                        .WithMany("ChiTietDatPhong")
                        .HasForeignKey("PhongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaChepFinal2.Data.DataModel.TrangThai", "TrangThai")
                        .WithMany("ChiTietDatPhong")
                        .HasForeignKey("TrangThaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.ChiTietDichVuDatPhong", b =>
                {
                    b.HasOne("CaChepFinal2.Data.DataModel.DatPhong", "DatPhong")
                        .WithMany("ChiTietDichVuDatPhong")
                        .HasForeignKey("DatPhongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaChepFinal2.Data.DataModel.DichVu", "DichVu")
                        .WithMany("ChiTietDichVuDatPhong")
                        .HasForeignKey("DichVuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.DatPhong", b =>
                {
                    b.HasOne("CaChepFinal2.Data.DataModel.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.DichVu", b =>
                {
                    b.HasOne("CaChepFinal2.Data.DataModel.LoaiDichVu", "LoaiDv")
                        .WithMany("DichVus")
                        .HasForeignKey("LoaiDvid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.HinhPhong", b =>
                {
                    b.HasOne("CaChepFinal2.Data.DataModel.Phong", "Phong")
                        .WithMany("HinhPhong")
                        .HasForeignKey("PhongId")
                        .HasConstraintName("FK_HinhPhong_Phongs")
                        .IsRequired();
                });

            modelBuilder.Entity("CaChepFinal2.Data.DataModel.Phong", b =>
                {
                    b.HasOne("CaChepFinal2.Data.DataModel.ChuongTrinh", "ChuongTrinh")
                        .WithMany("Phongs")
                        .HasForeignKey("ChuongTrinhId")
                        .HasConstraintName("FK_Phongs_ChuongTrinh");

                    b.HasOne("CaChepFinal2.Data.DataModel.LoaiPhong", "LoaiPhong")
                        .WithMany("Phongs")
                        .HasForeignKey("LoaiPhongId")
                        .HasConstraintName("FK_Phongs_LoaiPhongs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
