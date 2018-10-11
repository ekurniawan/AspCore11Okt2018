using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleIdentity.Data.Migrations
{
    public partial class Tambah_Table_Matakulian_dan_Pengambilan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matakuliah",
                columns: table => new
                {
                    MatakuliahID = table.Column<string>(nullable: false),
                    NamaMatakuliah = table.Column<string>(nullable: true),
                    JumlahSKS = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matakuliah", x => x.MatakuliahID);
                });

            migrationBuilder.CreateTable(
                name: "Pengambilan",
                columns: table => new
                {
                    PengambilanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nim = table.Column<string>(nullable: true),
                    MatakuliahID = table.Column<string>(nullable: true),
                    Nilai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pengambilan", x => x.PengambilanID);
                    table.ForeignKey(
                        name: "FK_Pengambilan_Matakuliah_MatakuliahID",
                        column: x => x.MatakuliahID,
                        principalTable: "Matakuliah",
                        principalColumn: "MatakuliahID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pengambilan_Mahasiswa_Nim",
                        column: x => x.Nim,
                        principalTable: "Mahasiswa",
                        principalColumn: "Nim",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pengambilan_MatakuliahID",
                table: "Pengambilan",
                column: "MatakuliahID");

            migrationBuilder.CreateIndex(
                name: "IX_Pengambilan_Nim",
                table: "Pengambilan",
                column: "Nim");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pengambilan");

            migrationBuilder.DropTable(
                name: "Matakuliah");
        }
    }
}
