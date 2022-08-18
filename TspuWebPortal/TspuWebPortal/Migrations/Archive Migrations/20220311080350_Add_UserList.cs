using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Add_UserList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OperationDataOperationId",
                table: "DetailChange",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinkId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModuleAId = table.Column<int>(type: "integer", nullable: false),
                    ModuleBId = table.Column<int>(type: "integer", nullable: false),
                    VirtualPortA = table.Column<string>(type: "text", nullable: false),
                    VirtualPortB = table.Column<string>(type: "text", nullable: false),
                    CableId = table.Column<int>(type: "integer", nullable: false),
                    RdLinkId = table.Column<string>(type: "text", nullable: false),
                    CreationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    DeliveryYear = table.Column<int>(type: "integer", nullable: false),
                    OperationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkId);
                    table.ForeignKey(
                        name: "FK_Links_Cables_CableId",
                        column: x => x.CableId,
                        principalTable: "Cables",
                        principalColumn: "CableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullPersonName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "OperationData",
                columns: table => new
                {
                    OperationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OperationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    OperationType = table.Column<string>(type: "text", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: false),
                    UserListAccountId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationData", x => x.OperationId);
                    table.ForeignKey(
                        name: "FK_OperationData_UserAccounts_UserListAccountId",
                        column: x => x.UserListAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "AccountId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRecord_OperationId",
                table: "MaterialRecord",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailRecord_OperationId",
                table: "DetailRecord",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailChange_OperationDataOperationId",
                table: "DetailChange",
                column: "OperationDataOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_CableId",
                table: "Links",
                column: "CableId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationData_UserListAccountId",
                table: "OperationData",
                column: "UserListAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailChange_OperationData_OperationDataOperationId",
                table: "DetailChange",
                column: "OperationDataOperationId",
                principalTable: "OperationData",
                principalColumn: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_OperationData_OperationId",
                table: "DetailRecord",
                column: "OperationId",
                principalTable: "OperationData",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialRecord_OperationData_OperationId",
                table: "MaterialRecord",
                column: "OperationId",
                principalTable: "OperationData",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailChange_OperationData_OperationDataOperationId",
                table: "DetailChange");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_OperationData_OperationId",
                table: "DetailRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialRecord_OperationData_OperationId",
                table: "MaterialRecord");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "OperationData");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_MaterialRecord_OperationId",
                table: "MaterialRecord");

            migrationBuilder.DropIndex(
                name: "IX_DetailRecord_OperationId",
                table: "DetailRecord");

            migrationBuilder.DropIndex(
                name: "IX_DetailChange_OperationDataOperationId",
                table: "DetailChange");

            migrationBuilder.DropColumn(
                name: "OperationDataOperationId",
                table: "DetailChange");
        }
    }
}
