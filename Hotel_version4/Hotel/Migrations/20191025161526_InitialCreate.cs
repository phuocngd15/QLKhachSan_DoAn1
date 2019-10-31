using System;
using System.Data;
using Hotel.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Hotel.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    PassWords = table.Column<string>(maxLength: 20, nullable: false),
                    NgayDangKy = table.Column<DateTime>(nullable: false),
                    NguoiDungId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayNhanThucTe = table.Column<DateTime>(nullable: false),
                    NgayTraThucTe = table.Column<DateTime>(nullable: false),
                    TienDatCoc = table.Column<decimal>(nullable: true),
                    TongTienThanhToan = table.Column<decimal>(nullable: true),
                    PhieuDatPhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDichVus",
                columns: table => new
                {
                    LoaiDichVuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiDichVu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDichVus", x => x.LoaiDichVuId);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhongs",
                columns: table => new
                {
                    LoaiPhongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiPhong = table.Column<string>(nullable: true),
                    MoTaLoaiPhong = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhongs", x => x.LoaiPhongId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    NguoiDungId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTenNguoiDung = table.Column<string>(nullable: false),
                    CmndNguoiDung = table.Column<string>(nullable: false),
                    SdtNguoiDung = table.Column<string>(nullable: false),
                    EmailNguoiDung = table.Column<string>(nullable: true),
                    AccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.NguoiDungId);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDatPhongs",
                columns: table => new
                {
                    PhieuDatPhongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TinhTrang = table.Column<bool>(nullable: false),
                    NgayNhanDuTinh = table.Column<DateTime>(nullable: false),
                    NgayTraDuTinh = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false,defaultValue:0),
                    AccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDatPhongs", x => x.PhieuDatPhongId);
                    table.ForeignKey(
                        name: "FK_PhieuDatPhongs_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDons",
                columns: table => new
                {
                    IdBill = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillId = table.Column<int>(nullable: true),
                    TenDichVu = table.Column<string>(nullable: true),
                    SoLuong = table.Column<int>(nullable: false),
                    GiaTienDichVuDecimal = table.Column<decimal>(nullable: false),
                    PhieuDatPhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDons", x => x.IdBill);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDons_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DichVus",
                columns: table => new
                {
                    DichVuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDichVu = table.Column<string>(nullable: false),
                    GiaBan = table.Column<decimal>(nullable: false),
                    GiaNhap = table.Column<decimal>(nullable: false),
                    LoaiDichVuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVus", x => x.DichVuId);
                    table.ForeignKey(
                        name: "FK_DichVus_LoaiDichVus_LoaiDichVuId",
                        column: x => x.LoaiDichVuId,
                        principalTable: "LoaiDichVus",
                        principalColumn: "LoaiDichVuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phongs",
                columns: table => new
                {
                    PhongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhong = table.Column<string>(nullable: false),
                    SoNguoiOToiDa = table.Column<int>(nullable: false),
                    MoTaPhong = table.Column<string>(nullable: true),
                    CachTinhTien = table.Column<decimal>(nullable: true),
                    PhuThu = table.Column<decimal>(nullable: false),
                    TinhTrangPhong = table.Column<int>(nullable: false),
                    LoaiPhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phongs", x => x.PhongId);
                    table.ForeignKey(
                        name: "FK_Phongs_LoaiPhongs_LoaiPhongId",
                        column: x => x.LoaiPhongId,
                        principalTable: "LoaiPhongs",
                        principalColumn: "LoaiPhongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDatPhongPhongs",
                columns: table => new
                {
                    PhongId = table.Column<int>(nullable: false),
                    PhieuDatPhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDatPhongPhongs", x => new { x.PhieuDatPhongId, x.PhongId });
                    table.ForeignKey(
                        name: "FK_PhieuDatPhongPhongs_PhieuDatPhongs_PhieuDatPhongId",
                        column: x => x.PhieuDatPhongId,
                        principalTable: "PhieuDatPhongs",
                        principalColumn: "PhieuDatPhongId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuDatPhongPhongs_Phongs_PhongId",
                        column: x => x.PhongId,
                        principalTable: "Phongs",
                        principalColumn: "PhongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_BillId",
                table: "ChiTietHoaDons",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_DichVus_LoaiDichVuId",
                table: "DichVus",
                column: "LoaiDichVuId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhongPhongs_PhongId",
                table: "PhieuDatPhongPhongs",
                column: "PhongId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhongs_AccountId",
                table: "PhieuDatPhongs",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Phongs_LoaiPhongId",
                table: "Phongs",
                column: "LoaiPhongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDons");

            migrationBuilder.DropTable(
                name: "DichVus");

            migrationBuilder.DropTable(
                name: "PhieuDatPhongPhongs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "LoaiDichVus");

            migrationBuilder.DropTable(
                name: "PhieuDatPhongs");

            migrationBuilder.DropTable(
                name: "Phongs");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "LoaiPhongs");
        }
    }
}
