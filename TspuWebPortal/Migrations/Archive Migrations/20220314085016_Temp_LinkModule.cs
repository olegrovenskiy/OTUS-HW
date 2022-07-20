using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Temp_LinkModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModuleAId",
                table: "Links");

            migrationBuilder.RenameColumn(
                name: "ModuleBId",
                table: "Links",
                newName: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ModuleId",
                table: "Links",
                column: "ModuleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Modules_ModuleId",
                table: "Links",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Modules_ModuleId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ModuleId",
                table: "Links");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "Links",
                newName: "ModuleBId");

            migrationBuilder.AddColumn<int>(
                name: "ModuleAId",
                table: "Links",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
