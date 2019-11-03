using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHotel.Data.Migrations
{
    public partial class Account : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SystemAccount",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 20, nullable: true),
                    PassWords = table.Column<string>(maxLength: 20, nullable: true),
                    NgayDangKy = table.Column<DateTime>(nullable: false),
                    HoTenNguoiDung = table.Column<string>(nullable: true),
                    CmndNguoiDung = table.Column<string>(nullable: true),
                    SdtNguoiDung = table.Column<string>(nullable: true),
                    EmailNguoiDung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemAccount", x => x.AccountId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemAccount");
        }
    }
}
