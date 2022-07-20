using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Correct_Material_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InitialMaterialTableDataMaterialStorageData");

            migrationBuilder.CreateTable(
                name: "MaterialTableStorageLink",
                columns: table => new
                {
                    MaterialStorageItemId = table.Column<int>(type: "integer", nullable: false),
                    InitialMaterialTableId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialTableStorageLink", x => new { x.InitialMaterialTableId, x.MaterialStorageItemId });
                    table.ForeignKey(
                        name: "FK_MaterialTableStorageLink_MaterialTable_MaterialStorageItemId",
                        column: x => x.MaterialStorageItemId,
                        principalTable: "MaterialTable",
                        principalColumn: "InitialMaterialTableId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialTableStorageLink_StorageRecords_MaterialStorageItem~",
                        column: x => x.MaterialStorageItemId,
                        principalTable: "StorageRecords",
                        principalColumn: "MaterialStorageItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialTableStorageLink_MaterialStorageItemId",
                table: "MaterialTableStorageLink",
                column: "MaterialStorageItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialTableStorageLink");

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
                        name: "FK_InitialMaterialTableDataMaterialStorageData_MaterialTable_M~",
                        column: x => x.MaterialTablesInitialMaterialTableId,
                        principalTable: "MaterialTable",
                        principalColumn: "InitialMaterialTableId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialMaterialTableDataMaterialStorageData_StorageRecords_~",
                        column: x => x.MaterialStorageRecordsMaterialStorageItemId,
                        principalTable: "StorageRecords",
                        principalColumn: "MaterialStorageItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InitialMaterialTableDataMaterialStorageData_MaterialTablesI~",
                table: "InitialMaterialTableDataMaterialStorageData",
                column: "MaterialTablesInitialMaterialTableId");
        }
    }
}
