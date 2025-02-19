using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Session_1_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class CreateDepartmentInstructorTopicTablesByAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Topics",
                newName: "TopicNmae");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Instructors",
                newName: "InstructorSalary");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Instructors",
                newName: "InstructorName");

            migrationBuilder.RenameColumn(
                name: "HourRate",
                table: "Instructors",
                newName: "InstructorHourRate");

            migrationBuilder.RenameColumn(
                name: "Dept_ID",
                table: "Instructors",
                newName: "Department_ID");

            migrationBuilder.RenameColumn(
                name: "Bouns",
                table: "Instructors",
                newName: "InstructorBouns");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Instructors",
                newName: "InstructorAddress");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "DepartmentAddress");

            migrationBuilder.RenameColumn(
                name: "Ins_ID",
                table: "Departments",
                newName: "Instructor_ID");

            migrationBuilder.RenameColumn(
                name: "HiringDate",
                table: "Departments",
                newName: "StudentHiringDate");

            migrationBuilder.AlterColumn<string>(
                name: "TopicNmae",
                table: "Topics",
                type: "VarChar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InstructorSalary",
                table: "Instructors",
                type: "decimal(9,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "InstructorName",
                table: "Instructors",
                type: "VarChar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InstructorHourRate",
                table: "Instructors",
                type: "decimal(17,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InstructorBouns",
                table: "Instructors",
                type: "decimal(11,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "InstructorAddress",
                table: "Instructors",
                type: "VarChar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentAddress",
                table: "Departments",
                type: "VarChar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StudentHiringDate",
                table: "Departments",
                type: "DateTime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TopicNmae",
                table: "Topics",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "InstructorSalary",
                table: "Instructors",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "InstructorName",
                table: "Instructors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "InstructorHourRate",
                table: "Instructors",
                newName: "HourRate");

            migrationBuilder.RenameColumn(
                name: "InstructorBouns",
                table: "Instructors",
                newName: "Bouns");

            migrationBuilder.RenameColumn(
                name: "InstructorAddress",
                table: "Instructors",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Department_ID",
                table: "Instructors",
                newName: "Dept_ID");

            migrationBuilder.RenameColumn(
                name: "StudentHiringDate",
                table: "Departments",
                newName: "HiringDate");

            migrationBuilder.RenameColumn(
                name: "Instructor_ID",
                table: "Departments",
                newName: "Ins_ID");

            migrationBuilder.RenameColumn(
                name: "DepartmentAddress",
                table: "Departments",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Instructors",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "HourRate",
                table: "Instructors",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(17,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Bouns",
                table: "Instructors",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(70)",
                oldMaxLength: 70);
        }
    }
}
