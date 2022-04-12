using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class AddForeignLinkInitialDetailEntityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EntityModelId",
                table: "DetailRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DetailRecord_EntityModelId",
                table: "DetailRecord",
                column: "EntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_EntityModel_EntityModelId",
                table: "DetailRecord",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_EntityModel_EntityModelId",
                table: "DetailRecord");

            migrationBuilder.DropIndex(
                name: "IX_DetailRecord_EntityModelId",
                table: "DetailRecord");

            migrationBuilder.DropColumn(
                name: "EntityModelId",
                table: "DetailRecord");
        }
    }
}
