using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHoTel.Data.Migrations
{
    public partial class addPhieuDatPhong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhieuDatPhongs",
                columns: table => new
                {
                    PhieuDatPhongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TinhTrang = table.Column<bool>(nullable: false),
                    NgayNhanDuTinh = table.Column<DateTime>(nullable: false),
                    NgayTraDuTinh = table.Column<DateTime>(nullable: false),
                    AccountId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDatPhongs", x => x.PhieuDatPhongId);
                    table.ForeignKey(
                        name: "FK_PhieuDatPhongs_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDatPhongPhongs",
                columns: table => new
                {
                    PhongId = table.Column<int>(nullable: false),
                    PhieuDatPhongId = table.Column<int>(nullable: false),
                    PhieuDatPhongsPhieuDatPhongId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDatPhongPhongs", x => new { x.PhieuDatPhongId, x.PhongId });
                    table.ForeignKey(
                        name: "FK_PhieuDatPhongPhongs_PhieuDatPhongs_PhieuDatPhongsPhieuDatPhongId",
                        column: x => x.PhieuDatPhongsPhieuDatPhongId,
                        principalTable: "PhieuDatPhongs",
                        principalColumn: "PhieuDatPhongId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuDatPhongPhongs_Phongs_PhongId",
                        column: x => x.PhongId,
                        principalTable: "Phongs",
                        principalColumn: "PhongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhongPhongs_PhieuDatPhongsPhieuDatPhongId",
                table: "PhieuDatPhongPhongs",
                column: "PhieuDatPhongsPhieuDatPhongId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhongPhongs_PhongId",
                table: "PhieuDatPhongPhongs",
                column: "PhongId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhongs_AccountId",
                table: "PhieuDatPhongs",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhieuDatPhongPhongs");

            migrationBuilder.DropTable(
                name: "PhieuDatPhongs");
        }
    }
}
