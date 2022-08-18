using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class Minor_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "DetailRecord");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "DetailRecord",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
