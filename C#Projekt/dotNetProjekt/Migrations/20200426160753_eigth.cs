using Microsoft.EntityFrameworkCore.Migrations;

namespace dotNetProjekt.Migrations
{
    public partial class eigth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Hours",
                table: "workTimes",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hours",
                table: "workTimes");
        }
    }
}
