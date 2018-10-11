using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleIdentity.Data.Migrations
{
    public partial class Tambah_Table_Mahasiswa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mahasiswa",
                columns: table => new
                {
                    Nim = table.Column<string>(nullable: false),
                    Nama = table.Column<string>(nullable: true),
                    IPK = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahasiswa", x => x.Nim);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mahasiswa");
        }
    }
}
