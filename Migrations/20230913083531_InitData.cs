using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Latest.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SemesterId = table.Column<int>(type: "int", nullable: false),
                    CourseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Student_Details",
                columns: table => new
                {
                    StudentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentDob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentAlternateEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentAlternateMobile = table.Column<long>(type: "bigint", nullable: true),
                    StudentFatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentMotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentPermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentCurrentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentFatherMobile = table.Column<long>(type: "bigint", nullable: false),
                    StudentMotherMobile = table.Column<long>(type: "bigint", nullable: false),
                    StudentBloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentCetRank = table.Column<int>(type: "int", nullable: false),
                    StudentPreviousSchoolDetails = table.Column<int>(type: "int", nullable: false),
                    StudentGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentCategory = table.Column<int>(type: "int", nullable: false),
                    StudentCommunity = table.Column<int>(type: "int", nullable: false),
                    StudentProgramme = table.Column<int>(type: "int", nullable: false),
                    StudentBatch = table.Column<int>(type: "int", nullable: false),
                    StudentShift = table.Column<int>(type: "int", nullable: true),
                    StudentIsMgmt = table.Column<bool>(type: "bit", nullable: true),
                    StudentIsOutDelhi = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentCetType = table.Column<int>(type: "int", nullable: true),
                    MentorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Details", x => x.StudentDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student_Details");
        }
    }
}
