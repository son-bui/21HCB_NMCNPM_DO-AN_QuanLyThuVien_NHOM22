using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class ForeignKeySach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sachs_NhanVienId",
                table: "Sachs",
                column: "NhanVienId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sachs_NhanViens_NhanVienId",
                table: "Sachs",
                column: "NhanVienId",
                principalTable: "NhanViens",
                principalColumn: "NhanVienId"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sachs_NhanViens_NhanVienId",
                table: "Sachs");

            migrationBuilder.DropIndex(
                name: "IX_Sachs_NhanVienId",
                table: "Sachs");
        }
    }
}
