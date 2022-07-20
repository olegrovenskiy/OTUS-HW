using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Minor_Model_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHydraSideA",
                table: "Modules");

            migrationBuilder.AddColumn<int>(
                name: "HydraEndNumber",
                table: "Modules",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HydraEndNumber",
                table: "Modules");

            migrationBuilder.AddColumn<bool>(
                name: "IsHydraSideA",
                table: "Modules",
                type: "boolean",
                nullable: true);
        }
    }
}
