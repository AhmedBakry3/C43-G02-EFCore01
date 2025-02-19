using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Session_1_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class EditCourse_InstTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_courses_Insts",
                table: "courses_Insts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "courses_Insts");

            migrationBuilder.DropColumn(
                name: "Top_ID",
                table: "courses_Insts");

            migrationBuilder.RenameTable(
                name: "courses_Insts",
                newName: "Courses_Insts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses_Insts",
                table: "Courses_Insts",
                columns: new[] { "Course_ID", "Inst_Id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses_Insts",
                table: "Courses_Insts");

            migrationBuilder.RenameTable(
                name: "Courses_Insts",
                newName: "courses_Insts");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "courses_Insts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Top_ID",
                table: "courses_Insts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses_Insts",
                table: "courses_Insts",
                columns: new[] { "Course_ID", "Inst_Id" });
        }
    }
}
