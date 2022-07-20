using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class UnitAddLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_Chassis_ChassisId",
                table: "Units");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_Racks_RackId",
                table: "Units");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_ServerSlots_ServerSlotId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "RowNameAsbi",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "RowNameDataCenter",
                table: "Units");

            migrationBuilder.AlterColumn<int>(
                name: "UnitInRack",
                table: "Units",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ServerSlotId",
                table: "Units",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "RackId",
                table: "Units",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<bool>(
                name: "IsFront",
                table: "Units",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<int>(
                name: "ChassisId",
                table: "Units",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Chassis_ChassisId",
                table: "Units",
                column: "ChassisId",
                principalTable: "Chassis",
                principalColumn: "ChassisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Racks_RackId",
                table: "Units",
                column: "RackId",
                principalTable: "Racks",
                principalColumn: "RackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_ServerSlots_ServerSlotId",
                table: "Units",
                column: "ServerSlotId",
                principalTable: "ServerSlots",
                principalColumn: "ServerSlotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_Chassis_ChassisId",
                table: "Units");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_Racks_RackId",
                table: "Units");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_ServerSlots_ServerSlotId",
                table: "Units");

            migrationBuilder.AlterColumn<int>(
                name: "UnitInRack",
                table: "Units",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServerSlotId",
                table: "Units",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RackId",
                table: "Units",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsFront",
                table: "Units",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChassisId",
                table: "Units",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RowNameAsbi",
                table: "Units",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RowNameDataCenter",
                table: "Units",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Chassis_ChassisId",
                table: "Units",
                column: "ChassisId",
                principalTable: "Chassis",
                principalColumn: "ChassisId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Racks_RackId",
                table: "Units",
                column: "RackId",
                principalTable: "Racks",
                principalColumn: "RackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_ServerSlots_ServerSlotId",
                table: "Units",
                column: "ServerSlotId",
                principalTable: "ServerSlots",
                principalColumn: "ServerSlotId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
