using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class HydraAddToModuleCable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cables_DetailChange_DetailChangeId",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Cables_DetailRecord_InitialDetailRecordId",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Cables_EntityModel_EntityModelId",
                table: "Cables");

            migrationBuilder.AddColumn<bool>(
                name: "IsSideA",
                table: "Modules",
                type: "boolean",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SnType",
                table: "Cables",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "Cables",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Cables",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsInstalled",
                table: "Cables",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "InventoryNumber",
                table: "Cables",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "InitialDetailRecordId",
                table: "Cables",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "EntityModelId",
                table: "Cables",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DetailChangeId",
                table: "Cables",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryYear",
                table: "Cables",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Cables",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_DetailChange_DetailChangeId",
                table: "Cables",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_DetailRecord_InitialDetailRecordId",
                table: "Cables",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_EntityModel_EntityModelId",
                table: "Cables",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cables_DetailChange_DetailChangeId",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Cables_DetailRecord_InitialDetailRecordId",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Cables_EntityModel_EntityModelId",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "IsSideA",
                table: "Modules");

            migrationBuilder.AlterColumn<string>(
                name: "SnType",
                table: "Cables",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "Cables",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Cables",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsInstalled",
                table: "Cables",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InventoryNumber",
                table: "Cables",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InitialDetailRecordId",
                table: "Cables",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EntityModelId",
                table: "Cables",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DetailChangeId",
                table: "Cables",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryYear",
                table: "Cables",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Cables",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_DetailChange_DetailChangeId",
                table: "Cables",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_DetailRecord_InitialDetailRecordId",
                table: "Cables",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_EntityModel_EntityModelId",
                table: "Cables",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
