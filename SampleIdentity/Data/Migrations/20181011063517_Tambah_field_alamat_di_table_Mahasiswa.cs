using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleIdentity.Data.Migrations
{
    public partial class Tambah_field_alamat_di_table_Mahasiswa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alamat",
                table: "Mahasiswa",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alamat",
                table: "Mahasiswa");
        }
    }
}
