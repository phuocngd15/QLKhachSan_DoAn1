using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel.Migrations
{
    public partial class CreateKeyPhieuDatPhongBill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SystemAccount",
                columns: table => new
                {
                    SystemAccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemAccountName = table.Column<string>(maxLength: 20, nullable: true),
                    SystemAccountPassWords = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemAccount", x => x.SystemAccountId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PhieuDatPhongId",
                table: "Bills",
                column: "PhieuDatPhongId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_PhieuDatPhongs_PhieuDatPhongId",
                table: "Bills",
                column: "PhieuDatPhongId",
                principalTable: "PhieuDatPhongs",
                principalColumn: "PhieuDatPhongId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_PhieuDatPhongs_PhieuDatPhongId",
                table: "Bills");

            migrationBuilder.DropTable(
                name: "SystemAccount");

            migrationBuilder.DropIndex(
                name: "IX_Bills_PhieuDatPhongId",
                table: "Bills");
        }
    }
}
