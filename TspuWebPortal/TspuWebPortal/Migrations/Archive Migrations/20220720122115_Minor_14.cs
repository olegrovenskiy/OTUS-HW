using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Minor_14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cables_DetailRecord_InitialDetailRecordId",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_DetailRecord_InitialDetailRecordId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_DetailRecord_InitialDetailRecordId",
                table: "Chassis");

            migrationBuilder.DropForeignKey(
                name: "FK_CompletionRequests_Operations_OperationId",
                table: "CompletionRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CreationRequests_Operations_OperationId",
                table: "CreationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_DetailRecord_InitialDetailRecordId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialTable_FileData_FileId",
                table: "MaterialTable");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialTableStorageLink_StorageRecords_MaterialStorageItem~",
                table: "MaterialTableStorageLink");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_DetailRecord_InitialDetailRecordId",
                table: "Modules");

            migrationBuilder.DropTable(
                name: "DetailRecord");

            migrationBuilder.DropTable(
                name: "MaterialRecord");

            migrationBuilder.DropTable(
                name: "DetailTable");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorageRecords",
                table: "StorageRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileData",
                table: "FileData");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "StorageRecords");

            migrationBuilder.RenameTable(
                name: "FileData",
                newName: "Files");

            migrationBuilder.RenameColumn(
                name: "MaterialStorageItemId",
                table: "StorageRecords",
                newName: "MaterialEntityModelId");

            migrationBuilder.AlterColumn<int>(
                name: "TakenQuantity",
                table: "StorageRecords",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrentQuantity",
                table: "StorageRecords",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaterialEntityModelId",
                table: "StorageRecords",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "StorageItemId",
                table: "StorageRecords",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "DataCenterId",
                table: "StorageRecords",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryYear",
                table: "StorageRecords",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstalledQuantity",
                table: "StorageRecords",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MaterialSpecificationName",
                table: "StorageRecords",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MaterialOperationDataMaterialOperationId",
                table: "MaterialTableStorageLink",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaterialStorageDataStorageItemId",
                table: "MaterialTableStorageLink",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateOnly>(
                name: "RegisterDate",
                table: "MaterialTable",
                type: "date",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorageRecords",
                table: "StorageRecords",
                column: "StorageItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                column: "FileId");

            migrationBuilder.CreateTable(
                name: "DetailTables",
                columns: table => new
                {
                    InitialDetailTableId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileId = table.Column<int>(type: "integer", nullable: true),
                    RegisterDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailTables", x => x.InitialDetailTableId);
                    table.ForeignKey(
                        name: "FK_DetailTables_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "FileId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialEntityModels",
                columns: table => new
                {
                    MaterialEntityModelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaterialModelName = table.Column<string>(type: "text", nullable: false),
                    MaterialModelType = table.Column<string>(type: "text", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialEntityModels", x => x.MaterialEntityModelId);
                });

            migrationBuilder.CreateTable(
                name: "OperationSummary",
                columns: table => new
                {
                    GlobalOperationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OperationDate = table.Column<DateOnly>(type: "date", nullable: true),
                    OperationType = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    UserListAccountId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationSummary", x => x.GlobalOperationId);
                    table.ForeignKey(
                        name: "FK_OperationSummary_UserAccounts_UserListAccountId",
                        column: x => x.UserListAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "AccountId");
                });

            migrationBuilder.CreateTable(
                name: "DetailRecords",
                columns: table => new
                {
                    DetailRecordId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DetailOrigin = table.Column<int>(type: "integer", nullable: false),
                    ContractNumber = table.Column<string>(type: "text", nullable: true),
                    ResponsiblePerson = table.Column<string>(type: "text", nullable: true),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    InitialDetailTableId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    DetailOfficialName = table.Column<string>(type: "text", nullable: false),
                    InventoryNumber = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    IsSplittable = table.Column<bool>(type: "boolean", nullable: false),
                    IsSuccessfullyUploaded = table.Column<bool>(type: "boolean", nullable: false),
                    SpecDetailId = table.Column<int>(type: "integer", nullable: false),
                    IsVisibleInExcel = table.Column<bool>(type: "boolean", nullable: false),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    IsExcludedFromPrint = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailRecords", x => x.DetailRecordId);
                    table.ForeignKey(
                        name: "FK_DetailRecords_DetailTables_InitialDetailTableId",
                        column: x => x.InitialDetailTableId,
                        principalTable: "DetailTables",
                        principalColumn: "InitialDetailTableId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailRecords_SpecificationRecords_SpecDetailId",
                        column: x => x.SpecDetailId,
                        principalTable: "SpecificationRecords",
                        principalColumn: "SpecDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialOperations",
                columns: table => new
                {
                    MaterialOperationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OperationSubtype = table.Column<string>(type: "text", nullable: false),
                    StorageItemId = table.Column<int>(type: "integer", nullable: false),
                    GlobalOperationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialOperations", x => x.MaterialOperationId);
                    table.ForeignKey(
                        name: "FK_MaterialOperations_OperationSummary_GlobalOperationId",
                        column: x => x.GlobalOperationId,
                        principalTable: "OperationSummary",
                        principalColumn: "GlobalOperationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialOperations_StorageRecords_StorageItemId",
                        column: x => x.StorageItemId,
                        principalTable: "StorageRecords",
                        principalColumn: "StorageItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailOperations",
                columns: table => new
                {
                    DetailOperationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OperationSubtype = table.Column<string>(type: "text", nullable: false),
                    DetailRecordId = table.Column<int>(type: "integer", nullable: false),
                    GlobalOperationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailOperations", x => x.DetailOperationId);
                    table.ForeignKey(
                        name: "FK_DetailOperations_DetailRecords_DetailRecordId",
                        column: x => x.DetailRecordId,
                        principalTable: "DetailRecords",
                        principalColumn: "DetailRecordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailOperations_OperationSummary_GlobalOperationId",
                        column: x => x.GlobalOperationId,
                        principalTable: "OperationSummary",
                        principalColumn: "GlobalOperationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StorageRecords_DataCenterId",
                table: "StorageRecords",
                column: "DataCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageRecords_MaterialEntityModelId",
                table: "StorageRecords",
                column: "MaterialEntityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialTableStorageLink_MaterialOperationDataMaterialOpera~",
                table: "MaterialTableStorageLink",
                column: "MaterialOperationDataMaterialOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialTableStorageLink_MaterialStorageDataStorageItemId",
                table: "MaterialTableStorageLink",
                column: "MaterialStorageDataStorageItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOperations_DetailRecordId",
                table: "DetailOperations",
                column: "DetailRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOperations_GlobalOperationId",
                table: "DetailOperations",
                column: "GlobalOperationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetailRecords_InitialDetailTableId",
                table: "DetailRecords",
                column: "InitialDetailTableId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailRecords_SpecDetailId",
                table: "DetailRecords",
                column: "SpecDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTables_FileId",
                table: "DetailTables",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialOperations_GlobalOperationId",
                table: "MaterialOperations",
                column: "GlobalOperationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialOperations_StorageItemId",
                table: "MaterialOperations",
                column: "StorageItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationSummary_UserListAccountId",
                table: "OperationSummary",
                column: "UserListAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_DetailRecords_InitialDetailRecordId",
                table: "Cables",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecords",
                principalColumn: "DetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_DetailRecords_InitialDetailRecordId",
                table: "Cards",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecords",
                principalColumn: "DetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_DetailRecords_InitialDetailRecordId",
                table: "Chassis",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecords",
                principalColumn: "DetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompletionRequests_OperationSummary_OperationId",
                table: "CompletionRequests",
                column: "OperationId",
                principalTable: "OperationSummary",
                principalColumn: "GlobalOperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreationRequests_OperationSummary_OperationId",
                table: "CreationRequests",
                column: "OperationId",
                principalTable: "OperationSummary",
                principalColumn: "GlobalOperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_DetailRecords_InitialDetailRecordId",
                table: "Licenses",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecords",
                principalColumn: "DetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTable_Files_FileId",
                table: "MaterialTable",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTableStorageLink_MaterialOperations_MaterialOperati~",
                table: "MaterialTableStorageLink",
                column: "MaterialOperationDataMaterialOperationId",
                principalTable: "MaterialOperations",
                principalColumn: "MaterialOperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTableStorageLink_StorageRecords_MaterialStorageData~",
                table: "MaterialTableStorageLink",
                column: "MaterialStorageDataStorageItemId",
                principalTable: "StorageRecords",
                principalColumn: "StorageItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_DetailRecords_InitialDetailRecordId",
                table: "Modules",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecords",
                principalColumn: "DetailRecordId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cables_DetailRecords_InitialDetailRecordId",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_DetailRecords_InitialDetailRecordId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_DetailRecords_InitialDetailRecordId",
                table: "Chassis");

            migrationBuilder.DropForeignKey(
                name: "FK_CompletionRequests_OperationSummary_OperationId",
                table: "CompletionRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CreationRequests_OperationSummary_OperationId",
                table: "CreationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_DetailRecords_InitialDetailRecordId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialTable_Files_FileId",
                table: "MaterialTable");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialTableStorageLink_MaterialOperations_MaterialOperati~",
                table: "MaterialTableStorageLink");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialTableStorageLink_StorageRecords_MaterialStorageData~",
                table: "MaterialTableStorageLink");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_DetailRecords_InitialDetailRecordId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageRecords_DataCenters_DataCenterId",
                table: "StorageRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageRecords_MaterialEntityModels_MaterialEntityModelId",
                table: "StorageRecords");

            migrationBuilder.DropTable(
                name: "DetailOperations");

            migrationBuilder.DropTable(
                name: "MaterialEntityModels");

            migrationBuilder.DropTable(
                name: "MaterialOperations");

            migrationBuilder.DropTable(
                name: "DetailRecords");

            migrationBuilder.DropTable(
                name: "OperationSummary");

            migrationBuilder.DropTable(
                name: "DetailTables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorageRecords",
                table: "StorageRecords");

            migrationBuilder.DropIndex(
                name: "IX_StorageRecords_DataCenterId",
                table: "StorageRecords");

            migrationBuilder.DropIndex(
                name: "IX_StorageRecords_MaterialEntityModelId",
                table: "StorageRecords");

            migrationBuilder.DropIndex(
                name: "IX_MaterialTableStorageLink_MaterialOperationDataMaterialOpera~",
                table: "MaterialTableStorageLink");

            migrationBuilder.DropIndex(
                name: "IX_MaterialTableStorageLink_MaterialStorageDataStorageItemId",
                table: "MaterialTableStorageLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "StorageItemId",
                table: "StorageRecords");

            migrationBuilder.DropColumn(
                name: "DataCenterId",
                table: "StorageRecords");

            migrationBuilder.DropColumn(
                name: "DeliveryYear",
                table: "StorageRecords");

            migrationBuilder.DropColumn(
                name: "InstalledQuantity",
                table: "StorageRecords");

            migrationBuilder.DropColumn(
                name: "MaterialSpecificationName",
                table: "StorageRecords");

            migrationBuilder.DropColumn(
                name: "MaterialOperationDataMaterialOperationId",
                table: "MaterialTableStorageLink");

            migrationBuilder.DropColumn(
                name: "MaterialStorageDataStorageItemId",
                table: "MaterialTableStorageLink");

            migrationBuilder.DropColumn(
                name: "RegisterDate",
                table: "MaterialTable");

            migrationBuilder.RenameTable(
                name: "Files",
                newName: "FileData");

            migrationBuilder.RenameColumn(
                name: "MaterialEntityModelId",
                table: "StorageRecords",
                newName: "MaterialStorageItemId");

            migrationBuilder.AlterColumn<int>(
                name: "TakenQuantity",
                table: "StorageRecords",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentQuantity",
                table: "StorageRecords",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "MaterialStorageItemId",
                table: "StorageRecords",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "StorageRecords",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorageRecords",
                table: "StorageRecords",
                column: "MaterialStorageItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileData",
                table: "FileData",
                column: "FileId");

            migrationBuilder.CreateTable(
                name: "DetailTable",
                columns: table => new
                {
                    InitialDetailTableId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileId = table.Column<int>(type: "integer", nullable: true),
                    RegisterDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailTable", x => x.InitialDetailTableId);
                    table.ForeignKey(
                        name: "FK_DetailTable_FileData_FileId",
                        column: x => x.FileId,
                        principalTable: "FileData",
                        principalColumn: "FileId");
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    OperationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserListAccountId = table.Column<int>(type: "integer", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    OperationDate = table.Column<DateOnly>(type: "date", nullable: true),
                    OperationType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.OperationId);
                    table.ForeignKey(
                        name: "FK_Operations_UserAccounts_UserListAccountId",
                        column: x => x.UserListAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "AccountId");
                });

            migrationBuilder.CreateTable(
                name: "DetailRecord",
                columns: table => new
                {
                    InitialDetailRecordId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InitialDetailTableId = table.Column<int>(type: "integer", nullable: false),
                    OperationId = table.Column<int>(type: "integer", nullable: false),
                    SpecDetailId = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    ContractNumber = table.Column<string>(type: "text", nullable: true),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    DetailOfficialName = table.Column<string>(type: "text", nullable: false),
                    DetailOrigin = table.Column<int>(type: "integer", nullable: false),
                    InventoryNumber = table.Column<string>(type: "text", nullable: false),
                    IsExcludedFromPrint = table.Column<bool>(type: "boolean", nullable: false),
                    IsSplittable = table.Column<bool>(type: "boolean", nullable: false),
                    IsSuccessfullyUploaded = table.Column<bool>(type: "boolean", nullable: false),
                    IsVisibleInExcel = table.Column<bool>(type: "boolean", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    ResponsiblePerson = table.Column<string>(type: "text", nullable: true),
                    SerialNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailRecord", x => x.InitialDetailRecordId);
                    table.ForeignKey(
                        name: "FK_DetailRecord_DetailTable_InitialDetailTableId",
                        column: x => x.InitialDetailTableId,
                        principalTable: "DetailTable",
                        principalColumn: "InitialDetailTableId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailRecord_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "OperationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailRecord_SpecificationRecords_SpecDetailId",
                        column: x => x.SpecDetailId,
                        principalTable: "SpecificationRecords",
                        principalColumn: "SpecDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialRecord",
                columns: table => new
                {
                    InitialMaterialId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaterialStorageItemId = table.Column<int>(type: "integer", nullable: true),
                    OperationId = table.Column<int>(type: "integer", nullable: true),
                    DeliveryDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DocumentNumber = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    MaterialOfficialName = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialRecord", x => x.InitialMaterialId);
                    table.ForeignKey(
                        name: "FK_MaterialRecord_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "OperationId");
                    table.ForeignKey(
                        name: "FK_MaterialRecord_StorageRecords_MaterialStorageItemId",
                        column: x => x.MaterialStorageItemId,
                        principalTable: "StorageRecords",
                        principalColumn: "MaterialStorageItemId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailRecord_InitialDetailTableId",
                table: "DetailRecord",
                column: "InitialDetailTableId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailRecord_OperationId",
                table: "DetailRecord",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailRecord_SpecDetailId",
                table: "DetailRecord",
                column: "SpecDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTable_FileId",
                table: "DetailTable",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRecord_MaterialStorageItemId",
                table: "MaterialRecord",
                column: "MaterialStorageItemId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRecord_OperationId",
                table: "MaterialRecord",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_UserListAccountId",
                table: "Operations",
                column: "UserListAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_DetailRecord_InitialDetailRecordId",
                table: "Cables",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_DetailRecord_InitialDetailRecordId",
                table: "Cards",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_DetailRecord_InitialDetailRecordId",
                table: "Chassis",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompletionRequests_Operations_OperationId",
                table: "CompletionRequests",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreationRequests_Operations_OperationId",
                table: "CreationRequests",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_DetailRecord_InitialDetailRecordId",
                table: "Licenses",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTable_FileData_FileId",
                table: "MaterialTable",
                column: "FileId",
                principalTable: "FileData",
                principalColumn: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTableStorageLink_StorageRecords_MaterialStorageItem~",
                table: "MaterialTableStorageLink",
                column: "MaterialStorageItemId",
                principalTable: "StorageRecords",
                principalColumn: "MaterialStorageItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_DetailRecord_InitialDetailRecordId",
                table: "Modules",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
