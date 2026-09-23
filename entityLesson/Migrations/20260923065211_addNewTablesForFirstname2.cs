using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entityLesson.Migrations
{
    /// <inheritdoc />
    public partial class addNewTablesForFirstname2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Students",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "mail",
                table: "Students",
                newName: "Mail");

            migrationBuilder.RenameColumn(
                name: "firstname",
                table: "Students",
                newName: "Firstname");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Students",
                newName: "Age");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Students",
                newName: "mail");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Students",
                newName: "firstname");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Students",
                newName: "age");
        }
    }
}
