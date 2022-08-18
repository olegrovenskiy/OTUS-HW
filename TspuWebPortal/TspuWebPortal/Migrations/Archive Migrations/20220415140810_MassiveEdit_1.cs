using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class MassiveEdit_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Cards_CardId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Chassis_ChassisId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_DetailChange_DetailChangeId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_DetailRecord_InitialDetailRecordId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_EntityModel_EntityModelId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Racks_Rows_RowId",
                table: "Racks");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Chassis",
                newName: "PositionInUpperEntity");

            migrationBuilder.AlterColumn<int>(
                name: "RowId",
                table: "Racks",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "RackType",
                table: "Racks",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "RackNameDataCenter",
                table: "Racks",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "RackNameAsbi",
                table: "Racks",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "RackHeight",
                table: "Racks",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "InstallationYear",
                table: "Racks",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "FreeServerSlotsQuantity",
                table: "Racks",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "SnType",
                table: "Modules",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "ServeroMesto",
                table: "Modules",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "Modules",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ModuleStatus",
                table: "Modules",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsInstalled",
                table: "Modules",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "InventoryNumber",
                table: "Modules",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "InitialDetailRecordId",
                table: "Modules",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "EntityModelId",
                table: "Modules",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DetailChangeId",
                table: "Modules",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryYear",
                table: "Modules",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Modules",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "ChassisId",
                table: "Modules",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "CardSlotInChassisOrCard",
                table: "Modules",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "Modules",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "CurrentLocation",
                table: "Modules",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PositionInUpperEntity",
                table: "Modules",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PositionInUpperEntity",
                table: "Cards",
                type: "text",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Cards_CardId",
                table: "Modules",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Chassis_ChassisId",
                table: "Modules",
                column: "ChassisId",
                principalTable: "Chassis",
                principalColumn: "ChassisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_DetailChange_DetailChangeId",
                table: "Modules",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_DetailRecord_InitialDetailRecordId",
                table: "Modules",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_EntityModel_EntityModelId",
                table: "Modules",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Racks_Rows_RowId",
                table: "Racks",
                column: "RowId",
                principalTable: "Rows",
                principalColumn: "RowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Cards_CardId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Chassis_ChassisId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_DetailChange_DetailChangeId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_DetailRecord_InitialDetailRecordId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_EntityModel_EntityModelId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Racks_Rows_RowId",
                table: "Racks");

            migrationBuilder.DropColumn(
                name: "CurrentLocation",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "PositionInUpperEntity",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "PositionInUpperEntity",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "PositionInUpperEntity",
                table: "Chassis",
                newName: "Location");

            migrationBuilder.AlterColumn<int>(
                name: "RowId",
                table: "Racks",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RackType",
                table: "Racks",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RackNameDataCenter",
                table: "Racks",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RackNameAsbi",
                table: "Racks",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RackHeight",
                table: "Racks",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstallationYear",
                table: "Racks",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FreeServerSlotsQuantity",
                table: "Racks",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SnType",
                table: "Modules",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServeroMesto",
                table: "Modules",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "Modules",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModuleStatus",
                table: "Modules",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsInstalled",
                table: "Modules",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InventoryNumber",
                table: "Modules",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InitialDetailRecordId",
                table: "Modules",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EntityModelId",
                table: "Modules",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DetailChangeId",
                table: "Modules",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryYear",
                table: "Modules",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Modules",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChassisId",
                table: "Modules",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardSlotInChassisOrCard",
                table: "Modules",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "Modules",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Modules",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Cards_CardId",
                table: "Modules",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Chassis_ChassisId",
                table: "Modules",
                column: "ChassisId",
                principalTable: "Chassis",
                principalColumn: "ChassisId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_DetailChange_DetailChangeId",
                table: "Modules",
                column: "DetailChangeId",
                principalTable: "DetailChange",
                principalColumn: "DetailChangeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_DetailRecord_InitialDetailRecordId",
                table: "Modules",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_EntityModel_EntityModelId",
                table: "Modules",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Racks_Rows_RowId",
                table: "Racks",
                column: "RowId",
                principalTable: "Rows",
                principalColumn: "RowId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
