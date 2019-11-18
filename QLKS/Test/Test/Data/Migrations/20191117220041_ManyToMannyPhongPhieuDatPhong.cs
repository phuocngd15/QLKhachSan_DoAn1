using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Data.Migrations
{
    public partial class ManyToMannyPhongPhieuDatPhong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhieuDatPhong_Phong");

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuDatPhongs",
                columns: table => new
                {
                    PhongId = table.Column<int>(nullable: false),
                    PhieuDatPhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuDatPhongs", x => new { x.PhongId, x.PhieuDatPhongId });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuDatPhongs_PhieuDatPhong_PhieuDatPhongId",
                        column: x => x.PhieuDatPhongId,
                        principalTable: "PhieuDatPhong",
                        principalColumn: "PhieuDatPhongId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuDatPhongs_Phong_PhongId",
                        column: x => x.PhongId,
                        principalTable: "Phong",
                        principalColumn: "PhongId",
                        onDelete: ReferentialAction.Cascade);
                });
           
         
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuDatPhongs");

            migrationBuilder.CreateTable(
                name: "PhieuDatPhong_Phong",
                columns: table => new
                {
                    PhongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhieuDatPhongId = table.Column<int>(type: "int", nullable: false),
                    PhongsPhongId = table.Column<int>(type: "int", nullable: true)
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
                name: "IX_PhieuDatPhong_Phong_PhieuDatPhongId",
                table: "PhieuDatPhong_Phong",
                column: "PhieuDatPhongId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhong_Phong_PhongsPhongId",
                table: "PhieuDatPhong_Phong",
                column: "PhongsPhongId");
        }
    }
}
