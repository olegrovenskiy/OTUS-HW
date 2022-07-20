using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Correct_Material : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialRecord_MaterialTable_InitialMaterialTableId",
                table: "MaterialRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialRecord_Operations_OperationId",
                table: "MaterialRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialTable_FileData_TableFileFileId",
                table: "MaterialTable");

            migrationBuilder.DropIndex(
                name: "IX_MaterialTable_TableFileFileId",
                table: "MaterialTable");

            migrationBuilder.DropIndex(
                name: "IX_MaterialRecord_InitialMaterialTableId",
                table: "MaterialRecord");

            migrationBuilder.DropColumn(
                name: "TableFileFileId",
                table: "MaterialTable");

            migrationBuilder.DropColumn(
                name: "InitialMaterialTableId",
                table: "MaterialRecord");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "MaterialTable",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "MaterialRecord",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "OperationId",
                table: "MaterialRecord",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "MaterialOfficialName",
                table: "MaterialRecord",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "MaterialRecord",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentNumber",
                table: "MaterialRecord",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DeliveryDate",
                table: "MaterialRecord",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "MaterialStorageItemId",
                table: "MaterialRecord",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MaterialStorageData",
                columns: table => new
                {
                    MaterialStorageItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemName = table.Column<string>(type: "text", nullable: true),
                    TakenQuantity = table.Column<int>(type: "integer", nullable: true),
                    CurrentQuantity = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialStorageData", x => x.MaterialStorageItemId);
                });

            migrationBuilder.CreateTable(
                name: "InitialMaterialTableDataMaterialStorageData",
                columns: table => new
                {
                    MaterialStorageRecordsMaterialStorageItemId = table.Column<int>(type: "integer", nullable: false),
                    MaterialTablesInitialMaterialTableId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InitialMaterialTableDataMaterialStorageData", x => new { x.MaterialStorageRecordsMaterialStorageItemId, x.MaterialTablesInitialMaterialTableId });
                    table.ForeignKey(
                        name: "FK_InitialMaterialTableDataMaterialStorageData_MaterialStorage~",
                        column: x => x.MaterialStorageRecordsMaterialStorageItemId,
                        principalTable: "MaterialStorageData",
                        principalColumn: "MaterialStorageItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialMaterialTableDataMaterialStorageData_MaterialTable_M~",
                        column: x => x.MaterialTablesInitialMaterialTableId,
                        principalTable: "MaterialTable",
                        principalColumn: "InitialMaterialTableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialTable_FileId",
                table: "MaterialTable",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRecord_MaterialStorageItemId",
                table: "MaterialRecord",
                column: "MaterialStorageItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialMaterialTableDataMaterialStorageData_MaterialTablesI~",
                table: "InitialMaterialTableDataMaterialStorageData",
                column: "MaterialTablesInitialMaterialTableId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialRecord_MaterialStorageData_MaterialStorageItemId",
                table: "MaterialRecord",
                column: "MaterialStorageItemId",
                principalTable: "MaterialStorageData",
                principalColumn: "MaterialStorageItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialRecord_Operations_OperationId",
                table: "MaterialRecord",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTable_FileData_FileId",
                table: "MaterialTable",
                column: "FileId",
                principalTable: "FileData",
                principalColumn: "FileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialRecord_MaterialStorageData_MaterialStorageItemId",
                table: "MaterialRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialRecord_Operations_OperationId",
                table: "MaterialRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialTable_FileData_FileId",
                table: "MaterialTable");

            migrationBuilder.DropTable(
                name: "InitialMaterialTableDataMaterialStorageData");

            migrationBuilder.DropTable(
                name: "MaterialStorageData");

            migrationBuilder.DropIndex(
                name: "IX_MaterialTable_FileId",
                table: "MaterialTable");

            migrationBuilder.DropIndex(
                name: "IX_MaterialRecord_MaterialStorageItemId",
                table: "MaterialRecord");

            migrationBuilder.DropColumn(
                name: "MaterialStorageItemId",
                table: "MaterialRecord");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "MaterialTable",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableFileFileId",
                table: "MaterialTable",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "MaterialRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OperationId",
                table: "MaterialRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaterialOfficialName",
                table: "MaterialRecord",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "MaterialRecord",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DocumentNumber",
                table: "MaterialRecord",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DeliveryDate",
                table: "MaterialRecord",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InitialMaterialTableId",
                table: "MaterialRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialTable_TableFileFileId",
                table: "MaterialTable",
                column: "TableFileFileId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRecord_InitialMaterialTableId",
                table: "MaterialRecord",
                column: "InitialMaterialTableId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialRecord_MaterialTable_InitialMaterialTableId",
                table: "MaterialRecord",
                column: "InitialMaterialTableId",
                principalTable: "MaterialTable",
                principalColumn: "InitialMaterialTableId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialRecord_Operations_OperationId",
                table: "MaterialRecord",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTable_FileData_TableFileFileId",
                table: "MaterialTable",
                column: "TableFileFileId",
                principalTable: "FileData",
                principalColumn: "FileId");
        }
    }
}
