using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Correct_Material_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitialMaterialTableDataMaterialStorageData_MaterialStorage~",
                table: "InitialMaterialTableDataMaterialStorageData");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialRecord_MaterialStorageData_MaterialStorageItemId",
                table: "MaterialRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialStorageData",
                table: "MaterialStorageData");

            migrationBuilder.RenameTable(
                name: "MaterialStorageData",
                newName: "StorageRecords");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorageRecords",
                table: "StorageRecords",
                column: "MaterialStorageItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_InitialMaterialTableDataMaterialStorageData_StorageRecords_~",
                table: "InitialMaterialTableDataMaterialStorageData",
                column: "MaterialStorageRecordsMaterialStorageItemId",
                principalTable: "StorageRecords",
                principalColumn: "MaterialStorageItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialRecord_StorageRecords_MaterialStorageItemId",
                table: "MaterialRecord",
                column: "MaterialStorageItemId",
                principalTable: "StorageRecords",
                principalColumn: "MaterialStorageItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitialMaterialTableDataMaterialStorageData_StorageRecords_~",
                table: "InitialMaterialTableDataMaterialStorageData");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialRecord_StorageRecords_MaterialStorageItemId",
                table: "MaterialRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorageRecords",
                table: "StorageRecords");

            migrationBuilder.RenameTable(
                name: "StorageRecords",
                newName: "MaterialStorageData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialStorageData",
                table: "MaterialStorageData",
                column: "MaterialStorageItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_InitialMaterialTableDataMaterialStorageData_MaterialStorage~",
                table: "InitialMaterialTableDataMaterialStorageData",
                column: "MaterialStorageRecordsMaterialStorageItemId",
                principalTable: "MaterialStorageData",
                principalColumn: "MaterialStorageItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialRecord_MaterialStorageData_MaterialStorageItemId",
                table: "MaterialRecord",
                column: "MaterialStorageItemId",
                principalTable: "MaterialStorageData",
                principalColumn: "MaterialStorageItemId");
        }
    }
}
