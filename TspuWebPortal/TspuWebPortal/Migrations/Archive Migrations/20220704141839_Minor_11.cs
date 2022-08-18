using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Minor_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_SpecificationRecords_SpecItemId",
                table: "DetailRecord");

            migrationBuilder.RenameColumn(
                name: "SpecItemId",
                table: "SpecificationRecords",
                newName: "SpecDetailId");

            migrationBuilder.RenameColumn(
                name: "SpecItemId",
                table: "DetailRecord",
                newName: "SpecDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_DetailRecord_SpecItemId",
                table: "DetailRecord",
                newName: "IX_DetailRecord_SpecDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_SpecificationRecords_SpecDetailId",
                table: "DetailRecord",
                column: "SpecDetailId",
                principalTable: "SpecificationRecords",
                principalColumn: "SpecDetailId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_SpecificationRecords_SpecDetailId",
                table: "DetailRecord");

            migrationBuilder.RenameColumn(
                name: "SpecDetailId",
                table: "SpecificationRecords",
                newName: "SpecItemId");

            migrationBuilder.RenameColumn(
                name: "SpecDetailId",
                table: "DetailRecord",
                newName: "SpecItemId");

            migrationBuilder.RenameIndex(
                name: "IX_DetailRecord_SpecDetailId",
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
    }
}
