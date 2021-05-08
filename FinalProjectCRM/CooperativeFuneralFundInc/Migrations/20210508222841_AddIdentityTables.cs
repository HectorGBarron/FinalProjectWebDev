using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativeFuneralFundInc.Migrations
{
    public partial class AddIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    firstName = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false),
                    numberType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                    OwnerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerNames", x => x.OwnerID);
                });

            migrationBuilder.CreateTable(
                name: "RequestOrigins",
                columns: table => new
                {
                    RequestOriginId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestOriginDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestOrigins", x => x.RequestOriginId);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "SupplyRequestTypes",
                columns: table => new
                {
                    RequestTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyRequestTypes", x => x.RequestTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotesSection",
                columns: table => new
                {
                    NotesSectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestOriginId = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Archived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotesSection", x => x.NotesSectionId);
                    table.ForeignKey(
                        name: "FK_NotesSection_RequestOrigins_RequestOriginId",
                        column: x => x.RequestOriginId,
                        principalTable: "RequestOrigins",
                        principalColumn: "RequestOriginId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplyRequests",
                columns: table => new
                {
                    SupplyRequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusID = table.Column<int>(nullable: false),
                    StatusComments = table.Column<string>(nullable: true),
                    OrderItemsID = table.Column<int>(nullable: false),
                    RequestOriginId = table.Column<int>(nullable: false),
                    RequestTypeID = table.Column<int>(nullable: false),
                    ClientSupplierID = table.Column<int>(nullable: false),
                    OwnerID = table.Column<int>(nullable: false),
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
                        name: "FK_SupplyRequests_OwnerNames_OwnerID",
                        column: x => x.OwnerID,
                        principalTable: "OwnerNames",
                        principalColumn: "OwnerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyRequests_RequestOrigins_RequestOriginId",
                        column: x => x.RequestOriginId,
                        principalTable: "RequestOrigins",
                        principalColumn: "RequestOriginId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyRequests_SupplyRequestTypes_RequestTypeID",
                        column: x => x.RequestTypeID,
                        principalTable: "SupplyRequestTypes",
                        principalColumn: "RequestTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyRequests_Status_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskManagements",
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
                    table.PrimaryKey("PK_TaskManagements", x => x.TaskManagementId);
                    table.ForeignKey(
                        name: "FK_TaskManagements_OwnerNames_OwnerID",
                        column: x => x.OwnerID,
                        principalTable: "OwnerNames",
                        principalColumn: "OwnerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskManagements_SupplyRequestTypes_RequestTypeID",
                        column: x => x.RequestTypeID,
                        principalTable: "SupplyRequestTypes",
                        principalColumn: "RequestTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskManagements_Status_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "StatusID",
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
                columns: new[] { "OwnerID", "OwnerName" },
                values: new object[] { 1, "Person 1" });

            migrationBuilder.InsertData(
                table: "RequestOrigins",
                columns: new[] { "RequestOriginId", "RequestOriginDescription" },
                values: new object[,]
                {
                    { 6, "Other" },
                    { 5, "Regional manager" },
                    { 4, "Mail" },
                    { 3, "Email" },
                    { 1, "Phone" },
                    { 2, "Fax" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusID", "StatusDescription" },
                values: new object[,]
                {
                    { 4, "On hold" },
                    { 1, "New" },
                    { 2, "In-Process" },
                    { 3, "Completed" },
                    { 5, "Cancelled" }
                });

            migrationBuilder.InsertData(
                table: "SupplyRequestTypes",
                columns: new[] { "RequestTypeID", "RequestTypeDescription" },
                values: new object[,]
                {
                    { 1, "Vendor" },
                    { 2, "Client" }
                });

            migrationBuilder.InsertData(
                table: "NotesSection",
                columns: new[] { "NotesSectionId", "Archived", "CreatedBy", "CreatedDate", "Note", "RequestOriginId" },
                values: new object[] { 1, false, "Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test note", 1 });

            migrationBuilder.InsertData(
                table: "SupplyRequests",
                columns: new[] { "SupplyRequestId", "ClientSupplierID", "CreateTime", "CreatedBy", "OrderItemsID", "OwnerID", "RequestOriginId", "RequestTypeID", "StatusComments", "StatusID", "UpdatedBy", "UpdatedTime" },
                values: new object[] { 1, 1, "Test", "Test", 1, 1, 1, 1, "test", 1, "Test", null });

            migrationBuilder.InsertData(
                table: "TaskManagements",
                columns: new[] { "TaskManagementId", "CreateBy", "CreatedTime", "OwnerID", "Priority", "RelatedTo", "RelatedToName", "RequestTypeID", "StatusID", "UpdatedBy", "UpdatedTime" },
                values: new object[] { 1, "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Test", "Test", 1, 1, "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NotesSection_RequestOriginId",
                table: "NotesSection",
                column: "RequestOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_ClientSupplierID",
                table: "SupplyRequests",
                column: "ClientSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_OrderItemsID",
                table: "SupplyRequests",
                column: "OrderItemsID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_OwnerID",
                table: "SupplyRequests",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_RequestOriginId",
                table: "SupplyRequests",
                column: "RequestOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_RequestTypeID",
                table: "SupplyRequests",
                column: "RequestTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyRequests_StatusID",
                table: "SupplyRequests",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskManagements_OwnerID",
                table: "TaskManagements",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskManagements_RequestTypeID",
                table: "TaskManagements",
                column: "RequestTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskManagements_StatusID",
                table: "TaskManagements",
                column: "StatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "NotesSection");

            migrationBuilder.DropTable(
                name: "SupplyRequests");

            migrationBuilder.DropTable(
                name: "TaskManagements");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ClientSuppliers");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "RequestOrigins");

            migrationBuilder.DropTable(
                name: "OwnerNames");

            migrationBuilder.DropTable(
                name: "SupplyRequestTypes");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
