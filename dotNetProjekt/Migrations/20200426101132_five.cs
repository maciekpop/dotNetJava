using Microsoft.EntityFrameworkCore.Migrations;

namespace dotNetProjekt.Migrations
{
    public partial class five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_workTimes_employees_EmployeeId",
                table: "workTimes");

            migrationBuilder.DropIndex(
                name: "IX_workTimes_EmployeeId",
                table: "workTimes");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "workTimes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "workTimes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_workTimes_EmployeeId",
                table: "workTimes",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_workTimes_employees_EmployeeId",
                table: "workTimes",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
