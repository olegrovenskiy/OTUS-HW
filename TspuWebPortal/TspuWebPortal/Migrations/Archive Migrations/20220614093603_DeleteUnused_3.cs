using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class DeleteUnused_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cables_EntityModel_EntityModelDataEntityModelId",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_EntityModel_EntityModelDataEntityModelId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_EntityModel_EntityModelDataEntityModelId",
                table: "Chassis");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_EntityModel_EntityModelId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_EntityModel_EntityModelDataEntityModelId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_EntityModelDataEntityModelId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Licenses_EntityModelId",
                table: "Licenses");

            migrationBuilder.DropIndex(
                name: "IX_Chassis_EntityModelDataEntityModelId",
                table: "Chassis");

            migrationBuilder.DropIndex(
                name: "IX_Cards_EntityModelDataEntityModelId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cables_EntityModelDataEntityModelId",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "EntityModelDataEntityModelId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "EntityModelId",
                table: "Licenses");

            migrationBuilder.DropColumn(
                name: "EntityModelDataEntityModelId",
                table: "Chassis");

            migrationBuilder.DropColumn(
                name: "EntityModelDataEntityModelId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "EntityModelDataEntityModelId",
                table: "Cables");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EntityModelDataEntityModelId",
                table: "Modules",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityModelId",
                table: "Licenses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityModelDataEntityModelId",
                table: "Chassis",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityModelDataEntityModelId",
                table: "Cards",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityModelDataEntityModelId",
                table: "Cables",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modules_EntityModelDataEntityModelId",
                table: "Modules",
                column: "EntityModelDataEntityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_EntityModelId",
                table: "Licenses",
                column: "EntityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_EntityModelDataEntityModelId",
                table: "Chassis",
                column: "EntityModelDataEntityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_EntityModelDataEntityModelId",
                table: "Cards",
                column: "EntityModelDataEntityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cables_EntityModelDataEntityModelId",
                table: "Cables",
                column: "EntityModelDataEntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_EntityModel_EntityModelDataEntityModelId",
                table: "Cables",
                column: "EntityModelDataEntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_EntityModel_EntityModelId",
                table: "Licenses",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_EntityModel_EntityModelDataEntityModelId",
                table: "Modules",
                column: "EntityModelDataEntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");
        }
    }
}
