using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Data.Migrations
{
    public partial class addPhongLoaiPhong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiPhong",
                columns: table => new
                {
                    LoaiPhongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiPhong = table.Column<string>(nullable: false),
                    MoTaLoaiPhong = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhong", x => x.LoaiPhongId);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    PhongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhong = table.Column<string>(nullable: true),
                    SoNguoiOToiDa = table.Column<int>(nullable: false),
                    MoTaPhong = table.Column<string>(nullable: true),
                    CachTinhTien = table.Column<decimal>(nullable: false),
                    PhuThu = table.Column<decimal>(nullable: false),
                    TinhTrangPhong = table.Column<string>(nullable: true),
                    LoaiPhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.PhongId);
                    table.ForeignKey(
                        name: "FK_Phong_LoaiPhong_LoaiPhongId",
                        column: x => x.LoaiPhongId,
                        principalTable: "LoaiPhong",
                        principalColumn: "LoaiPhongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phong_LoaiPhongId",
                table: "Phong",
                column: "LoaiPhongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "LoaiPhong");
        }
    }
}
