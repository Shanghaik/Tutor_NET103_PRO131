using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class add2table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    SDT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.SDT);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gia = table.Column<decimal>(type: "money", nullable: true),
                    Soluong = table.Column<int>(type: "int", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TongTien = table.Column<decimal>(type: "money", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangSDT = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHangs_KhachHangSDT",
                        column: x => x.KhachHangSDT,
                        principalTable: "KhachHangs",
                        principalColumn: "SDT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HDCT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDSP = table.Column<int>(type: "int", nullable: true),
                    IDHD = table.Column<int>(type: "int", nullable: true),
                    Gia = table.Column<decimal>(type: "money", nullable: true),
                    Soluong = table.Column<int>(type: "int", nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDCT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HDCT_HD",
                        column: x => x.IDHD,
                        principalTable: "HoaDon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HDCT_SP",
                        column: x => x.IDSP,
                        principalTable: "SanPham",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HDCT_IDHD",
                table: "HDCT",
                column: "IDHD");

            migrationBuilder.CreateIndex(
                name: "IX_HDCT_IDSP",
                table: "HDCT",
                column: "IDSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangSDT",
                table: "HoaDon",
                column: "KhachHangSDT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienId",
                table: "HoaDon",
                column: "NhanVienId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HDCT");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");
        }
    }
}
