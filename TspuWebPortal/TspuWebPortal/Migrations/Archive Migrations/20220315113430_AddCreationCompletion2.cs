using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TspuWebPortal.Migrations
{
    public partial class AddCreationCompletion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailChange_RequestCompletionData_RequestCompletionId",
                table: "DetailChange");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailChange_RequestCreationData_RequestCreationId",
                table: "DetailChange");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_ModuleAData_ModuleAId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_ModuleBData_ModuleBId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleAData_Modules_ModuleId",
                table: "ModuleAData");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleBData_Modules_ModuleId",
                table: "ModuleBData");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestCompletionData_OperationData_OperationId",
                table: "RequestCompletionData");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestCreationData_OperationData_OperationId",
                table: "RequestCreationData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestCreationData",
                table: "RequestCreationData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestCompletionData",
                table: "RequestCompletionData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModuleBData",
                table: "ModuleBData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModuleAData",
                table: "ModuleAData");

            migrationBuilder.RenameTable(
                name: "RequestCreationData",
                newName: "CreationRequests");

            migrationBuilder.RenameTable(
                name: "RequestCompletionData",
                newName: "CompletionRequests");

            migrationBuilder.RenameTable(
                name: "ModuleBData",
                newName: "ModulesB");

            migrationBuilder.RenameTable(
                name: "ModuleAData",
                newName: "ModulesA");

            migrationBuilder.RenameIndex(
                name: "IX_RequestCreationData_OperationId",
                table: "CreationRequests",
                newName: "IX_CreationRequests_OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_RequestCompletionData_OperationId",
                table: "CompletionRequests",
                newName: "IX_CompletionRequests_OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleBData_ModuleId",
                table: "ModulesB",
                newName: "IX_ModulesB_ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleAData_ModuleId",
                table: "ModulesA",
                newName: "IX_ModulesA_ModuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreationRequests",
                table: "CreationRequests",
                column: "RequestCreationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompletionRequests",
                table: "CompletionRequests",
                column: "RequestCompletionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModulesB",
                table: "ModulesB",
                column: "ModuleBId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModulesA",
                table: "ModulesA",
                column: "ModuleAId");

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
                name: "FK_DetailChange_CompletionRequests_RequestCompletionId",
                table: "DetailChange",
                column: "RequestCompletionId",
                principalTable: "CompletionRequests",
                principalColumn: "RequestCompletionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailChange_CreationRequests_RequestCreationId",
                table: "DetailChange",
                column: "RequestCreationId",
                principalTable: "CreationRequests",
                principalColumn: "RequestCreationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_ModulesA_ModuleAId",
                table: "Links",
                column: "ModuleAId",
                principalTable: "ModulesA",
                principalColumn: "ModuleAId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_ModulesB_ModuleBId",
                table: "Links",
                column: "ModuleBId",
                principalTable: "ModulesB",
                principalColumn: "ModuleBId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModulesA_Modules_ModuleId",
                table: "ModulesA",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModulesB_Modules_ModuleId",
                table: "ModulesB",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletionRequests_OperationData_OperationId",
                table: "CompletionRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CreationRequests_OperationData_OperationId",
                table: "CreationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailChange_CompletionRequests_RequestCompletionId",
                table: "DetailChange");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailChange_CreationRequests_RequestCreationId",
                table: "DetailChange");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_ModulesA_ModuleAId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_ModulesB_ModuleBId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulesA_Modules_ModuleId",
                table: "ModulesA");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulesB_Modules_ModuleId",
                table: "ModulesB");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModulesB",
                table: "ModulesB");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModulesA",
                table: "ModulesA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreationRequests",
                table: "CreationRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompletionRequests",
                table: "CompletionRequests");

            migrationBuilder.RenameTable(
                name: "ModulesB",
                newName: "ModuleBData");

            migrationBuilder.RenameTable(
                name: "ModulesA",
                newName: "ModuleAData");

            migrationBuilder.RenameTable(
                name: "CreationRequests",
                newName: "RequestCreationData");

            migrationBuilder.RenameTable(
                name: "CompletionRequests",
                newName: "RequestCompletionData");

            migrationBuilder.RenameIndex(
                name: "IX_ModulesB_ModuleId",
                table: "ModuleBData",
                newName: "IX_ModuleBData_ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_ModulesA_ModuleId",
                table: "ModuleAData",
                newName: "IX_ModuleAData_ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_CreationRequests_OperationId",
                table: "RequestCreationData",
                newName: "IX_RequestCreationData_OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_CompletionRequests_OperationId",
                table: "RequestCompletionData",
                newName: "IX_RequestCompletionData_OperationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModuleBData",
                table: "ModuleBData",
                column: "ModuleBId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModuleAData",
                table: "ModuleAData",
                column: "ModuleAId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestCreationData",
                table: "RequestCreationData",
                column: "RequestCreationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestCompletionData",
                table: "RequestCompletionData",
                column: "RequestCompletionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailChange_RequestCompletionData_RequestCompletionId",
                table: "DetailChange",
                column: "RequestCompletionId",
                principalTable: "RequestCompletionData",
                principalColumn: "RequestCompletionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailChange_RequestCreationData_RequestCreationId",
                table: "DetailChange",
                column: "RequestCreationId",
                principalTable: "RequestCreationData",
                principalColumn: "RequestCreationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_ModuleAData_ModuleAId",
                table: "Links",
                column: "ModuleAId",
                principalTable: "ModuleAData",
                principalColumn: "ModuleAId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_ModuleBData_ModuleBId",
                table: "Links",
                column: "ModuleBId",
                principalTable: "ModuleBData",
                principalColumn: "ModuleBId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleAData_Modules_ModuleId",
                table: "ModuleAData",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleBData_Modules_ModuleId",
                table: "ModuleBData",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestCompletionData_OperationData_OperationId",
                table: "RequestCompletionData",
                column: "OperationId",
                principalTable: "OperationData",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestCreationData_OperationData_OperationId",
                table: "RequestCreationData",
                column: "OperationId",
                principalTable: "OperationData",
                principalColumn: "OperationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
