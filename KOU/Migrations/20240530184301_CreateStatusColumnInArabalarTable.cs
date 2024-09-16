using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOU.Migrations
{
    /// <inheritdoc />
    public partial class CreateStatusColumnInArabalarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArabaSahipleri_Arabalar_ArabaId",
                table: "ArabaSahipleri");

            migrationBuilder.DropIndex(
                name: "IX_ArabaSahipleri_ArabaId",
                table: "ArabaSahipleri");

            migrationBuilder.AlterColumn<string>(
                name: "Sasi",
                table: "Arabalar",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Renk",
                table: "Arabalar",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ArabaYili",
                table: "Arabalar",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabaYili",
                table: "Arabalar");

            migrationBuilder.AlterColumn<string>(
                name: "Sasi",
                table: "Arabalar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "Renk",
                table: "Arabalar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.CreateIndex(
                name: "IX_ArabaSahipleri_ArabaId",
                table: "ArabaSahipleri",
                column: "ArabaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArabaSahipleri_Arabalar_ArabaId",
                table: "ArabaSahipleri",
                column: "ArabaId",
                principalTable: "Arabalar",
                principalColumn: "ArabaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
