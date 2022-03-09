using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Add_Cables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cables",
                columns: table => new
                {
                    CableId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SnType = table.Column<string>(type: "text", nullable: false),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    PrimaryRecordlId = table.Column<int>(type: "integer", nullable: false),
                    DetailTransferId = table.Column<int>(type: "integer", nullable: false),
                    InventoryNumber = table.Column<string>(type: "text", nullable: false),
                    IsInstalled = table.Column<bool>(type: "boolean", nullable: false),
                    EntityModelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cables", x => x.CableId);
                    table.ForeignKey(
                        name: "FK_Cables_EntityModel_EntityModelId",
                        column: x => x.EntityModelId,
                        principalTable: "EntityModel",
                        principalColumn: "EntityModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cables_EntityModelId",
                table: "Cables",
                column: "EntityModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cables");
        }
    }
}
