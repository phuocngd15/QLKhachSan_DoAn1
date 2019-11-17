using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Data.Migrations
{
    public partial class addDvVaLdv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiDichVu",
                columns: table => new
                {
                    LoaiDichVuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiDichVu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDichVu", x => x.LoaiDichVuId);
                });

            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    DichVuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDichVu = table.Column<string>(nullable: true),
                    GiaBan = table.Column<decimal>(nullable: false),
                    GiaNhap = table.Column<decimal>(nullable: false),
                    LoaiDichVuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVu", x => x.DichVuId);
                    table.ForeignKey(
                        name: "FK_DichVu_LoaiDichVu_LoaiDichVuId",
                        column: x => x.LoaiDichVuId,
                        principalTable: "LoaiDichVu",
                        principalColumn: "LoaiDichVuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DichVu_LoaiDichVuId",
                table: "DichVu",
                column: "LoaiDichVuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "LoaiDichVu");
        }
    }
}
