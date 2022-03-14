using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Add_File : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrimaryRecordlId",
                table: "Licenses",
                newName: "InitialDetailRecordId");

            migrationBuilder.AddColumn<int>(
                name: "TableFileFileId",
                table: "MaterialTable",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableFileFileId",
                table: "DetailTable",
                type: "integer",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Modules_InitialDetailRecordId",
                table: "Modules",
                column: "InitialDetailRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialTable_TableFileFileId",
                table: "MaterialTable",
                column: "TableFileFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_InitialDetailRecordId",
                table: "Licenses",
                column: "InitialDetailRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTable_TableFileFileId",
                table: "DetailTable",
                column: "TableFileFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_InitialDetailRecordId",
                table: "Chassis",
                column: "InitialDetailRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_InitialDetailRecordId",
                table: "Cards",
                column: "InitialDetailRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Cables_InitialDetailRecordId",
                table: "Cables",
                column: "InitialDetailRecordId");

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
                name: "FK_DetailTable_FileData_TableFileFileId",
                table: "DetailTable",
                column: "TableFileFileId",
                principalTable: "FileData",
                principalColumn: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_DetailRecord_InitialDetailRecordId",
                table: "Licenses",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTable_FileData_TableFileFileId",
                table: "MaterialTable",
                column: "TableFileFileId",
                principalTable: "FileData",
                principalColumn: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_DetailRecord_InitialDetailRecordId",
                table: "Modules",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_DetailTable_FileData_TableFileFileId",
                table: "DetailTable");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_DetailRecord_InitialDetailRecordId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialTable_FileData_TableFileFileId",
                table: "MaterialTable");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_DetailRecord_InitialDetailRecordId",
                table: "Modules");

            migrationBuilder.DropTable(
                name: "FileData");

            migrationBuilder.DropIndex(
                name: "IX_Modules_InitialDetailRecordId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_MaterialTable_TableFileFileId",
                table: "MaterialTable");

            migrationBuilder.DropIndex(
                name: "IX_Licenses_InitialDetailRecordId",
                table: "Licenses");

            migrationBuilder.DropIndex(
                name: "IX_DetailTable_TableFileFileId",
                table: "DetailTable");

            migrationBuilder.DropIndex(
                name: "IX_Chassis_InitialDetailRecordId",
                table: "Chassis");

            migrationBuilder.DropIndex(
                name: "IX_Cards_InitialDetailRecordId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cables_InitialDetailRecordId",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "TableFileFileId",
                table: "MaterialTable");

            migrationBuilder.DropColumn(
                name: "TableFileFileId",
                table: "DetailTable");

            migrationBuilder.RenameColumn(
                name: "InitialDetailRecordId",
                table: "Licenses",
                newName: "PrimaryRecordlId");
        }
    }
}
