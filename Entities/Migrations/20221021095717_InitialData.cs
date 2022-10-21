using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "Country", "Name" },
                values: new object[] { new Guid("e353073c-ef5a-493b-af74-a9b447fe8c1f"), "583 Wall Dr. Gwynn Oak, MD 21207", "USA", "IT_Solutions Ltd" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "Country", "Name" },
                values: new object[] { new Guid("5bcb7027-4c0a-40ce-aa7c-a74e505e643d"), "312 Forest Avenue, BF 923", "USA", "Admin_Solutions Ltd" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), 26, new Guid("e353073c-ef5a-493b-af74-a9b447fe8c1f"), "Sam Raiden", "Software developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 30, new Guid("e353073c-ef5a-493b-af74-a9b447fe8c1f"), "Jana McLeaf", "Software developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 35, new Guid("5bcb7027-4c0a-40ce-aa7c-a74e505e643d"), "Kane Miller", "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("5bcb7027-4c0a-40ce-aa7c-a74e505e643d"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("e353073c-ef5a-493b-af74-a9b447fe8c1f"));
        }
    }
}
