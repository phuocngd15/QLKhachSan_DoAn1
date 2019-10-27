﻿// <auto-generated />
using System;
using KTCT7.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KTCT7.Migrations
{
    [DbContext(typeof(MvcKTCT7Context))]
    partial class MvcKTCT7ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KTCT7.Models.DocGia", b =>
                {
                    b.Property<int>("MaDocGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDocGia");

                    b.ToTable("DocGias");
                });

            modelBuilder.Entity("KTCT7.Models.PhieuMuon", b =>
                {
                    b.Property<int>("SoPhieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DocGiasMaDocGia")
                        .HasColumnType("int");

                    b.Property<int>("MaDocGia")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayMuon")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTra")
                        .HasColumnType("datetime2");

                    b.HasKey("SoPhieu");

                    b.HasIndex("DocGiasMaDocGia");

                    b.ToTable("PhieuMuons");
                });

            modelBuilder.Entity("KTCT7.Models.PhieuMuon", b =>
                {
                    b.HasOne("KTCT7.Models.DocGia", "DocGias")
                        .WithMany("PhieuMuons")
                        .HasForeignKey("DocGiasMaDocGia");
                });
#pragma warning restore 612, 618
        }
    }
}
