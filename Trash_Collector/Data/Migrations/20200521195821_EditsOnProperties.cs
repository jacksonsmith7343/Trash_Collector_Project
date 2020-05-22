using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class EditsOnProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76523ec3-a3f8-4930-8425-8843368bcf5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77cac31d-1743-438c-98ac-e42638931887");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec2566ac-9d1a-458e-bdfc-6ec758bc8f14");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b119b786-fdc5-453d-84a7-cf0f1d5f4abf", "dd359917-2065-4a70-9f68-daa74887355f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "471cc3b1-c86c-464a-b13a-b1d8fc0b5caa", "564521d6-ff5e-4cde-bc30-70566e30891f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ff3eaaf-4e11-44bf-8560-b0f57614171c", "e5efaf52-6085-41dd-ae2b-529ff3a433c6", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ff3eaaf-4e11-44bf-8560-b0f57614171c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "471cc3b1-c86c-464a-b13a-b1d8fc0b5caa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b119b786-fdc5-453d-84a7-cf0f1d5f4abf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77cac31d-1743-438c-98ac-e42638931887", "ef785ec9-ca94-4942-b403-ffda7eb0ea1d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76523ec3-a3f8-4930-8425-8843368bcf5f", "817b45e8-4335-470f-9399-c45d053e96d9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec2566ac-9d1a-458e-bdfc-6ec758bc8f14", "e5acadbd-ef34-4135-9241-ab1ea032c025", "Employee", "Employee" });
        }
    }
}
