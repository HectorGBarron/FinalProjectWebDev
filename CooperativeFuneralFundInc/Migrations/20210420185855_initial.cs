using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativeFuneralFundInc.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientSuppliers",
                columns: table => new
                {
                    ClientSupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientSupplierName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSuppliers", x => x.ClientSupplierID);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderItemsName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemsID);
                });

            migrationBuilder.CreateTable(
                name: "OwnerNames",
                columns: table => new
                {
                    OwnerNameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerNameName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerNames", x => x.OwnerNameID);
                });

            migrationBuilder.CreateTable(
                name: "SupplyRequestStatus",
                columns: table => new
                {
                    SupplyRequestStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyRequestStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyRequestStatus", x => x.SupplyRequestStatusID);
                });

            migrationBuilder.CreateTable(
                name: "SupplyRequestTypes",
                columns: table => new
                {
                    SupplyRequestTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyRequestTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyRequestTypes", x => x.SupplyRequestTypeID);
                });

            migrationBuilder.CreateTable(
                name: "SuppyRequestOrigins",
                columns: table => new
                {
                    SuppyRequestOriginId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuppyRequestOriginName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppyRequestOrigins", x => x.SuppyRequestOriginId);
                });

            migrationBuilder.CreateTable(
                name: "SupplyRequests",
                columns: table => new
                {
                    SupplyRequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyRequestStatusID = table.Column<int>(nullable: false),
                    StatusComments = table.Column<string>(nullable: true),
                    OrderItemsID = table.Column<int>(nullable: false),
                    SuppyRequestOriginId = table.Column<int>(nullable: false),
                    SupplyRequestTypeID = table.Column<int>(nullable: false),
                    ClientSupplierID = table.Column<int>(nullable: false),
                    OwnerNameID = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreateTime = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyRequests", x => x.SupplyRequestId);
                    table.ForeignKey(
                        name: "FK_SupplyRequests_ClientSuppliers_ClientSupplierID",
                        column: x => x.ClientSupplierID,
                        principalTable: "ClientSuppliers",
                        principalColumn: "ClientSupplierID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyRequests_OrderItems_OrderItemsID",
                        column: x => x.OrderItemsID,
                        principalTable: "OrderItems",
                        principalColumn: "OrderItemsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyRequests_OwnerNames_OwnerNameID",
                        column: x => x.OwnerNameID,
                        principalTable: "OwnerNames",
                        principalColumn: "OwnerNameID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyRequests_SupplyRequestStatus_SupplyRequestStatusID",
                        column: x => x.SupplyRequestStatusID,
                        principalTable: "SupplyRequestStatus",
                        principalColumn: "SupplyRequestStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyRequests_SupplyRequestTypes_SupplyRequestTypeID",
                        column: x => x.SupplyRequestTypeID,
                        principalTable: "SupplyRequestTypes",
                        principalColumn: "SupplyRequestTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyRequests_SuppyRequestOrigins_SuppyRequestOriginId",
                        column: x => x.SuppyRequestOriginId,
                        principalTable: "SuppyRequestOrigins",
                        principalColumn: "SuppyRequestOriginId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotesSection",
                columns: table => new
                {
                    NotesSectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyRequestId = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Archived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotesSection", x => x.NotesSectionId);
                    table.ForeignKey(
                        name: "FK_NotesSection_SupplyRequests_SupplyRequestId",
                        column: x => x.SupplyRequestId,
                        principalTable: "SupplyRequests",
                        principalColumn: "SupplyRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ClientSuppliers",
                columns: new[] { "ClientSupplierID", "ClientSupplierName" },
                values: new object[,]
                {
                    { 1, "Client 1" },
                    { 2, "Client 2" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemsID", "OrderItemsName" },
                values: new object[,]
                {
                    { 11, "Investment election form" },
                    { 10, "Service and merchandise forms" },
                    { 9, "Monthly monitors" },
                    { 8, "Funding your funeral in advance brochure" },
                    { 7, "Planning guides" },
                    { 12, "Other" },
                    { 5, "Postage paid envelopes." },
                    { 4, "Return envelopes." },
                    { 3, "Itemizations form" },
                    { 2, "Account update/Claim form" },
                    { 1, "Preneed agreement" },
                    { 6, "Deposit tickets" }
                });

            migrationBuilder.InsertData(
                table: "OwnerNames",
                columns: new[] { "OwnerNameID", "OwnerNameName" },
                values: new object[] { 1, "Person 1" });

            migrationBuilder.InsertData(
                table: "SupplyRequestStatus",
                columns: new[] { "SupplyRequestStatusID", "SupplyRequestStatusName" },
                values: new object[,]
                {
                    { 5, "Cancelled" },
                    { 4, "On hold" },
                    { 3, "Completed" },
                    { 1, "New" },
                    { 2, "In-Process" }
                });

            migrationBuilder.InsertData(
                table: "SupplyRequestTypes",
                columns: new[] { "SupplyRequestTypeID", "SupplyRequestTypeName" },
                values: new object[,]
                {
                    { 1, "Vendor" },
                    { 2, "Client" }
                });

            migrationBuilder.InsertData(
                table: "SuppyRequestOrigins",
                columns: new[] { "SuppyRequestOriginId", "SuppyRequestOriginName" },
                values: new object[,]
                {
                    { 5, "Regional manager" },
                    { 1, "Phone" },
                    { 2, "Fax" },
                    { 3, "Email" },
                    { 4, "Mail" },
                    { 6, "Other" }
                });

            migrationBuilder.InsertData(
                table: "SupplyRequests",
                columns: new[] { "SupplyRequestId", "ClientSupplierID", "CreateTime", "CreatedBy", "OrderItemsID", "OwnerNameID", "StatusComments", "SupplyRequestStatusID", "SupplyRequestTypeID", "SuppyRequestOriginId", "UpdatedBy", "UpdatedTime" },
                values: new object[] { 1, 1, "Test", "Test", 1, 1, "test", 1, 1, 1, "Test", null });

            migrationBuilder.InsertData(
                table: "NotesSection",
                columns: new[] { "NotesSectionId", "Archived", "CreatedBy", "CreatedDate", "Note", "SupplyRequestId" },
                values: new object[] { 1, false, "Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test note", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_NotesSection_SupplyRequestId",
                table: "NotesSection",
                column: "SupplyRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_ClientSupplierID",
                table: "SupplyRequests",
                column: "ClientSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_OrderItemsID",
                table: "SupplyRequests",
                column: "OrderItemsID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_OwnerNameID",
                table: "SupplyRequests",
                column: "OwnerNameID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_SupplyRequestStatusID",
                table: "SupplyRequests",
                column: "SupplyRequestStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_SupplyRequestTypeID",
                table: "SupplyRequests",
                column: "SupplyRequestTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_SuppyRequestOriginId",
                table: "SupplyRequests",
                column: "SuppyRequestOriginId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotesSection");

            migrationBuilder.DropTable(
                name: "SupplyRequests");

            migrationBuilder.DropTable(
                name: "ClientSuppliers");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "OwnerNames");

            migrationBuilder.DropTable(
                name: "SupplyRequestStatus");

            migrationBuilder.DropTable(
                name: "SupplyRequestTypes");

            migrationBuilder.DropTable(
                name: "SuppyRequestOrigins");
        }
    }
}
