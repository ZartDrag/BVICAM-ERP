using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Latest.Migrations
{
    public partial class Student_Basics1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student_Basics",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CetType = table.Column<int>(type: "int", nullable: false),
                    CetNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentMobile = table.Column<long>(type: "bigint", nullable: true),
                    StudentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVerified = table.Column<byte>(type: "tinyint", nullable: false),
                    IsWithdraw = table.Column<byte>(type: "tinyint", nullable: false),
                    WithdrawDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WithdrawReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Basics", x => x.StudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student_Basics");
        }
    }
}
