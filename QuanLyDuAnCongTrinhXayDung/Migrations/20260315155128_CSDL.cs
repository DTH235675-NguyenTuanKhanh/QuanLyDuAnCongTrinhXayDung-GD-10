using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAnCongTrinhXayDung.Migrations
{
    /// <inheritdoc />
    public partial class CSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DonGia",
                table: "PhanPhoiChiTiet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TongChiPhi",
                table: "PhanPhoiChiTiet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DonGia",
                table: "PhanPhoiChiTiet");

            migrationBuilder.DropColumn(
                name: "TongChiPhi",
                table: "PhanPhoiChiTiet");
        }
    }
}
