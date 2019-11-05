using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHoTel.Data.Migrations
{
    public partial class addPhongTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phongs",
                columns: table => new
                {
                    PhongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenPhong = table.Column<string>(nullable: true),
                    SoNguoiOToiDa = table.Column<int>(nullable: false),
                    MoTaPhong = table.Column<string>(nullable: true),
                    CachTinhTien = table.Column<decimal>(nullable: false),
                    PhuThu = table.Column<decimal>(nullable: false),
                    TinhTrangPhong = table.Column<int>(nullable: false),
                    LoaiPhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phongs", x => x.PhongId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phongs");
        }
    }
}
