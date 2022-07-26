using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Minor_15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialOperations_StorageRecords_StorageItemId",
                table: "MaterialOperations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialTableStorageLink_StorageRecords_MaterialStorageData~",
                table: "MaterialTableStorageLink");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageRecords_DataCenters_DataCenterId",
                table: "StorageRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageRecords_MaterialEntityModels_MaterialEntityModelId",
                table: "StorageRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorageRecords",
                table: "StorageRecords");

            migrationBuilder.RenameTable(
                name: "StorageRecords",
                newName: "MaterialStorageRecords");

            migrationBuilder.RenameIndex(
                name: "IX_StorageRecords_MaterialEntityModelId",
                table: "MaterialStorageRecords",
                newName: "IX_MaterialStorageRecords_MaterialEntityModelId");

            migrationBuilder.RenameIndex(
                name: "IX_StorageRecords_DataCenterId",
                table: "MaterialStorageRecords",
                newName: "IX_MaterialStorageRecords_DataCenterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialStorageRecords",
                table: "MaterialStorageRecords",
                column: "StorageItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialOperations_MaterialStorageRecords_StorageItemId",
                table: "MaterialOperations",
                column: "StorageItemId",
                principalTable: "MaterialStorageRecords",
                principalColumn: "StorageItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialStorageRecords_DataCenters_DataCenterId",
                table: "MaterialStorageRecords",
                column: "DataCenterId",
                principalTable: "DataCenters",
                principalColumn: "DataCenterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialStorageRecords_MaterialEntityModels_MaterialEntityM~",
                table: "MaterialStorageRecords",
                column: "MaterialEntityModelId",
                principalTable: "MaterialEntityModels",
                principalColumn: "MaterialEntityModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTableStorageLink_MaterialStorageRecords_MaterialSto~",
                table: "MaterialTableStorageLink",
                column: "MaterialStorageDataStorageItemId",
                principalTable: "MaterialStorageRecords",
                principalColumn: "StorageItemId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialOperations_MaterialStorageRecords_StorageItemId",
                table: "MaterialOperations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialStorageRecords_DataCenters_DataCenterId",
                table: "MaterialStorageRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialStorageRecords_MaterialEntityModels_MaterialEntityM~",
                table: "MaterialStorageRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialTableStorageLink_MaterialStorageRecords_MaterialSto~",
                table: "MaterialTableStorageLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialStorageRecords",
                table: "MaterialStorageRecords");

            migrationBuilder.RenameTable(
                name: "MaterialStorageRecords",
                newName: "StorageRecords");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialStorageRecords_MaterialEntityModelId",
                table: "StorageRecords",
                newName: "IX_StorageRecords_MaterialEntityModelId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialStorageRecords_DataCenterId",
                table: "StorageRecords",
                newName: "IX_StorageRecords_DataCenterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorageRecords",
                table: "StorageRecords",
                column: "StorageItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialOperations_StorageRecords_StorageItemId",
                table: "MaterialOperations",
                column: "StorageItemId",
                principalTable: "StorageRecords",
                principalColumn: "StorageItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTableStorageLink_StorageRecords_MaterialStorageData~",
                table: "MaterialTableStorageLink",
                column: "MaterialStorageDataStorageItemId",
                principalTable: "StorageRecords",
                principalColumn: "StorageItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StorageRecords_DataCenters_DataCenterId",
                table: "StorageRecords",
                column: "DataCenterId",
                principalTable: "DataCenters",
                principalColumn: "DataCenterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StorageRecords_MaterialEntityModels_MaterialEntityModelId",
                table: "StorageRecords",
                column: "MaterialEntityModelId",
                principalTable: "MaterialEntityModels",
                principalColumn: "MaterialEntityModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
