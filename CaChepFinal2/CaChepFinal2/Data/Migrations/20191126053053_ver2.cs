using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaChepFinal2.Data.Migrations
{
    public partial class ver2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loaiDVs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiDVs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "loaiPhongs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiPhongs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "trangThais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trangThais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dichVus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    InStock = table.Column<int>(nullable: false),
                    LoaiDVId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dichVus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dichVus_loaiDVs_LoaiDVId",
                        column: x => x.LoaiDVId,
                        principalTable: "loaiDVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "phongs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    TrangThai = table.Column<int>(nullable: false),
                    LoaiPhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_phongs_loaiPhongs_LoaiPhongId",
                        column: x => x.LoaiPhongId,
                        principalTable: "loaiPhongs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "datPhongs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNguoiDat = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CMND = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true),
                    TienDatCoc = table.Column<decimal>(nullable: false),
                    ThoiGianNhanPhongDuKien = table.Column<DateTime>(nullable: false),
                    ThoiGianTraPhongDuKien = table.Column<DateTime>(nullable: false),
                    TrangThaiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_datPhongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_datPhongs_trangThais_TrangThaiId",
                        column: x => x.TrangThaiId,
                        principalTable: "trangThais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dichVuCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DichVuId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    DichVuCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dichVuCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dichVuCartItems_dichVus_DichVuId",
                        column: x => x.DichVuId,
                        principalTable: "dichVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDichVuDatPhongs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatPhongId = table.Column<int>(nullable: false),
                    DichVuId = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    GiaTien = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDichVuDatPhongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietDichVuDatPhongs_datPhongs_DatPhongId",
                        column: x => x.DatPhongId,
                        principalTable: "datPhongs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDichVuDatPhongs_dichVus_DichVuId",
                        column: x => x.DichVuId,
                        principalTable: "dichVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhongDatPhongs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatPhongId = table.Column<int>(nullable: false),
                    PhongId = table.Column<int>(nullable: false),
                    TongSoNgay = table.Column<int>(nullable: false),
                    GiaTienMotNgay = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhongDatPhongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietPhongDatPhongs_datPhongs_DatPhongId",
                        column: x => x.DatPhongId,
                        principalTable: "datPhongs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhongDatPhongs_phongs_PhongId",
                        column: x => x.PhongId,
                        principalTable: "phongs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatPhongId = table.Column<int>(nullable: false),
                    TenNguoiTao = table.Column<string>(nullable: true),
                    ThoiGianTao = table.Column<DateTime>(nullable: false),
                    TongTien = table.Column<decimal>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hoaDons_datPhongs_DatPhongId",
                        column: x => x.DatPhongId,
                        principalTable: "datPhongs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "loaiDVs",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "notthing", null, "Thuc An" },
                    { 2, "notthing", null, "Nuoc Uong" }
                });

            migrationBuilder.InsertData(
                table: "loaiPhongs",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, null, null, "Phong Don" },
                    { 2, null, null, "Phong Doi" }
                });

            migrationBuilder.InsertData(
                table: "trangThais",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chưa Nhận" },
                    { 2, "Đã Nhận" },
                    { 3, "Đã Thanh Toán" }
                });

            migrationBuilder.InsertData(
                table: "datPhongs",
                columns: new[] { "Id", "Address", "CMND", "City", "SDT", "TenNguoiDat", "ThoiGianNhanPhongDuKien", "ThoiGianTraPhongDuKien", "TienDatCoc", "TrangThaiId" },
                values: new object[,]
                {
                    { 1, "149", "281212911", null, "0937536545", "Nguyen Phuoc", new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 1 },
                    { 2, "149", "281212910", null, "01264079970", "Nguyen Truc", new DateTime(2019, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 1 },
                    { 3, "22", "281212915", null, "01264079970", "Nguyen Truc2", new DateTime(2019, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 2 }
                });

            migrationBuilder.InsertData(
                table: "dichVus",
                columns: new[] { "Id", "ImageUrl", "InStock", "LoaiDVId", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, null, 100, 1, "NuocTangLuc", 15000m, null },
                    { 2, null, 100, 1, "NuocSuoi", 15000m, null }
                });

            migrationBuilder.InsertData(
                table: "phongs",
                columns: new[] { "Id", "ImageUrl", "LoaiPhongId", "Name", "Price", "ShortDescription", "TrangThai" },
                values: new object[,]
                {
                    { 1, null, 1, "A101", 150000m, null, 1 },
                    { 2, null, 1, "A102", 150000m, null, 1 },
                    { 3, null, 2, "A103", 150000m, null, 1 },
                    { 4, null, 2, "A104", 170000m, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ChiTietDichVuDatPhongs",
                columns: new[] { "Id", "DatPhongId", "DichVuId", "GiaTien", "SoLuong" },
                values: new object[,]
                {
                    { 1, 1, 1, 0m, 2 },
                    { 2, 1, 2, 0m, 2 }
                });

            migrationBuilder.InsertData(
                table: "ChiTietPhongDatPhongs",
                columns: new[] { "Id", "DatPhongId", "GiaTienMotNgay", "PhongId", "TongSoNgay" },
                values: new object[,]
                {
                    { 1, 1, 150000m, 1, 3 },
                    { 2, 1, 150000m, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVuDatPhongs_DatPhongId",
                table: "ChiTietDichVuDatPhongs",
                column: "DatPhongId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVuDatPhongs_DichVuId",
                table: "ChiTietDichVuDatPhongs",
                column: "DichVuId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhongDatPhongs_DatPhongId",
                table: "ChiTietPhongDatPhongs",
                column: "DatPhongId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhongDatPhongs_PhongId",
                table: "ChiTietPhongDatPhongs",
                column: "PhongId");

            migrationBuilder.CreateIndex(
                name: "IX_datPhongs_TrangThaiId",
                table: "datPhongs",
                column: "TrangThaiId");

            migrationBuilder.CreateIndex(
                name: "IX_dichVuCartItems_DichVuId",
                table: "dichVuCartItems",
                column: "DichVuId");

            migrationBuilder.CreateIndex(
                name: "IX_dichVus_LoaiDVId",
                table: "dichVus",
                column: "LoaiDVId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_DatPhongId",
                table: "hoaDons",
                column: "DatPhongId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_phongs_LoaiPhongId",
                table: "phongs",
                column: "LoaiPhongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDichVuDatPhongs");

            migrationBuilder.DropTable(
                name: "ChiTietPhongDatPhongs");

            migrationBuilder.DropTable(
                name: "dichVuCartItems");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "phongs");

            migrationBuilder.DropTable(
                name: "dichVus");

            migrationBuilder.DropTable(
                name: "datPhongs");

            migrationBuilder.DropTable(
                name: "loaiPhongs");

            migrationBuilder.DropTable(
                name: "loaiDVs");

            migrationBuilder.DropTable(
                name: "trangThais");
        }
    }
}
