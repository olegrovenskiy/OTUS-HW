using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class RenameToContract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Racks_Rows_RoomRowId",
            //    table: "Racks");

            //migrationBuilder.DropIndex(
            //    name: "IX_Racks_RoomRowId",
            //    table: "Racks");

           // migrationBuilder.DropColumn(
           //     name: "RoomRowId",
           //     table: "Racks");

            migrationBuilder.RenameColumn(
                name: "DocumentNumber",
                table: "DetailRecord",
                newName: "ContractNumber");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Racks_RowId",
            //    table: "Racks",
            //    column: "RowId");

           // migrationBuilder.AddForeignKey(
           //     name: "FK_Racks_Rows_RowId",
           //     table: "Racks",
           //     column: "RowId",
           //     principalTable: "Rows",
           //     principalColumn: "RowId",
           //     onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Racks_Rows_RowId",
                table: "Racks");

            migrationBuilder.DropIndex(
                name: "IX_Racks_RowId",
                table: "Racks");

            migrationBuilder.RenameColumn(
                name: "ContractNumber",
                table: "DetailRecord",
                newName: "DocumentNumber");

            migrationBuilder.AddColumn<int>(
                name: "RoomRowId",
                table: "Racks",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Racks_RoomRowId",
                table: "Racks",
                column: "RoomRowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Racks_Rows_RoomRowId",
                table: "Racks",
                column: "RoomRowId",
                principalTable: "Rows",
                principalColumn: "RowId");
        }
    }
}
