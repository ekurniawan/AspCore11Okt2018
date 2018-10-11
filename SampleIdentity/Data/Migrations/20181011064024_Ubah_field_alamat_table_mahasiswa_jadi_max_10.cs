using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleIdentity.Data.Migrations
{
    public partial class Ubah_field_alamat_table_mahasiswa_jadi_max_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Alamat",
                table: "Mahasiswa",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Alamat",
                table: "Mahasiswa",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
