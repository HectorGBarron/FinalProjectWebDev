using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativeFuneralFundInc.Migrations
{
    public partial class PhoneTypeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NumberTypes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "NumberTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "home", "Home" },
                    { "mobile", "Mobile" },
                    { "work", "work" },
                    { "other", "Other" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NumberTypes");
        }
    }
}
