using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoCsharp.Data.Migrations
{
    public partial class LeaveTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Empleado",
                table: "LeaveAllocation");

            migrationBuilder.RenameColumn(
                name: "DateCreates",
                table: "LeaveTypes",
                newName: "DateCreated");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "LeaveTypes",
                newName: "DateCreates");

            migrationBuilder.AddColumn<string>(
                name: "Empleado",
                table: "LeaveAllocation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
