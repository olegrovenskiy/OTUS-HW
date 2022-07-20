using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class DeleteUnused_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cables_EntityModel_EntityModelId",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_DetailRecord_InitialDetailRecordId",
                table: "Chassis");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_EntityModel_EntityModelId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_EntityModelId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "CurrentLocation",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "DeliveryYear",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "EntityModelId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "InventoryNumber",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "ModuleSlotInChassisOrCard",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "ModuleStatus",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "SnType",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "CurrentLocation",
                table: "Chassis");

            migrationBuilder.DropColumn(
                name: "DeliveryYear",
                table: "Chassis");

            migrationBuilder.DropColumn(
                name: "InventoryNumber",
                table: "Chassis");

            migrationBuilder.DropColumn(
                name: "PositionInUpperEntity",
                table: "Chassis");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Chassis");

            migrationBuilder.DropColumn(
                name: "SnType",
                table: "Chassis");

            migrationBuilder.DropColumn(
                name: "CardSlotInChassis",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardStatus",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CurrentLocation",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "DeliveryYear",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "InventoryNumber",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "SnType",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CurrentLocation",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "DeliveryYear",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "InventoryNumber",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "SnType",
                table: "Cables");

            migrationBuilder.RenameColumn(
                name: "ServeroMesto",
                table: "Modules",
                newName: "EntityModelDataEntityModelId");

            migrationBuilder.RenameColumn(
                name: "EntityModelId",
                table: "Cables",
                newName: "EntityModelDataEntityModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Cables_EntityModelId",
                table: "Cables",
                newName: "IX_Cables_EntityModelDataEntityModelId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsInstalled",
                table: "Chassis",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
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

            migrationBuilder.CreateIndex(
                name: "IX_Modules_EntityModelDataEntityModelId",
                table: "Modules",
                column: "EntityModelDataEntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_EntityModel_EntityModelDataEntityModelId",
                table: "Cables",
                column: "EntityModelDataEntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_DetailRecord_InitialDetailRecordId",
                table: "Chassis",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_EntityModel_EntityModelDataEntityModelId",
                table: "Modules",
                column: "EntityModelDataEntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cables_EntityModel_EntityModelDataEntityModelId",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Chassis_DetailRecord_InitialDetailRecordId",
                table: "Chassis");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_EntityModel_EntityModelDataEntityModelId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_EntityModelDataEntityModelId",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "EntityModelDataEntityModelId",
                table: "Modules",
                newName: "ServeroMesto");

            migrationBuilder.RenameColumn(
                name: "EntityModelDataEntityModelId",
                table: "Cables",
                newName: "EntityModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Cables_EntityModelDataEntityModelId",
                table: "Cables",
                newName: "IX_Cables_EntityModelId");

            migrationBuilder.AddColumn<string>(
                name: "CurrentLocation",
                table: "Modules",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryYear",
                table: "Modules",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityModelId",
                table: "Modules",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InventoryNumber",
                table: "Modules",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModuleSlotInChassisOrCard",
                table: "Modules",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModuleStatus",
                table: "Modules",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Modules",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SnType",
                table: "Modules",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsInstalled",
                table: "Chassis",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

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

            migrationBuilder.AddColumn<string>(
                name: "CurrentLocation",
                table: "Chassis",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryYear",
                table: "Chassis",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InventoryNumber",
                table: "Chassis",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PositionInUpperEntity",
                table: "Chassis",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Chassis",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SnType",
                table: "Chassis",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardSlotInChassis",
                table: "Cards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardStatus",
                table: "Cards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentLocation",
                table: "Cards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryYear",
                table: "Cards",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InventoryNumber",
                table: "Cards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Cards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SnType",
                table: "Cards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentLocation",
                table: "Cables",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryYear",
                table: "Cables",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InventoryNumber",
                table: "Cables",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Cables",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SnType",
                table: "Cables",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modules_EntityModelId",
                table: "Modules",
                column: "EntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_EntityModel_EntityModelId",
                table: "Cables",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chassis_DetailRecord_InitialDetailRecordId",
                table: "Chassis",
                column: "InitialDetailRecordId",
                principalTable: "DetailRecord",
                principalColumn: "InitialDetailRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_EntityModel_EntityModelId",
                table: "Modules",
                column: "EntityModelId",
                principalTable: "EntityModel",
                principalColumn: "EntityModelId");
        }
    }
}
