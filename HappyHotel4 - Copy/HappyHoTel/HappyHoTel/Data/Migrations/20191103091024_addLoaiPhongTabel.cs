using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHoTel.Data.Migrations
{
    public partial class addLoaiPhongTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiPhongs",
                columns: table => new
                {
                    LoaiPhongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenLoaiPhong = table.Column<string>(nullable: true),
                    MoTaLoaiPhong = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhongs", x => x.LoaiPhongId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phongs_LoaiPhongId",
                table: "Phongs",
                column: "LoaiPhongId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phongs_LoaiPhongs_LoaiPhongId",
                table: "Phongs",
                column: "LoaiPhongId",
                principalTable: "LoaiPhongs",
                principalColumn: "LoaiPhongId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phongs_LoaiPhongs_LoaiPhongId",
                table: "Phongs");

            migrationBuilder.DropTable(
                name: "LoaiPhongs");

            migrationBuilder.DropIndex(
                name: "IX_Phongs_LoaiPhongId",
                table: "Phongs");
        }
    }
}
