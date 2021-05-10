using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativeFuneralFundInc.Migrations
{
    public partial class StatusTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplyRequests_Status_StatusID",
                table: "SupplyRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskManagements_Status_StatusID",
                table: "TaskManagements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "Statuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyRequests_Statuses_StatusID",
                table: "SupplyRequests",
                column: "StatusID",
                principalTable: "Statuses",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskManagements_Statuses_StatusID",
                table: "TaskManagements",
                column: "StatusID",
                principalTable: "Statuses",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplyRequests_Statuses_StatusID",
                table: "SupplyRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskManagements_Statuses_StatusID",
                table: "TaskManagements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "Status");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyRequests_Status_StatusID",
                table: "SupplyRequests",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskManagements_Status_StatusID",
                table: "TaskManagements",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
