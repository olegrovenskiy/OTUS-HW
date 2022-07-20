using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class AddModuleAModuleB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Modules_ModuleId",
                table: "Links");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "Links",
                newName: "ModuleBId");

            migrationBuilder.RenameIndex(
                name: "IX_Links_ModuleId",
                table: "Links",
                newName: "IX_Links_ModuleBId");

            migrationBuilder.AddColumn<int>(
                name: "ModuleAId",
                table: "Links",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ModuleAData",
                columns: table => new
                {
                    ModuleAId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModuleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleAData", x => x.ModuleAId);
                    table.ForeignKey(
                        name: "FK_ModuleAData_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleBData",
                columns: table => new
                {
                    ModuleBId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModuleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleBData", x => x.ModuleBId);
                    table.ForeignKey(
                        name: "FK_ModuleBData_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Links_ModuleAId",
                table: "Links",
                column: "ModuleAId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModuleAData_ModuleId",
                table: "ModuleAData",
                column: "ModuleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModuleBData_ModuleId",
                table: "ModuleBData",
                column: "ModuleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_ModuleAData_ModuleAId",
                table: "Links",
                column: "ModuleAId",
                principalTable: "ModuleAData",
                principalColumn: "ModuleAId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_ModuleBData_ModuleBId",
                table: "Links",
                column: "ModuleBId",
                principalTable: "ModuleBData",
                principalColumn: "ModuleBId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_ModuleAData_ModuleAId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_ModuleBData_ModuleBId",
                table: "Links");

            migrationBuilder.DropTable(
                name: "ModuleAData");

            migrationBuilder.DropTable(
                name: "ModuleBData");

            migrationBuilder.DropIndex(
                name: "IX_Links_ModuleAId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ModuleAId",
                table: "Links");

            migrationBuilder.RenameColumn(
                name: "ModuleBId",
                table: "Links",
                newName: "ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_Links_ModuleBId",
                table: "Links",
                newName: "IX_Links_ModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Modules_ModuleId",
                table: "Links",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
