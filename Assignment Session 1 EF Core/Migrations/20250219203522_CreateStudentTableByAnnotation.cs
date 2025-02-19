using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Session_1_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class CreateStudentTableByAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LName",
                table: "Students",
                newName: "StudentLastName");

            migrationBuilder.RenameColumn(
                name: "FName",
                table: "Students",
                newName: "StudentFirstName");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Students",
                newName: "StudentAddress");

            migrationBuilder.AlterColumn<string>(
                name: "StudentLastName",
                table: "Students",
                type: "VarChar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentFirstName",
                table: "Students",
                type: "VarChar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentAddress",
                table: "Students",
                type: "VarChar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentLastName",
                table: "Students",
                newName: "LName");

            migrationBuilder.RenameColumn(
                name: "StudentFirstName",
                table: "Students",
                newName: "FName");

            migrationBuilder.RenameColumn(
                name: "StudentAddress",
                table: "Students",
                newName: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(50)",
                oldMaxLength: 50);
        }
    }
}
