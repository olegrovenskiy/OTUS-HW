using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Minor_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpecificationRecords",
                columns: table => new
                {
                    SpecItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SpecItemFullName = table.Column<string>(type: "text", nullable: false),
                    SpecItemShortName = table.Column<string>(type: "text", nullable: false),
                    SpecItemType = table.Column<string>(type: "text", nullable: false),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    EntityModelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificationRecords", x => x.SpecItemId);
                    table.ForeignKey(
                        name: "FK_SpecificationRecords_EntityModel_EntityModelId",
                        column: x => x.EntityModelId,
                        principalTable: "EntityModel",
                        principalColumn: "EntityModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpecificationRecords_EntityModelId",
                table: "SpecificationRecords",
                column: "EntityModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecificationRecords");
        }
    }
}
