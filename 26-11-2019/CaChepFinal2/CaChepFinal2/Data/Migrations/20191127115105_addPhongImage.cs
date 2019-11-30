using Microsoft.EntityFrameworkCore.Migrations;

namespace CaChepFinal2.Data.Migrations
{
    public partial class addPhongImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "phongImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    PhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phongImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_phongImage_phongs_PhongId",
                        column: x => x.PhongId,
                        principalTable: "phongs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_phongImage_PhongId",
                table: "phongImage",
                column: "PhongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "phongImage");
        }
    }
}
