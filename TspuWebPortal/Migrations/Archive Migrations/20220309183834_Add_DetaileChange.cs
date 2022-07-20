using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Add_DetaileChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DetailTransferId",
                table: "Modules",
                newName: "DetailChangeId");

            migrationBuilder.RenameColumn(
                name: "DetailTransferId",
                table: "Chassis",
                newName: "DetailChangeId");

            migrationBuilder.RenameColumn(
                name: "DetailTransferId",
                table: "Cards",
                newName: "DetailChangeId");

            migrationBuilder.RenameColumn(
                name: "DetailTransferId",
                table: "Cables",
                newName: "DetailChangeId");

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
                    OperationIdCreate = table.Column<int>(type: "integer", nullable: false),
                    OperationIdComplete = table.Column<int>(type: "integer", nullable: false),
                    CompleteChangeDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsInstalled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailChange", x => x.DetailChangeId);
                });

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
                principalColumn: "DetailChangeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_DetailChange_DetailChangeId",
                table: "Cards",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_DetailChange_DetailChangeId",
                table: "Chassis",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_DetailChange_DetailChangeId",
                table: "Modules",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "DetailChange");

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

            migrationBuilder.RenameColumn(
                name: "DetailChangeId",
                table: "Modules",
                newName: "DetailTransferId");

            migrationBuilder.RenameColumn(
                name: "DetailChangeId",
                table: "Chassis",
                newName: "DetailTransferId");

            migrationBuilder.RenameColumn(
                name: "DetailChangeId",
                table: "Cards",
                newName: "DetailTransferId");

            migrationBuilder.RenameColumn(
                name: "DetailChangeId",
                table: "Cables",
                newName: "DetailTransferId");
        }
    }
}
