using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHoTel.Data.Migrations
{
    public partial class thaydoiColumTinhTrangPhong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TinhTrangPhong",
                table: "Phongs",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TinhTrangPhong",
                table: "Phongs",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
