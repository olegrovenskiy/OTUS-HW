using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Add_InitialRecordsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrimaryRecordlId",
                table: "Modules",
                newName: "InitialDetailRecordId");

            migrationBuilder.RenameColumn(
                name: "PrimaryRecordlId",
                table: "Chassis",
                newName: "InitialDetailRecordId");

            migrationBuilder.RenameColumn(
                name: "PrimaryRecordlId",
                table: "Cards",
                newName: "InitialDetailRecordId");

            migrationBuilder.RenameColumn(
                name: "PrimaryRecordlId",
                table: "Cables",
                newName: "InitialDetailRecordId");

            migrationBuilder.CreateTable(
                name: "DetailTable",
                columns: table => new
                {
                    InitialDetailTableId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailTable", x => x.InitialDetailTableId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialTable",
                columns: table => new
                {
                    InitialMaterialTableId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialTable", x => x.InitialMaterialTableId);
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailRecord_InitialDetailTableId",
                table: "DetailRecord",
                column: "InitialDetailTableId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRecord_InitialMaterialTableId",
                table: "MaterialRecord",
                column: "InitialMaterialTableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailRecord");

            migrationBuilder.DropTable(
                name: "MaterialRecord");

            migrationBuilder.DropTable(
                name: "DetailTable");

            migrationBuilder.DropTable(
                name: "MaterialTable");

            migrationBuilder.RenameColumn(
                name: "InitialDetailRecordId",
                table: "Modules",
                newName: "PrimaryRecordlId");

            migrationBuilder.RenameColumn(
                name: "InitialDetailRecordId",
                table: "Chassis",
                newName: "PrimaryRecordlId");

            migrationBuilder.RenameColumn(
                name: "InitialDetailRecordId",
                table: "Cards",
                newName: "PrimaryRecordlId");

            migrationBuilder.RenameColumn(
                name: "InitialDetailRecordId",
                table: "Cables",
                newName: "PrimaryRecordlId");
        }
    }
}
