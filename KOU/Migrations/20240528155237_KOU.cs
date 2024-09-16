using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOU.Migrations
{
    /// <inheritdoc />
    public partial class KOU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    ArabaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Problem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kilometre = table.Column<int>(type: "int", nullable: false),
                    Islem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IslemUcret = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.ArabaId);
                });

            migrationBuilder.CreateTable(
                name: "Parcalar",
                columns: table => new
                {
                    ParcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParcaIsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParcaStok = table.Column<int>(type: "int", nullable: false),
                    ParcaTur = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcalar", x => x.ParcaId);
                });

            migrationBuilder.CreateTable(
                name: "ArabaSahipleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabaSahibiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabaId = table.Column<int>(type: "int", nullable: false),
                    Borc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Alacak = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaSahipleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArabaSahipleri_Arabalar_ArabaId",
                        column: x => x.ArabaId,
                        principalTable: "Arabalar",
                        principalColumn: "ArabaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArabaSahipleri_ArabaId",
                table: "ArabaSahipleri",
                column: "ArabaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArabaSahipleri");

            migrationBuilder.DropTable(
                name: "Parcalar");

            migrationBuilder.DropTable(
                name: "Arabalar");
        }
    }
}
