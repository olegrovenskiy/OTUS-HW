using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class RenameCardSlot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CardSlotInChassisOrCard",
                table: "Modules",
                newName: "ModuleSlotInChassisOrCard");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModuleSlotInChassisOrCard",
                table: "Modules",
                newName: "CardSlotInChassisOrCard");
        }
    }
}
