using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class DeleteUnused_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FactoryName",
                table: "DetailRecord");

            migrationBuilder.DropColumn(
                name: "SnDefinitionType",
                table: "DetailRecord");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FactoryName",
                table: "DetailRecord",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SnDefinitionType",
                table: "DetailRecord",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
