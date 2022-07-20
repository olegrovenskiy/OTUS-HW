using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Add_Row_Rack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rows",
                columns: table => new
                {
                    RowId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RowNameAsbi = table.Column<string>(type: "text", nullable: false),
                    RowNameDataCenter = table.Column<string>(type: "text", nullable: false),
                    RoomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rows", x => x.RowId);
                    table.ForeignKey(
                        name: "FK_Rows_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Racks",
                columns: table => new
                {
                    RackId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RackNameAsbi = table.Column<string>(type: "text", nullable: false),
                    RackNameDataCenter = table.Column<string>(type: "text", nullable: false),
                    RackHeight = table.Column<int>(type: "integer", nullable: false),
                    FreeServerSlotsQuantity = table.Column<int>(type: "integer", nullable: false),
                    IsInstalled = table.Column<bool>(type: "boolean", nullable: false),
                    InstallationYear = table.Column<int>(type: "integer", nullable: false),
                    RackType = table.Column<string>(type: "text", nullable: false),
                    RowId = table.Column<int>(type: "integer", nullable: false),
                    RoomRowId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racks", x => x.RackId);
                    table.ForeignKey(
                        name: "FK_Racks_Rows_RoomRowId",
                        column: x => x.RoomRowId,
                        principalTable: "Rows",
                        principalColumn: "RowId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Racks_RoomRowId",
                table: "Racks",
                column: "RoomRowId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_RoomId",
                table: "Rows",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "Rows");
        }
    }
}
