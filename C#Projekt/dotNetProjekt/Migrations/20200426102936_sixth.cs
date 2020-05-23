using Microsoft.EntityFrameworkCore.Migrations;

namespace dotNetProjekt.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "workTimes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "workTimes",
                nullable: false,
                defaultValue: 0);
        }
    }
}
