using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Add_ServerLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_ServerLinks_ServerSlotsServerSlotId",
                table: "ServerLinks",
                column: "ServerSlotsServerSlotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServerLinks");
        }
    }
}
