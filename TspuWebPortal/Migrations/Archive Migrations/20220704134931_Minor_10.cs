using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Minor_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_SpecificationRecords_SpecaModelId",
                table: "DetailRecord");

            migrationBuilder.RenameColumn(
                name: "SpecaModelId",
                table: "DetailRecord",
                newName: "SpecItemId");

            migrationBuilder.RenameIndex(
                name: "IX_DetailRecord_SpecaModelId",
                table: "DetailRecord",
                newName: "IX_DetailRecord_SpecItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_SpecificationRecords_SpecItemId",
                table: "DetailRecord",
                column: "SpecItemId",
                principalTable: "SpecificationRecords",
                principalColumn: "SpecItemId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_SpecificationRecords_SpecItemId",
                table: "DetailRecord");

            migrationBuilder.RenameColumn(
                name: "SpecItemId",
                table: "DetailRecord",
                newName: "SpecaModelId");

            migrationBuilder.RenameIndex(
                name: "IX_DetailRecord_SpecItemId",
                table: "DetailRecord",
                newName: "IX_DetailRecord_SpecaModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_SpecificationRecords_SpecaModelId",
                table: "DetailRecord",
                column: "SpecaModelId",
                principalTable: "SpecificationRecords",
                principalColumn: "SpecItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
