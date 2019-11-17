using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Data.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    BillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayNhanThucTe = table.Column<DateTime>(nullable: false),
                    NgayTraThucTe = table.Column<DateTime>(nullable: false),
                    TienDatCoc = table.Column<decimal>(nullable: false),
                    TongTienThanhToan = table.Column<decimal>(nullable: false),
                    PhieuDatPhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.BillId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bill");
        }
    }
}
