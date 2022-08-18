using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Add_ServerSlots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServerSlotId",
                table: "Units",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Units_ServerSlotId",
                table: "Units",
                column: "ServerSlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_ServerSlots_ServerSlotId",
                table: "Units",
                column: "ServerSlotId",
                principalTable: "ServerSlots",
                principalColumn: "ServerSlotId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_ServerSlots_ServerSlotId",
                table: "Units");

            migrationBuilder.DropTable(
                name: "ServerSlots");

            migrationBuilder.DropIndex(
                name: "IX_Units_ServerSlotId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "ServerSlotId",
                table: "Units");
        }
    }
}
