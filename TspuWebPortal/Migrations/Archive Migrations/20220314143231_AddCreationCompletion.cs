using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class AddCreationCompletion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailChange_OperationData_OperationDataOperationId",
                table: "DetailChange");

            migrationBuilder.DropIndex(
                name: "IX_DetailChange_OperationDataOperationId",
                table: "DetailChange");

            migrationBuilder.DropColumn(
                name: "OperationDataOperationId",
                table: "DetailChange");

            migrationBuilder.RenameColumn(
                name: "OperationIdCreate",
                table: "DetailChange",
                newName: "RequestCreationId");

            migrationBuilder.RenameColumn(
                name: "OperationIdComplete",
                table: "DetailChange",
                newName: "RequestCompletionId");

            migrationBuilder.CreateTable(
                name: "RequestCompletionData",
                columns: table => new
                {
                    RequestCompletionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OperationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestCompletionData", x => x.RequestCompletionId);
                    table.ForeignKey(
                        name: "FK_RequestCompletionData_OperationData_OperationId",
                        column: x => x.OperationId,
                        principalTable: "OperationData",
                        principalColumn: "OperationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestCreationData",
                columns: table => new
                {
                    RequestCreationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OperationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestCreationData", x => x.RequestCreationId);
                    table.ForeignKey(
                        name: "FK_RequestCreationData_OperationData_OperationId",
                        column: x => x.OperationId,
                        principalTable: "OperationData",
                        principalColumn: "OperationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailChange_RequestCompletionId",
                table: "DetailChange",
                column: "RequestCompletionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetailChange_RequestCreationId",
                table: "DetailChange",
                column: "RequestCreationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestCompletionData_OperationId",
                table: "RequestCompletionData",
                column: "OperationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestCreationData_OperationId",
                table: "RequestCreationData",
                column: "OperationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailChange_RequestCompletionData_RequestCompletionId",
                table: "DetailChange",
                column: "RequestCompletionId",
                principalTable: "RequestCompletionData",
                principalColumn: "RequestCompletionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailChange_RequestCreationData_RequestCreationId",
                table: "DetailChange",
                column: "RequestCreationId",
                principalTable: "RequestCreationData",
                principalColumn: "RequestCreationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailChange_RequestCompletionData_RequestCompletionId",
                table: "DetailChange");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailChange_RequestCreationData_RequestCreationId",
                table: "DetailChange");

            migrationBuilder.DropTable(
                name: "RequestCompletionData");

            migrationBuilder.DropTable(
                name: "RequestCreationData");

            migrationBuilder.DropIndex(
                name: "IX_DetailChange_RequestCompletionId",
                table: "DetailChange");

            migrationBuilder.DropIndex(
                name: "IX_DetailChange_RequestCreationId",
                table: "DetailChange");

            migrationBuilder.RenameColumn(
                name: "RequestCreationId",
                table: "DetailChange",
                newName: "OperationIdCreate");

            migrationBuilder.RenameColumn(
                name: "RequestCompletionId",
                table: "DetailChange",
                newName: "OperationIdComplete");

            migrationBuilder.AddColumn<int>(
                name: "OperationDataOperationId",
                table: "DetailChange",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetailChange_OperationDataOperationId",
                table: "DetailChange",
                column: "OperationDataOperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailChange_OperationData_OperationDataOperationId",
                table: "DetailChange",
                column: "OperationDataOperationId",
                principalTable: "OperationData",
                principalColumn: "OperationId");
        }
    }
}
