using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Data.Migrations
{
    public partial class addData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 20, nullable: true),
                    PassWords = table.Column<string>(maxLength: 20, nullable: true),
                    NgayDangKy = table.Column<DateTime>(nullable: false),
                    NguoiDungId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    IdBill = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillId = table.Column<int>(nullable: true),
                    TenDichVu = table.Column<string>(nullable: true),
                    SoLuong = table.Column<int>(nullable: false),
                    GiaTienDichVu = table.Column<decimal>(nullable: false),
                    PhieuDatPhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.IdBill);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_Bill_BillId",
                        column: x => x.BillId,
                        principalTable: "Bill",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDatPhong",
                columns: table => new
                {
                    PhieuDatPhongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TinhTrang = table.Column<bool>(nullable: false),
                    NgayNhanDuTinh = table.Column<DateTime>(nullable: false),
                    NgayTraDuTinh = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    AccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDatPhong", x => x.PhieuDatPhongId);
                    table.ForeignKey(
                        name: "FK_PhieuDatPhong_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    NguoiDungId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTenNguoiDung = table.Column<string>(nullable: true),
                    CmndNguoiDung = table.Column<string>(nullable: true),
                    SdtNguoiDung = table.Column<string>(nullable: true),
                    EmailNguoiDung = table.Column<string>(nullable: true),
                    AccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.NguoiDungId);
                    table.ForeignKey(
                        name: "FK_User_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDatPhong_Phong",
                columns: table => new
                {
                    PhongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhongsPhongId = table.Column<int>(nullable: true),
                    PhieuDatPhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDatPhong_Phong", x => x.PhongId);
                    table.ForeignKey(
                        name: "FK_PhieuDatPhong_Phong_PhieuDatPhong_PhieuDatPhongId",
                        column: x => x.PhieuDatPhongId,
                        principalTable: "PhieuDatPhong",
                        principalColumn: "PhieuDatPhongId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuDatPhong_Phong_Phong_PhongsPhongId",
                        column: x => x.PhongsPhongId,
                        principalTable: "Phong",
                        principalColumn: "PhongId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_BillId",
                table: "ChiTietHoaDon",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhong_AccountId",
                table: "PhieuDatPhong",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhong_Phong_PhieuDatPhongId",
                table: "PhieuDatPhong_Phong",
                column: "PhieuDatPhongId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhong_Phong_PhongsPhongId",
                table: "PhieuDatPhong_Phong",
                column: "PhongsPhongId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AccountId",
                table: "User",
                column: "AccountId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "PhieuDatPhong_Phong");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "PhieuDatPhong");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
