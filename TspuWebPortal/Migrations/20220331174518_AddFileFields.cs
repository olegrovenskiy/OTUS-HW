using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class AddFileFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileCategory",
                table: "FileData",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAppliedToTable",
                table: "FileData",
                type: "boolean",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileCategory",
                table: "FileData");

            migrationBuilder.DropColumn(
                name: "IsAppliedToTable",
                table: "FileData");
        }
    }
}
