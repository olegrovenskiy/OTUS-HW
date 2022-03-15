using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations.DcDb
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataCenters",
                columns: table => new
                {
                    DataCenterId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataCenterName = table.Column<string>(type: "text", nullable: false),
                    DataCenterAddress = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCenters", x => x.DataCenterId);
                });

            migrationBuilder.CreateTable(
                name: "EntityModel",
                columns: table => new
                {
                    EntityModelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModelName = table.Column<string>(type: "text", nullable: false),
                    PartNumber = table.Column<string>(type: "text", nullable: false),
                    ModelType = table.Column<string>(type: "text", nullable: false),
                    Vendor = table.Column<string>(type: "text", nullable: false),
                    NominalPower = table.Column<int>(type: "integer", nullable: false),
                    MaximalPower = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityModel", x => x.EntityModelId);
                });

            migrationBuilder.CreateTable(
                name: "FileData",
                columns: table => new
                {
                    FileId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    UploadDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LastChangeDate = table.Column<DateOnly>(type: "date", nullable: false),
                    FilePath = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileData", x => x.FileId);
                });

            migrationBuilder.CreateTable(
                name: "ServerSlots",
                columns: table => new
                {
                    ServerSlotId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UnitId = table.Column<int>(type: "integer", nullable: false),
                    SlotIndex = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerSlots", x => x.ServerSlotId);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullPersonName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoomName = table.Column<string>(type: "text", nullable: false),
                    RoomCoordinates = table.Column<string>(type: "text", nullable: false),
                    DataCenterId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_DataCenters_DataCenterId",
                        column: x => x.DataCenterId,
                        principalTable: "DataCenters",
                        principalColumn: "DataCenterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailTable",
                columns: table => new
                {
                    InitialDetailTableId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TableFileFileId = table.Column<int>(type: "integer", nullable: true),
                    FileId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailTable", x => x.InitialDetailTableId);
                    table.ForeignKey(
                        name: "FK_DetailTable_FileData_TableFileFileId",
                        column: x => x.TableFileFileId,
                        principalTable: "FileData",
                        principalColumn: "FileId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialTable",
                columns: table => new
                {
                    InitialMaterialTableId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TableFileFileId = table.Column<int>(type: "integer", nullable: true),
                    FileId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialTable", x => x.InitialMaterialTableId);
                    table.ForeignKey(
                        name: "FK_MaterialTable_FileData_TableFileFileId",
                        column: x => x.TableFileFileId,
                        principalTable: "FileData",
                        principalColumn: "FileId");
                });

            migrationBuilder.CreateTable(
                name: "ServerLinks",
                columns: table => new
                {
                    ServerLinkId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServerTypeId = table.Column<int>(type: "integer", nullable: false),
                    ServerSlotId = table.Column<int>(type: "integer", nullable: false),
                    ServerSlotsServerSlotId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerLinks", x => x.ServerLinkId);
                    table.ForeignKey(
                        name: "FK_ServerLinks_ServerSlots_ServerSlotsServerSlotId",
                        column: x => x.ServerSlotsServerSlotId,
                        principalTable: "ServerSlots",
                        principalColumn: "ServerSlotId");
                });

            migrationBuilder.CreateTable(
                name: "OperationData",
                columns: table => new
                {
                    OperationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OperationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    OperationType = table.Column<string>(type: "text", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: false),
                    UserListAccountId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationData", x => x.OperationId);
                    table.ForeignKey(
                        name: "FK_OperationData_UserAccounts_UserListAccountId",
                        column: x => x.UserListAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "AccountId");
                });

            migrationBuilder.CreateTable(
                name: "Rows",
                columns: table => new
                {
                    RowId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RowNameAsbi = table.Column<string>(type: "text", nullable: false),
                    RowNameDataCenter = table.Column<string>(type: "text", nullable: false),
                    RoomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rows", x => x.RowId);
                    table.ForeignKey(
                        name: "FK_Rows_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompletionRequests",
                columns: table => new
                {
                    RequestCompletionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OperationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletionRequests", x => x.RequestCompletionId);
                    table.ForeignKey(
                        name: "FK_CompletionRequests_OperationData_OperationId",
                        column: x => x.OperationId,
                        principalTable: "OperationData",
                        principalColumn: "OperationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreationRequests",
                columns: table => new
                {
                    RequestCreationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OperationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreationRequests", x => x.RequestCreationId);
                    table.ForeignKey(
                        name: "FK_CreationRequests_OperationData_OperationId",
                        column: x => x.OperationId,
                        principalTable: "OperationData",
                        principalColumn: "OperationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailRecord",
                columns: table => new
                {
                    InitialDetailRecordId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DetailOrigin = table.Column<string>(type: "text", nullable: false),
                    InitialDetailTableId = table.Column<int>(type: "integer", nullable: false),
                    DocumentNumber = table.Column<string>(type: "text", nullable: false),
                    ResponsiblePerson = table.Column<string>(type: "text", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    DetailOfficialName = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    DeliveryDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    IsSplittable = table.Column<bool>(type: "boolean", nullable: false),
                    OperationId = table.Column<int>(type: "integer", nullable: false),
                    IsSuccessfullyUploaded = table.Column<bool>(type: "boolean", nullable: false)
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
                        name: "FK_DetailRecord_OperationData_OperationId",
                        column: x => x.OperationId,
                        principalTable: "OperationData",
                        principalColumn: "OperationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialRecord",
                columns: table => new
                {
                    InitialMaterialId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InitialMaterialTableId = table.Column<int>(type: "integer", nullable: false),
                    DocumentNumber = table.Column<string>(type: "text", nullable: false),
                    MaterialOfficialName = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    DeliveryDate = table.Column<DateOnly>(type: "date", nullable: false),
                    OperationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialRecord", x => x.InitialMaterialId);
                    table.ForeignKey(
                        name: "FK_MaterialRecord_MaterialTable_InitialMaterialTableId",
                        column: x => x.InitialMaterialTableId,
                        principalTable: "MaterialTable",
                        principalColumn: "InitialMaterialTableId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialRecord_OperationData_OperationId",
                        column: x => x.OperationId,
                        principalTable: "OperationData",
                        principalColumn: "OperationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Racks",
                columns: table => new
                {
                    RackId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RackNameAsbi = table.Column<string>(type: "text", nullable: false),
                    RackNameDataCenter = table.Column<string>(type: "text", nullable: false),
                    RackHeight = table.Column<int>(type: "integer", nullable: false),
                    FreeServerSlotsQuantity = table.Column<int>(type: "integer", nullable: false),
                    IsInstalled = table.Column<bool>(type: "boolean", nullable: false),
                    InstallationYear = table.Column<int>(type: "integer", nullable: false),
                    RackType = table.Column<string>(type: "text", nullable: false),
                    RowId = table.Column<int>(type: "integer", nullable: false),
                    RoomRowId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racks", x => x.RackId);
                    table.ForeignKey(
                        name: "FK_Racks_Rows_RoomRowId",
                        column: x => x.RoomRowId,
                        principalTable: "Rows",
                        principalColumn: "RowId");
                });

            migrationBuilder.CreateTable(
                name: "DetailChange",
                columns: table => new
                {
                    DetailChangeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JiraApplicationId = table.Column<int>(type: "integer", nullable: false),
                    ResponsiblePerson = table.Column<string>(type: "text", nullable: false),
                    ChangeReason = table.Column<string>(type: "text", nullable: false),
                    SnOldDetail = table.Column<string>(type: "text", nullable: false),
                    SnNewDetail = table.Column<string>(type: "text", nullable: false),
                    ApplicationStatus = table.Column<string>(type: "text", nullable: false),
                    CompleteChangeDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsInstalled = table.Column<bool>(type: "boolean", nullable: false),
                    RequestCreationId = table.Column<int>(type: "integer", nullable: false),
                    RequestCompletionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailChange", x => x.DetailChangeId);
                    table.ForeignKey(
                        name: "FK_DetailChange_CompletionRequests_RequestCompletionId",
                        column: x => x.RequestCompletionId,
                        principalTable: "CompletionRequests",
                        principalColumn: "RequestCompletionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailChange_CreationRequests_RequestCreationId",
                        column: x => x.RequestCreationId,
                        principalTable: "CreationRequests",
                        principalColumn: "RequestCreationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    LicenseId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SnType = table.Column<string>(type: "text", nullable: false),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    InitialDetailRecordId = table.Column<int>(type: "integer", nullable: false),
                    EntityModelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.LicenseId);
                    table.ForeignKey(
                        name: "FK_Licenses_DetailRecord_InitialDetailRecordId",
                        column: x => x.InitialDetailRecordId,
                        principalTable: "DetailRecord",
                        principalColumn: "InitialDetailRecordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Licenses_EntityModel_EntityModelId",
                        column: x => x.EntityModelId,
                        principalTable: "EntityModel",
                        principalColumn: "EntityModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cables",
                columns: table => new
                {
                    CableId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SnType = table.Column<string>(type: "text", nullable: false),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    InitialDetailRecordId = table.Column<int>(type: "integer", nullable: false),
                    DetailChangeId = table.Column<int>(type: "integer", nullable: false),
                    InventoryNumber = table.Column<string>(type: "text", nullable: false),
                    IsInstalled = table.Column<bool>(type: "boolean", nullable: false),
                    EntityModelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cables", x => x.CableId);
                    table.ForeignKey(
                        name: "FK_Cables_DetailChange_DetailChangeId",
                        column: x => x.DetailChangeId,
                        principalTable: "DetailChange",
                        principalColumn: "DetailChangeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cables_DetailRecord_InitialDetailRecordId",
                        column: x => x.InitialDetailRecordId,
                        principalTable: "DetailRecord",
                        principalColumn: "InitialDetailRecordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cables_EntityModel_EntityModelId",
                        column: x => x.EntityModelId,
                        principalTable: "EntityModel",
                        principalColumn: "EntityModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chassis",
                columns: table => new
                {
                    ChassisId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SnType = table.Column<string>(type: "text", nullable: false),
                    ChassisStatus = table.Column<string>(type: "text", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    EntityModelId = table.Column<int>(type: "integer", nullable: false),
                    Hostname = table.Column<string>(type: "text", nullable: false),
                    CurrentLocation = table.Column<string>(type: "text", nullable: false),
                    IsInstalled = table.Column<bool>(type: "boolean", nullable: false),
                    InitialDetailRecordId = table.Column<int>(type: "integer", nullable: false),
                    DetailChangeId = table.Column<int>(type: "integer", nullable: false),
                    InventoryNumber = table.Column<string>(type: "text", nullable: false),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chassis", x => x.ChassisId);
                    table.ForeignKey(
                        name: "FK_Chassis_DetailChange_DetailChangeId",
                        column: x => x.DetailChangeId,
                        principalTable: "DetailChange",
                        principalColumn: "DetailChangeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chassis_DetailRecord_InitialDetailRecordId",
                        column: x => x.InitialDetailRecordId,
                        principalTable: "DetailRecord",
                        principalColumn: "InitialDetailRecordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chassis_EntityModel_EntityModelId",
                        column: x => x.EntityModelId,
                        principalTable: "EntityModel",
                        principalColumn: "EntityModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SnType = table.Column<string>(type: "text", nullable: false),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    CardStatus = table.Column<string>(type: "text", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    CardSlotInChassis = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    InitialDetailRecordId = table.Column<int>(type: "integer", nullable: false),
                    DetailChangeId = table.Column<int>(type: "integer", nullable: false),
                    InventoryNumber = table.Column<string>(type: "text", nullable: false),
                    IsInstalled = table.Column<bool>(type: "boolean", nullable: false),
                    EntityModelId = table.Column<int>(type: "integer", nullable: false),
                    ChassisId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_Cards_Chassis_ChassisId",
                        column: x => x.ChassisId,
                        principalTable: "Chassis",
                        principalColumn: "ChassisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_DetailChange_DetailChangeId",
                        column: x => x.DetailChangeId,
                        principalTable: "DetailChange",
                        principalColumn: "DetailChangeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_DetailRecord_InitialDetailRecordId",
                        column: x => x.InitialDetailRecordId,
                        principalTable: "DetailRecord",
                        principalColumn: "InitialDetailRecordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_EntityModel_EntityModelId",
                        column: x => x.EntityModelId,
                        principalTable: "EntityModel",
                        principalColumn: "EntityModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UnitInRack = table.Column<int>(type: "integer", nullable: false),
                    IsFront = table.Column<bool>(type: "boolean", nullable: false),
                    RowNameAsbi = table.Column<string>(type: "text", nullable: false),
                    RowNameDataCenter = table.Column<string>(type: "text", nullable: false),
                    ChassisId = table.Column<int>(type: "integer", nullable: false),
                    ServerSlotId = table.Column<int>(type: "integer", nullable: false),
                    RackId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitId);
                    table.ForeignKey(
                        name: "FK_Units_Chassis_ChassisId",
                        column: x => x.ChassisId,
                        principalTable: "Chassis",
                        principalColumn: "ChassisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Units_Racks_RackId",
                        column: x => x.RackId,
                        principalTable: "Racks",
                        principalColumn: "RackId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Units_ServerSlots_ServerSlotId",
                        column: x => x.ServerSlotId,
                        principalTable: "ServerSlots",
                        principalColumn: "ServerSlotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SnType = table.Column<string>(type: "text", nullable: false),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    ModuleStatus = table.Column<string>(type: "text", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    CardSlotInChassisOrCard = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    InitialDetailRecordId = table.Column<int>(type: "integer", nullable: false),
                    DetailChangeId = table.Column<int>(type: "integer", nullable: false),
                    InventoryNumber = table.Column<string>(type: "text", nullable: false),
                    IsInstalled = table.Column<bool>(type: "boolean", nullable: false),
                    ServeroMesto = table.Column<int>(type: "integer", nullable: false),
                    EntityModelId = table.Column<int>(type: "integer", nullable: false),
                    ChassisId = table.Column<int>(type: "integer", nullable: false),
                    CardId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleId);
                    table.ForeignKey(
                        name: "FK_Modules_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Modules_Chassis_ChassisId",
                        column: x => x.ChassisId,
                        principalTable: "Chassis",
                        principalColumn: "ChassisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Modules_DetailChange_DetailChangeId",
                        column: x => x.DetailChangeId,
                        principalTable: "DetailChange",
                        principalColumn: "DetailChangeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Modules_DetailRecord_InitialDetailRecordId",
                        column: x => x.InitialDetailRecordId,
                        principalTable: "DetailRecord",
                        principalColumn: "InitialDetailRecordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Modules_EntityModel_EntityModelId",
                        column: x => x.EntityModelId,
                        principalTable: "EntityModel",
                        principalColumn: "EntityModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModulesA",
                columns: table => new
                {
                    ModuleAId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModuleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulesA", x => x.ModuleAId);
                    table.ForeignKey(
                        name: "FK_ModulesA_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModulesB",
                columns: table => new
                {
                    ModuleBId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModuleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulesB", x => x.ModuleBId);
                    table.ForeignKey(
                        name: "FK_ModulesB_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinkId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModuleAId = table.Column<int>(type: "integer", nullable: false),
                    ModuleBId = table.Column<int>(type: "integer", nullable: false),
                    VirtualPortA = table.Column<string>(type: "text", nullable: false),
                    VirtualPortB = table.Column<string>(type: "text", nullable: false),
                    CableId = table.Column<int>(type: "integer", nullable: false),
                    RdLinkId = table.Column<string>(type: "text", nullable: false),
                    CreationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    OperationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkId);
                    table.ForeignKey(
                        name: "FK_Links_Cables_CableId",
                        column: x => x.CableId,
                        principalTable: "Cables",
                        principalColumn: "CableId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Links_ModulesA_ModuleAId",
                        column: x => x.ModuleAId,
                        principalTable: "ModulesA",
                        principalColumn: "ModuleAId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Links_ModulesB_ModuleBId",
                        column: x => x.ModuleBId,
                        principalTable: "ModulesB",
                        principalColumn: "ModuleBId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cables_DetailChangeId",
                table: "Cables",
                column: "DetailChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cables_EntityModelId",
                table: "Cables",
                column: "EntityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cables_InitialDetailRecordId",
                table: "Cables",
                column: "InitialDetailRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ChassisId",
                table: "Cards",
                column: "ChassisId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_DetailChangeId",
                table: "Cards",
                column: "DetailChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_EntityModelId",
                table: "Cards",
                column: "EntityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_InitialDetailRecordId",
                table: "Cards",
                column: "InitialDetailRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_DetailChangeId",
                table: "Chassis",
                column: "DetailChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_EntityModelId",
                table: "Chassis",
                column: "EntityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_InitialDetailRecordId",
                table: "Chassis",
                column: "InitialDetailRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletionRequests_OperationId",
                table: "CompletionRequests",
                column: "OperationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CreationRequests_OperationId",
                table: "CreationRequests",
                column: "OperationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetailChange_RequestCompletionId",
                table: "DetailChange",
                column: "RequestCompletionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetailChange_RequestCreationId",
                table: "DetailChange",
                column: "RequestCreationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetailRecord_InitialDetailTableId",
                table: "DetailRecord",
                column: "InitialDetailTableId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailRecord_OperationId",
                table: "DetailRecord",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTable_TableFileFileId",
                table: "DetailTable",
                column: "TableFileFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_EntityModelId",
                table: "Licenses",
                column: "EntityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_InitialDetailRecordId",
                table: "Licenses",
                column: "InitialDetailRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_CableId",
                table: "Links",
                column: "CableId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ModuleAId",
                table: "Links",
                column: "ModuleAId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Links_ModuleBId",
                table: "Links",
                column: "ModuleBId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRecord_InitialMaterialTableId",
                table: "MaterialRecord",
                column: "InitialMaterialTableId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRecord_OperationId",
                table: "MaterialRecord",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialTable_TableFileFileId",
                table: "MaterialTable",
                column: "TableFileFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CardId",
                table: "Modules",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ChassisId",
                table: "Modules",
                column: "ChassisId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_DetailChangeId",
                table: "Modules",
                column: "DetailChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_EntityModelId",
                table: "Modules",
                column: "EntityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_InitialDetailRecordId",
                table: "Modules",
                column: "InitialDetailRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulesA_ModuleId",
                table: "ModulesA",
                column: "ModuleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModulesB_ModuleId",
                table: "ModulesB",
                column: "ModuleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OperationData_UserListAccountId",
                table: "OperationData",
                column: "UserListAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Racks_RoomRowId",
                table: "Racks",
                column: "RoomRowId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_DataCenterId",
                table: "Rooms",
                column: "DataCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_RoomId",
                table: "Rows",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerLinks_ServerSlotsServerSlotId",
                table: "ServerLinks",
                column: "ServerSlotsServerSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_ChassisId",
                table: "Units",
                column: "ChassisId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_RackId",
                table: "Units",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_ServerSlotId",
                table: "Units",
                column: "ServerSlotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "MaterialRecord");

            migrationBuilder.DropTable(
                name: "ServerLinks");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Cables");

            migrationBuilder.DropTable(
                name: "ModulesA");

            migrationBuilder.DropTable(
                name: "ModulesB");

            migrationBuilder.DropTable(
                name: "MaterialTable");

            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "ServerSlots");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Rows");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Chassis");

            migrationBuilder.DropTable(
                name: "DataCenters");

            migrationBuilder.DropTable(
                name: "DetailChange");

            migrationBuilder.DropTable(
                name: "DetailRecord");

            migrationBuilder.DropTable(
                name: "EntityModel");

            migrationBuilder.DropTable(
                name: "CompletionRequests");

            migrationBuilder.DropTable(
                name: "CreationRequests");

            migrationBuilder.DropTable(
                name: "DetailTable");

            migrationBuilder.DropTable(
                name: "OperationData");

            migrationBuilder.DropTable(
                name: "FileData");

            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}
