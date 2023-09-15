using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Latest.Migrations
{
    public partial class Student_Details_Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Student_Details",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Student_Details");
        }
    }
}
