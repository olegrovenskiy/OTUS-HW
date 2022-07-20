using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Add_Chassis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChassisId",
                table: "Units",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
                    PrimaryRecordlId = table.Column<int>(type: "integer", nullable: false),
                    DetailTransferId = table.Column<int>(type: "integer", nullable: false),
                    InventoryNumber = table.Column<string>(type: "text", nullable: false),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chassis", x => x.ChassisId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Units_ChassisId",
                table: "Units",
                column: "ChassisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Chassis_ChassisId",
                table: "Units",
                column: "ChassisId",
                principalTable: "Chassis",
                principalColumn: "ChassisId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_Chassis_ChassisId",
                table: "Units");

            migrationBuilder.DropTable(
                name: "Chassis");

            migrationBuilder.DropIndex(
                name: "IX_Units_ChassisId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "ChassisId",
                table: "Units");
        }
    }
}
