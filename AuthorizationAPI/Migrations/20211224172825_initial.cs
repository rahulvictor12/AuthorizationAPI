using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthorizationAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BanTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "Address", "BanTime", "Counter", "Password", "Username" },
                values: new object[] { 1, "Mumbai", new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "AA1XB/Cq7PZ3vJEiHT/t7jIHQ66zgDCssxk3wHYADez4kw87v48lfyJpXQQKOJBfaA==", "admin" });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "Address", "BanTime", "Counter", "Password", "Username" },
                values: new object[] { 2, "Delhi", new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "AG7jjWQQzRbN4j5eEz4uLkhEZ5+A5UC9z3OV7fItzKlO1nbxeKloIhGr9qf5jfLX4w==", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDetails");
        }
    }
}
