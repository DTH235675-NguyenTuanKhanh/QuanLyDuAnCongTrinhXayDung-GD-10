using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAnCongTrinhXayDung.Migrations
{
    /// <inheritdoc />
    public partial class CSDLMoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HinhAnh",
                table: "PhanPhoi");

            migrationBuilder.AddColumn<string>(
                name: "HinhAnh",
                table: "VatTu",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HinhAnh",
                table: "VatTu");

            migrationBuilder.AddColumn<string>(
                name: "HinhAnh",
                table: "PhanPhoi",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
