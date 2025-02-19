using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Session_1_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class CreateStud_CourseCourse_InstTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses_Insts",
                columns: table => new
                {
                    Inst_Id = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<decimal>(type: "int", nullable: false),
                    Evaluate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Top_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses_Insts", x => new { x.Course_ID, x.Inst_Id });
                });

            migrationBuilder.CreateTable(
                name: "Studs_Courses",
                columns: table => new
                {
                    Stud_Id = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studs_Courses", x => new { x.Stud_Id, x.Course_ID });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courses_Insts");

            migrationBuilder.DropTable(
                name: "Studs_Courses");
        }
    }
}
