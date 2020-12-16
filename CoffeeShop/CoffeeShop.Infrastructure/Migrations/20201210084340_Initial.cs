using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeShop.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bangluong",
                columns: table => new
                {
                    MaNV = table.Column<string>(nullable: false),
                    TienThuong = table.Column<int>(nullable: false),
                    TamUng = table.Column<int>(nullable: false),
                    Luong = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bangluong", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    MaMon = table.Column<string>(nullable: false),
                    TenMon = table.Column<string>(maxLength: 20, nullable: true),
                    DonGia = table.Column<int>(nullable: false),
                    SoLuongTon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.MaMon);
                });

            migrationBuilder.CreateTable(
                name: "nhanvien",
                columns: table => new
                {
                    MaNV = table.Column<string>(nullable: false),
                    TenNV = table.Column<string>(maxLength: 20, nullable: true),
                    HoNV = table.Column<string>(maxLength: 20, nullable: true),
                    SDT = table.Column<string>(nullable: true),
                    GioiTinh = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanvien", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "chitietnhap",
                columns: table => new
                {
                    MaNhap = table.Column<string>(nullable: false),
                    DVT = table.Column<string>(nullable: true),
                    Ngay = table.Column<string>(nullable: true),
                    TongTien = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    MaMon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chitietnhap", x => x.MaNhap);
                    table.ForeignKey(
                        name: "Menu_ChiTietNhap",
                        column: x => x.MaMon,
                        principalTable: "menu",
                        principalColumn: "MaMon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoadon",
                columns: table => new
                {
                    MaHD = table.Column<string>(nullable: false),
                    NgayLapHD = table.Column<string>(nullable: true),
                    ThoiGian = table.Column<string>(nullable: true),
                    SoLuong = table.Column<string>(nullable: true),
                    MaNV = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoadon", x => x.MaHD);
                    table.ForeignKey(
                        name: "NhanVien_HoaDon",
                        column: x => x.MaNV,
                        principalTable: "nhanvien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "phanca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(nullable: true),
                    HeSoLuong = table.Column<int>(nullable: false),
                    SoGio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phanca", x => x.Id);
                    table.ForeignKey(
                        name: "BangLuong_PhanCa",
                        column: x => x.MaNV,
                        principalTable: "bangluong",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "NhanVien_PhanCa",
                        column: x => x.MaNV,
                        principalTable: "nhanvien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "taikhoan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taikhoan", x => x.Id);
                    table.ForeignKey(
                        name: "NhanVien_TaiKhoan",
                        column: x => x.UserName,
                        principalTable: "nhanvien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cthd",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHD = table.Column<string>(nullable: true),
                    MaMon = table.Column<string>(nullable: true),
                    SoLuong = table.Column<int>(nullable: false),
                    Gia = table.Column<int>(nullable: false),
                    TenMon = table.Column<string>(maxLength: 20, nullable: true),
                    MaHoaDonNavigationMaHD = table.Column<string>(nullable: true),
                    MaMonNavigationMaMon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cthd", x => x.ID);
                    table.ForeignKey(
                        name: "FK_cthd_hoadon_MaHoaDonNavigationMaHD",
                        column: x => x.MaHoaDonNavigationMaHD,
                        principalTable: "hoadon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cthd_menu_MaMonNavigationMaMon",
                        column: x => x.MaMonNavigationMaMon,
                        principalTable: "menu",
                        principalColumn: "MaMon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chitietnhap_MaMon",
                table: "chitietnhap",
                column: "MaMon");

            migrationBuilder.CreateIndex(
                name: "IX_cthd_MaHoaDonNavigationMaHD",
                table: "cthd",
                column: "MaHoaDonNavigationMaHD");

            migrationBuilder.CreateIndex(
                name: "IX_cthd_MaMonNavigationMaMon",
                table: "cthd",
                column: "MaMonNavigationMaMon");

            migrationBuilder.CreateIndex(
                name: "IX_hoadon_MaNV",
                table: "hoadon",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_phanca_MaNV",
                table: "phanca",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_taikhoan_UserName",
                table: "taikhoan",
                column: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chitietnhap");

            migrationBuilder.DropTable(
                name: "cthd");

            migrationBuilder.DropTable(
                name: "phanca");

            migrationBuilder.DropTable(
                name: "taikhoan");

            migrationBuilder.DropTable(
                name: "hoadon");

            migrationBuilder.DropTable(
                name: "menu");

            migrationBuilder.DropTable(
                name: "bangluong");

            migrationBuilder.DropTable(
                name: "nhanvien");
        }
    }
}
