using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativeFuneralFundInc.Migrations
{
    public partial class TaskManagementAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskManagement",
                columns: table => new
                {
                    TaskManagementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusID = table.Column<int>(nullable: false),
                    OwnerID = table.Column<int>(nullable: false),
                    RelatedTo = table.Column<string>(nullable: true),
                    RelatedToName = table.Column<string>(nullable: true),
                    RequestTypeID = table.Column<int>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskManagement", x => x.TaskManagementId);
                    table.ForeignKey(
                        name: "FK_TaskManagement_OwnerNames_OwnerID",
                        column: x => x.OwnerID,
                        principalTable: "OwnerNames",
                        principalColumn: "OwnerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskManagement_SupplyRequestTypes_RequestTypeID",
                        column: x => x.RequestTypeID,
                        principalTable: "SupplyRequestTypes",
                        principalColumn: "RequestTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskManagement_Status_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TaskManagement",
                columns: new[] { "TaskManagementId", "CreateBy", "CreatedTime", "OwnerID", "Priority", "RelatedTo", "RelatedToName", "RequestTypeID", "StatusID", "UpdatedBy", "UpdatedTime" },
                values: new object[] { 1, "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Test", "Test", 1, 1, "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_TaskManagement_OwnerID",
                table: "TaskManagement",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskManagement_RequestTypeID",
                table: "TaskManagement",
                column: "RequestTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskManagement_StatusID",
                table: "TaskManagement",
                column: "StatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskManagement");
        }
    }
}
