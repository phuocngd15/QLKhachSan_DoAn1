using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel.Migrations
{
    public partial class ver4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDons_Bills_BillId",
                table: "ChiTietHoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons");

            migrationBuilder.DropColumn(
                name: "IdBill",
                table: "ChiTietHoaDons");

            migrationBuilder.AlterColumn<int>(
                name: "BillId",
                table: "ChiTietHoaDons",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDons_Bills_BillId",
                table: "ChiTietHoaDons",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "BillId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDons_Bills_BillId",
                table: "ChiTietHoaDons");

            migrationBuilder.AlterColumn<int>(
                name: "BillId",
                table: "ChiTietHoaDons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdBill",
                table: "ChiTietHoaDons",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons",
                column: "IdBill");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDons_Bills_BillId",
                table: "ChiTietHoaDons",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "BillId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
