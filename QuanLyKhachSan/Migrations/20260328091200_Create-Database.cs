using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHUCNANG",
                columns: table => new
                {
                    maChucNang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tenChucNang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHUCNANG", x => x.maChucNang);
                });

            migrationBuilder.CreateTable(
                name: "DICHVU",
                columns: table => new
                {
                    maDV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tenDV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    loaiDV = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    giaDV = table.Column<int>(type: "int", nullable: false),
                    hinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    xuLy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DICHVU", x => x.maDV);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    maKH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tenKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CMND = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    gioiTinh = table.Column<int>(type: "int", nullable: false),
                    sDT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    queQuan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    quocTich = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    xuLy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHACHHANG", x => x.maKH);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    maNV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tenNV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gioiTinh = table.Column<int>(type: "int", nullable: false),
                    soNgayPhep = table.Column<int>(type: "int", nullable: false),
                    chucVu = table.Column<int>(type: "int", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    luong1Ngay = table.Column<int>(type: "int", nullable: false),
                    xuLy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHANVIEN", x => x.maNV);
                });

            migrationBuilder.CreateTable(
                name: "PHANQUYEN",
                columns: table => new
                {
                    maPQ = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tenPQ = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHANQUYEN", x => x.maPQ);
                });

            migrationBuilder.CreateTable(
                name: "PHONG",
                columns: table => new
                {
                    maP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tenP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    loaiP = table.Column<int>(type: "int", nullable: false),
                    giaP = table.Column<int>(type: "int", nullable: false),
                    chiTietLoaiP = table.Column<int>(type: "int", nullable: false),
                    tinhTrang = table.Column<int>(type: "int", nullable: false),
                    hienTrang = table.Column<int>(type: "int", nullable: false),
                    xuLy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHONG", x => x.maP);
                });

            migrationBuilder.CreateTable(
                name: "TIENICH",
                columns: table => new
                {
                    maTI = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tenTI = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    xuLy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIENICH", x => x.maTI);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETTHUE",
                columns: table => new
                {
                    maCTT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    maKH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    maNV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ngayLapPhieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tienDatCoc = table.Column<int>(type: "int", nullable: false),
                    tinhTrangXuLy = table.Column<int>(type: "int", nullable: false),
                    xuLy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETTHUE", x => x.maCTT);
                    table.ForeignKey(
                        name: "FK_CHITIETTHUE_KHACHHANG_maKH",
                        column: x => x.maKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "maKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHITIETTHUE_NHANVIEN_maNV",
                        column: x => x.maNV,
                        principalTable: "NHANVIEN",
                        principalColumn: "maNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETCHUCNANG",
                columns: table => new
                {
                    maPQ = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    maChucNang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETCHUCNANG", x => new { x.maPQ, x.maChucNang });
                    table.ForeignKey(
                        name: "FK_CHITIETCHUCNANG_CHUCNANG_maChucNang",
                        column: x => x.maChucNang,
                        principalTable: "CHUCNANG",
                        principalColumn: "maChucNang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHITIETCHUCNANG_PHANQUYEN_maPQ",
                        column: x => x.maPQ,
                        principalTable: "PHANQUYEN",
                        principalColumn: "maPQ",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TAIKHOAN",
                columns: table => new
                {
                    taiKhoan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    maNV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    matKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tinhTrang = table.Column<int>(type: "int", nullable: false),
                    maPQ = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    xuLy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAIKHOAN", x => x.taiKhoan);
                    table.ForeignKey(
                        name: "FK_TAIKHOAN_NHANVIEN_maNV",
                        column: x => x.maNV,
                        principalTable: "NHANVIEN",
                        principalColumn: "maNV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TAIKHOAN_PHANQUYEN_maPQ",
                        column: x => x.maPQ,
                        principalTable: "PHANQUYEN",
                        principalColumn: "maPQ",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETTIENICH",
                columns: table => new
                {
                    maP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    maTI = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    soLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETTIENICH", x => new { x.maP, x.maTI });
                    table.ForeignKey(
                        name: "FK_CHITIETTIENICH_PHONG_maP",
                        column: x => x.maP,
                        principalTable: "PHONG",
                        principalColumn: "maP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHITIETTIENICH_TIENICH_maTI",
                        column: x => x.maTI,
                        principalTable: "TIENICH",
                        principalColumn: "maTI",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETTHUEDICHVU",
                columns: table => new
                {
                    maCTT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    maDV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ngaySuDung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    giaDV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETTHUEDICHVU", x => new { x.maCTT, x.maDV, x.ngaySuDung });
                    table.ForeignKey(
                        name: "FK_CHITIETTHUEDICHVU_CHITIETTHUE_maCTT",
                        column: x => x.maCTT,
                        principalTable: "CHITIETTHUE",
                        principalColumn: "maCTT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHITIETTHUEDICHVU_DICHVU_maDV",
                        column: x => x.maDV,
                        principalTable: "DICHVU",
                        principalColumn: "maDV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETTHUEPHONG",
                columns: table => new
                {
                    maCTT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    maP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ngayThue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayCheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    loaiHinhThue = table.Column<int>(type: "int", nullable: false),
                    giaThue = table.Column<int>(type: "int", nullable: false),
                    tinhTrang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETTHUEPHONG", x => new { x.maCTT, x.maP, x.ngayThue });
                    table.ForeignKey(
                        name: "FK_CHITIETTHUEPHONG_CHITIETTHUE_maCTT",
                        column: x => x.maCTT,
                        principalTable: "CHITIETTHUE",
                        principalColumn: "maCTT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHITIETTHUEPHONG_PHONG_maP",
                        column: x => x.maP,
                        principalTable: "PHONG",
                        principalColumn: "maP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    maHD = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    maCTT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    giamGia = table.Column<int>(type: "int", nullable: false),
                    phuThu = table.Column<int>(type: "int", nullable: false),
                    ngayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phuongThucThanhToan = table.Column<int>(type: "int", nullable: false),
                    xuLy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOADON", x => x.maHD);
                    table.ForeignKey(
                        name: "FK_HOADON_CHITIETTHUE_maCTT",
                        column: x => x.maCTT,
                        principalTable: "CHITIETTHUE",
                        principalColumn: "maCTT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETCHUCNANG_maChucNang",
                table: "CHITIETCHUCNANG",
                column: "maChucNang");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETTHUE_maKH",
                table: "CHITIETTHUE",
                column: "maKH");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETTHUE_maNV",
                table: "CHITIETTHUE",
                column: "maNV");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETTHUEDICHVU_maDV",
                table: "CHITIETTHUEDICHVU",
                column: "maDV");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETTHUEPHONG_maP",
                table: "CHITIETTHUEPHONG",
                column: "maP");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETTIENICH_maTI",
                table: "CHITIETTIENICH",
                column: "maTI");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_maCTT",
                table: "HOADON",
                column: "maCTT");

            migrationBuilder.CreateIndex(
                name: "IX_TAIKHOAN_maNV",
                table: "TAIKHOAN",
                column: "maNV");

            migrationBuilder.CreateIndex(
                name: "IX_TAIKHOAN_maPQ",
                table: "TAIKHOAN",
                column: "maPQ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHITIETCHUCNANG");

            migrationBuilder.DropTable(
                name: "CHITIETTHUEDICHVU");

            migrationBuilder.DropTable(
                name: "CHITIETTHUEPHONG");

            migrationBuilder.DropTable(
                name: "CHITIETTIENICH");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "TAIKHOAN");

            migrationBuilder.DropTable(
                name: "CHUCNANG");

            migrationBuilder.DropTable(
                name: "DICHVU");

            migrationBuilder.DropTable(
                name: "PHONG");

            migrationBuilder.DropTable(
                name: "TIENICH");

            migrationBuilder.DropTable(
                name: "CHITIETTHUE");

            migrationBuilder.DropTable(
                name: "PHANQUYEN");

            migrationBuilder.DropTable(
                name: "KHACHHANG");

            migrationBuilder.DropTable(
                name: "NHANVIEN");
        }
    }
}
