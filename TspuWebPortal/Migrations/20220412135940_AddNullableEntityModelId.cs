using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class AddNullableEntityModelId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_EntityModel_EntityModelId",
                table: "DetailRecord");

            migrationBuilder.AlterColumn<int>(
                name: "EntityModelId",
                table: "DetailRecord",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_EntityModel_EntityModelId",
                table: "DetailRecord",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_EntityModel_EntityModelId",
                table: "DetailRecord");

            migrationBuilder.AlterColumn<int>(
                name: "EntityModelId",
                table: "DetailRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_EntityModel_EntityModelId",
                table: "DetailRecord",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
