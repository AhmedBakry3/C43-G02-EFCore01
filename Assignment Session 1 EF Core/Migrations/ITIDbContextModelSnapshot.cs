﻿// <auto-generated />
using System;
using Assignment_Session_1_EF_Core.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment_Session_1_EF_Core.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    partial class ITIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VarChar(50)")
                        .HasColumnName("CourseDecription");

                    b.Property<decimal>("Duration")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("CourseDuration");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VarChar(50)")
                        .HasColumnName("CourseName");

                    b.Property<int>("Top_ID")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Course_Inst", b =>
                {
                    b.Property<int>("Course_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("Inst_Id")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<decimal>("Evaluate")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("Course_Inst_Evaluate");

                    b.HasKey("Course_ID", "Inst_Id");

                    b.ToTable("Courses_Insts");
                });

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("DateTime2")
                        .HasColumnName("StudentHiringDate");

                    b.Property<int>("Ins_ID")
                        .HasColumnType("int")
                        .HasColumnName("Instructor_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("VarChar")
                        .HasColumnName("DepartmentAddress");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VarChar")
                        .HasColumnName("InstructorAddress");

                    b.Property<decimal>("Bouns")
                        .HasColumnType("decimal(11,2)")
                        .HasColumnName("InstructorBouns");

                    b.Property<int>("Dept_ID")
                        .HasColumnType("int")
                        .HasColumnName("Department_ID");

                    b.Property<decimal>("HourRate")
                        .HasColumnType("decimal(17,2)")
                        .HasColumnName("InstructorHourRate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar")
                        .HasColumnName("InstructorName");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(9,2)")
                        .HasColumnName("InstructorSalary");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Stud_Course", b =>
                {
                    b.Property<int>("Stud_Id")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("Course_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("Grade")
                        .HasColumnType("int")
                        .HasColumnName("SutdentGrade");

                    b.HasKey("Stud_Id", "Course_ID");

                    b.ToTable("Studs_Courses");
                });

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar")
                        .HasColumnName("StudentAddress");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Dept_ID")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar")
                        .HasColumnName("StudentFirstName");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar")
                        .HasColumnName("StudentLastName");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar")
                        .HasColumnName("TopicNmae");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });
#pragma warning restore 612, 618
        }
    }
}
