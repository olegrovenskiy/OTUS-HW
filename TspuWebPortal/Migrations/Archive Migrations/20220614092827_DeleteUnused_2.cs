using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class DeleteUnused_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_EntityModel_EntityModelId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_EntityModel_EntityModelId",
                table: "Chassis");

            migrationBuilder.RenameColumn(
                name: "EntityModelId",
                table: "Chassis",
                newName: "EntityModelDataEntityModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Chassis_EntityModelId",
                table: "Chassis",
                newName: "IX_Chassis_EntityModelDataEntityModelId");

            migrationBuilder.RenameColumn(
                name: "EntityModelId",
                table: "Cards",
                newName: "EntityModelDataEntityModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_EntityModelId",
                table: "Cards",
                newName: "IX_Cards_EntityModelDataEntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_EntityModel_EntityModelDataEntityModelId",
                table: "Cards",
                column: "EntityModelDataEntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_EntityModel_EntityModelDataEntityModelId",
                table: "Chassis",
                column: "EntityModelDataEntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_EntityModel_EntityModelDataEntityModelId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_EntityModel_EntityModelDataEntityModelId",
                table: "Chassis");

            migrationBuilder.RenameColumn(
                name: "EntityModelDataEntityModelId",
                table: "Chassis",
                newName: "EntityModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Chassis_EntityModelDataEntityModelId",
                table: "Chassis",
                newName: "IX_Chassis_EntityModelId");

            migrationBuilder.RenameColumn(
                name: "EntityModelDataEntityModelId",
                table: "Cards",
                newName: "EntityModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_EntityModelDataEntityModelId",
                table: "Cards",
                newName: "IX_Cards_EntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_EntityModel_EntityModelId",
                table: "Cards",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_EntityModel_EntityModelId",
                table: "Chassis",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");
        }
    }
}
