using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class ChangedPaymentOwedProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17da1775-036c-4a1a-9c3e-5a2f165578ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d9f75b5-102d-462e-912c-d19380c6be9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2cc8c13-9c66-403a-b8ef-1812c4d6f52c");

            migrationBuilder.DropColumn(
                name: "PaymentOwed",
                table: "Customers");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PaymentOwed",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d9f75b5-102d-462e-912c-d19380c6be9b", "af1f64c3-3013-4fe8-8d7b-e33943cdbfed", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2cc8c13-9c66-403a-b8ef-1812c4d6f52c", "64145e6f-7456-4c3a-bdda-65b65e058472", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17da1775-036c-4a1a-9c3e-5a2f165578ed", "09628ac9-c00b-40ff-827e-bf861ce04d0d", "Employee", "Employee" });
        }
    }
}
