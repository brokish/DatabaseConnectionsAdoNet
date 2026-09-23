using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entityLesson.Migrations
{
    /// <inheritdoc />
    public partial class addTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Studaents",
                table: "Studaents");

            migrationBuilder.RenameTable(
                name: "Studaents",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Studaents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studaents",
                table: "Studaents",
                column: "Id");
        }
    }
}
