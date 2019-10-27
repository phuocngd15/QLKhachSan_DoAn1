using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTCT7.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocGias",
                columns: table => new
                {
                    MaDocGia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGias", x => x.MaDocGia);
                });

            migrationBuilder.CreateTable(
                name: "PhieuMuons",
                columns: table => new
                {
                    SoPhieu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayMuon = table.Column<DateTime>(nullable: false),
                    NgayTra = table.Column<DateTime>(nullable: false),
                    MaDocGia = table.Column<int>(nullable: false),
                    DocGiasMaDocGia = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuons", x => x.SoPhieu);
                    table.ForeignKey(
                        name: "FK_PhieuMuons_DocGias_DocGiasMaDocGia",
                        column: x => x.DocGiasMaDocGia,
                        principalTable: "DocGias",
                        principalColumn: "MaDocGia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuons_DocGiasMaDocGia",
                table: "PhieuMuons",
                column: "DocGiasMaDocGia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhieuMuons");

            migrationBuilder.DropTable(
                name: "DocGias");
        }
    }
}
