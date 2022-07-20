using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class ChangeForeighKeyAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailTable_FileData_TableFileFileId",
                table: "DetailTable");

            migrationBuilder.DropIndex(
                name: "IX_DetailTable_TableFileFileId",
                table: "DetailTable");

            migrationBuilder.DropColumn(
                name: "TableFileFileId",
                table: "DetailTable");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTable_FileId",
                table: "DetailTable",
                column: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailTable_FileData_FileId",
                table: "DetailTable",
                column: "FileId",
                principalTable: "FileData",
                principalColumn: "FileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailTable_FileData_FileId",
                table: "DetailTable");

            migrationBuilder.DropIndex(
                name: "IX_DetailTable_FileId",
                table: "DetailTable");

            migrationBuilder.AddColumn<int>(
                name: "TableFileFileId",
                table: "DetailTable",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetailTable_TableFileFileId",
                table: "DetailTable",
                column: "TableFileFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailTable_FileData_TableFileFileId",
                table: "DetailTable",
                column: "TableFileFileId",
                principalTable: "FileData",
                principalColumn: "FileId");
        }
    }
}
