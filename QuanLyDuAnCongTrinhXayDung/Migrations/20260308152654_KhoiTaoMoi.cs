using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAnCongTrinhXayDung.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoMoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VatTuChiTiet");

            migrationBuilder.CreateTable(
                name: "PhanPhoi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuAnID = table.Column<int>(type: "int", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanPhoi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhanPhoi_DuAn_DuAnID",
                        column: x => x.DuAnID,
                        principalTable: "DuAn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanPhoiChiTiet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhanPhoiID = table.Column<int>(type: "int", nullable: false),
                    VatTuID = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DuAnID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanPhoiChiTiet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhanPhoiChiTiet_DuAn_DuAnID",
                        column: x => x.DuAnID,
                        principalTable: "DuAn",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PhanPhoiChiTiet_PhanPhoi_PhanPhoiID",
                        column: x => x.PhanPhoiID,
                        principalTable: "PhanPhoi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhanPhoiChiTiet_VatTu_VatTuID",
                        column: x => x.VatTuID,
                        principalTable: "VatTu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhanPhoi_DuAnID",
                table: "PhanPhoi",
                column: "DuAnID");

            migrationBuilder.CreateIndex(
                name: "IX_PhanPhoiChiTiet_DuAnID",
                table: "PhanPhoiChiTiet",
                column: "DuAnID");

            migrationBuilder.CreateIndex(
                name: "IX_PhanPhoiChiTiet_PhanPhoiID",
                table: "PhanPhoiChiTiet",
                column: "PhanPhoiID");

            migrationBuilder.CreateIndex(
                name: "IX_PhanPhoiChiTiet_VatTuID",
                table: "PhanPhoiChiTiet",
                column: "VatTuID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhanPhoiChiTiet");

            migrationBuilder.DropTable(
                name: "PhanPhoi");

            migrationBuilder.CreateTable(
                name: "VatTuChiTiet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DuAnID = table.Column<int>(type: "int", nullable: false),
                    VatTuID = table.Column<int>(type: "int", nullable: false),
                    DonGiaTaiThoiDiem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapPhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatTuChiTiet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VatTuChiTiet_DuAn_DuAnID",
                        column: x => x.DuAnID,
                        principalTable: "DuAn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VatTuChiTiet_VatTu_VatTuID",
                        column: x => x.VatTuID,
                        principalTable: "VatTu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VatTuChiTiet_DuAnID",
                table: "VatTuChiTiet",
                column: "DuAnID");

            migrationBuilder.CreateIndex(
                name: "IX_VatTuChiTiet_VatTuID",
                table: "VatTuChiTiet",
                column: "VatTuID");
        }
    }
}
