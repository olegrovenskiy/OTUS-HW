using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class ChangeInitialRecords_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_DetailTable_InitialDetailTableId",
                table: "DetailRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_EntityModel_EntityModelId",
                table: "DetailRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_Operations_OperationId",
                table: "DetailRecord");

            migrationBuilder.DropColumn(
                name: "SnType",
                table: "DetailRecord");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "DetailRecord",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "DetailRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OperationId",
                table: "DetailRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "DetailRecord",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsSuccessfullyUploaded",
                table: "DetailRecord",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsSplittable",
                table: "DetailRecord",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InventoryNumber",
                table: "DetailRecord",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InitialDetailTableId",
                table: "DetailRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FactoryName",
                table: "DetailRecord",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EntityModelId",
                table: "DetailRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DetailOrigin",
                table: "DetailRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DetailOfficialName",
                table: "DetailRecord",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryYear",
                table: "DetailRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DeliveryDate",
                table: "DetailRecord",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "DetailRecord",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
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

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_DetailTable_InitialDetailTableId",
                table: "DetailRecord",
                column: "InitialDetailTableId",
                principalTable: "DetailTable",
                principalColumn: "InitialDetailTableId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_EntityModel_EntityModelId",
                table: "DetailRecord",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_Operations_OperationId",
                table: "DetailRecord",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_DetailTable_InitialDetailTableId",
                table: "DetailRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_EntityModel_EntityModelId",
                table: "DetailRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_Operations_OperationId",
                table: "DetailRecord");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "DetailRecord");

            migrationBuilder.DropColumn(
                name: "SnDefinitionType",
                table: "DetailRecord");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "DetailRecord",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "DetailRecord",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "OperationId",
                table: "DetailRecord",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "DetailRecord",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsSuccessfullyUploaded",
                table: "DetailRecord",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "IsSplittable",
                table: "DetailRecord",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "InventoryNumber",
                table: "DetailRecord",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "InitialDetailTableId",
                table: "DetailRecord",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "FactoryName",
                table: "DetailRecord",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "EntityModelId",
                table: "DetailRecord",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DetailOrigin",
                table: "DetailRecord",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "DetailOfficialName",
                table: "DetailRecord",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryYear",
                table: "DetailRecord",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DeliveryDate",
                table: "DetailRecord",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "DetailRecord",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "SnType",
                table: "DetailRecord",
                type: "text",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_DetailTable_InitialDetailTableId",
                table: "DetailRecord",
                column: "InitialDetailTableId",
                principalTable: "DetailTable",
                principalColumn: "InitialDetailTableId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_EntityModel_EntityModelId",
                table: "DetailRecord",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_Operations_OperationId",
                table: "DetailRecord",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "OperationId");
        }
    }
}
