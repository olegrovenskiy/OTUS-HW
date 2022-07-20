using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class ChassisEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_DetailChange_DetailChangeId",
                table: "Chassis");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_DetailRecord_InitialDetailRecordId",
                table: "Chassis");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_EntityModel_EntityModelId",
                table: "Chassis");

            migrationBuilder.AlterColumn<string>(
                name: "SnType",
                table: "Chassis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "Chassis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Chassis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsInstalled",
                table: "Chassis",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "InventoryNumber",
                table: "Chassis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "InitialDetailRecordId",
                table: "Chassis",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Hostname",
                table: "Chassis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "EntityModelId",
                table: "Chassis",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DetailChangeId",
                table: "Chassis",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryYear",
                table: "Chassis",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "CurrentLocation",
                table: "Chassis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Chassis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ChassisStatus",
                table: "Chassis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_DetailChange_DetailChangeId",
                table: "Chassis",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_DetailRecord_InitialDetailRecordId",
                table: "Chassis",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_EntityModel_EntityModelId",
                table: "Chassis",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_DetailChange_DetailChangeId",
                table: "Chassis");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_DetailRecord_InitialDetailRecordId",
                table: "Chassis");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_EntityModel_EntityModelId",
                table: "Chassis");

            migrationBuilder.AlterColumn<string>(
                name: "SnType",
                table: "Chassis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "Chassis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Chassis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsInstalled",
                table: "Chassis",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InventoryNumber",
                table: "Chassis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InitialDetailRecordId",
                table: "Chassis",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Hostname",
                table: "Chassis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EntityModelId",
                table: "Chassis",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DetailChangeId",
                table: "Chassis",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryYear",
                table: "Chassis",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CurrentLocation",
                table: "Chassis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Chassis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChassisStatus",
                table: "Chassis",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_DetailChange_DetailChangeId",
                table: "Chassis",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_DetailRecord_InitialDetailRecordId",
                table: "Chassis",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_EntityModel_EntityModelId",
                table: "Chassis",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
