using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class AddOperations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletionRequests_OperationData_OperationId",
                table: "CompletionRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CreationRequests_OperationData_OperationId",
                table: "CreationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_OperationData_OperationId",
                table: "DetailRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialRecord_OperationData_OperationId",
                table: "MaterialRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_OperationData_UserAccounts_UserListAccountId",
                table: "OperationData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OperationData",
                table: "OperationData");

            migrationBuilder.RenameTable(
                name: "OperationData",
                newName: "Operations");

            migrationBuilder.RenameIndex(
                name: "IX_OperationData_UserListAccountId",
                table: "Operations",
                newName: "IX_Operations_UserListAccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operations",
                table: "Operations",
                column: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletionRequests_Operations_OperationId",
                table: "CompletionRequests",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreationRequests_Operations_OperationId",
                table: "CreationRequests",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_Operations_OperationId",
                table: "DetailRecord",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialRecord_Operations_OperationId",
                table: "MaterialRecord",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_UserAccounts_UserListAccountId",
                table: "Operations",
                column: "UserListAccountId",
                principalTable: "UserAccounts",
                principalColumn: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletionRequests_Operations_OperationId",
                table: "CompletionRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CreationRequests_Operations_OperationId",
                table: "CreationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailRecord_Operations_OperationId",
                table: "DetailRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialRecord_Operations_OperationId",
                table: "MaterialRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_UserAccounts_UserListAccountId",
                table: "Operations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operations",
                table: "Operations");

            migrationBuilder.RenameTable(
                name: "Operations",
                newName: "OperationData");

            migrationBuilder.RenameIndex(
                name: "IX_Operations_UserListAccountId",
                table: "OperationData",
                newName: "IX_OperationData_UserListAccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OperationData",
                table: "OperationData",
                column: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletionRequests_OperationData_OperationId",
                table: "CompletionRequests",
                column: "OperationId",
                principalTable: "OperationData",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreationRequests_OperationData_OperationId",
                table: "CreationRequests",
                column: "OperationId",
                principalTable: "OperationData",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailRecord_OperationData_OperationId",
                table: "DetailRecord",
                column: "OperationId",
                principalTable: "OperationData",
                principalColumn: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialRecord_OperationData_OperationId",
                table: "MaterialRecord",
                column: "OperationId",
                principalTable: "OperationData",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OperationData_UserAccounts_UserListAccountId",
                table: "OperationData",
                column: "UserListAccountId",
                principalTable: "UserAccounts",
                principalColumn: "AccountId");
        }
    }
}
