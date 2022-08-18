using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Minor_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_EntityModel_EntityModelId",
                table: "DetailRecord");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "DetailRecord");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "DetailRecord");

            migrationBuilder.RenameColumn(
                name: "EntityModelId",
                table: "DetailRecord",
                newName: "SpecaModelId");

            migrationBuilder.RenameIndex(
                name: "IX_DetailRecord_EntityModelId",
                table: "DetailRecord",
                newName: "IX_DetailRecord_SpecaModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_SpecificationRecords_SpecaModelId",
                table: "DetailRecord",
                column: "SpecaModelId",
                principalTable: "SpecificationRecords",
                principalColumn: "SpecItemId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_SpecificationRecords_SpecaModelId",
                table: "DetailRecord");

            migrationBuilder.RenameColumn(
                name: "SpecaModelId",
                table: "DetailRecord",
                newName: "EntityModelId");

            migrationBuilder.RenameIndex(
                name: "IX_DetailRecord_SpecaModelId",
                table: "DetailRecord",
                newName: "IX_DetailRecord_EntityModelId");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "DetailRecord",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DeliveryDate",
                table: "DetailRecord",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

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
