using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Add_EntityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntityModel",
                columns: table => new
                {
                    EntityModelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModelName = table.Column<string>(type: "text", nullable: false),
                    PartNumber = table.Column<string>(type: "text", nullable: false),
                    ModelType = table.Column<string>(type: "text", nullable: false),
                    Vendor = table.Column<string>(type: "text", nullable: false),
                    NominalPower = table.Column<int>(type: "integer", nullable: false),
                    MaximalPower = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityModel", x => x.EntityModelId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_EntityModelId",
                table: "Chassis",
                column: "EntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_EntityModel_EntityModelId",
                table: "Chassis",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_EntityModel_EntityModelId",
                table: "Chassis");

            migrationBuilder.DropTable(
                name: "EntityModel");

            migrationBuilder.DropIndex(
                name: "IX_Chassis_EntityModelId",
                table: "Chassis");
        }
    }
}
