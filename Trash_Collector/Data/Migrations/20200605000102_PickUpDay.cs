using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class PickUpDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "450e3d06-7046-4ccf-9f31-dac0b1ddbc5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aec3695-f830-4faf-bb03-2bd822146667");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc6ea4b6-3d3a-44f9-a353-5eda1a465192");

            migrationBuilder.DropColumn(
                name: "ExtraPickUp",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "058d49ac-183f-419c-9837-8833702f86d5", "1fe58cc2-f01b-4a39-a5a6-edb2814859c7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44e64887-2646-473e-9313-e249e0fc6687", "5a0ab32f-dccc-4618-bcd7-e14c6d888541", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff24bc5a-05e4-4d1e-9cd3-94a8fb9cf88e", "4d2ef37d-0217-4955-af60-363aef3113dc", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "058d49ac-183f-419c-9837-8833702f86d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44e64887-2646-473e-9313-e249e0fc6687");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff24bc5a-05e4-4d1e-9cd3-94a8fb9cf88e");

            migrationBuilder.AddColumn<string>(
                name: "ExtraPickUp",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc6ea4b6-3d3a-44f9-a353-5eda1a465192", "6fb73f95-1e28-454a-8d6d-b9999143eafe", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "450e3d06-7046-4ccf-9f31-dac0b1ddbc5e", "31c1644a-c46e-48aa-a2d0-a990ae79e679", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8aec3695-f830-4faf-bb03-2bd822146667", "6a744d27-4017-418e-a2cf-58394bb61de8", "Employee", "Employee" });
        }
    }
}
