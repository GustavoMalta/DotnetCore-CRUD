using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetCRUD.Migrations
{
    public partial class ActiveMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Employees",
                nullable: false,
                defaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Employees");
        }
    }
}
