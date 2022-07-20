using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Minor_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cables_DetailChange_DetailChangeId",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_DetailChange_DetailChangeId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_DetailChange_DetailChangeId",
                table: "Chassis");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_DetailChange_DetailChangeId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_DetailChangeId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Chassis_DetailChangeId",
                table: "Chassis");

            migrationBuilder.DropIndex(
                name: "IX_Cards_DetailChangeId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cables_DetailChangeId",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "DetailChangeId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "DetailChangeId",
                table: "Chassis");

            migrationBuilder.DropColumn(
                name: "IsInstalled",
                table: "Chassis");

            migrationBuilder.DropColumn(
                name: "DetailChangeId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "DetailChangeId",
                table: "Cables");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetailChangeId",
                table: "Modules",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetailChangeId",
                table: "Chassis",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsInstalled",
                table: "Chassis",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DetailChangeId",
                table: "Cards",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetailChangeId",
                table: "Cables",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modules_DetailChangeId",
                table: "Modules",
                column: "DetailChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_DetailChangeId",
                table: "Chassis",
                column: "DetailChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_DetailChangeId",
                table: "Cards",
                column: "DetailChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cables_DetailChangeId",
                table: "Cables",
                column: "DetailChangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_DetailChange_DetailChangeId",
                table: "Cables",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_DetailChange_DetailChangeId",
                table: "Cards",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_DetailChange_DetailChangeId",
                table: "Chassis",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_DetailChange_DetailChangeId",
                table: "Modules",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId");
        }
    }
}
