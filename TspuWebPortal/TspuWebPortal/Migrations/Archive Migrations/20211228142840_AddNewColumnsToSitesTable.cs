using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class AddNewColumnsToSitesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FederalDistrict",
                table: "Sites",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IsInProject",
                table: "Sites",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaintainanceStatus",
                table: "Sites",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PipelineStage",
                table: "Sites",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RegionNumber",
                table: "Sites",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FederalDistrict",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "IsInProject",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "MaintainanceStatus",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "PipelineStage",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "RegionNumber",
                table: "Sites");
        }
    }
}
