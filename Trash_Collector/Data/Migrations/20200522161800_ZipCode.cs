using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class ZipCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408ec563-3fcc-4de5-b946-5e6db1d5b2b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b21cab2-5503-4fcd-a7ab-e0891808a45b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdf41820-4882-4f8e-87da-2eabe806396a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f7ad429-6d3c-4424-a12f-19e893e661f2", "a839f67d-0212-4b0f-ad5d-c6733b53b4c6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "efb02aa7-e307-4e96-83f1-d52fe20e6513", "145be6d1-6024-4fcb-9b45-13b11b3dda27", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "14bf75a1-e041-441c-b2de-a4e25d6bb835", "f11a3f5d-526f-4c45-9da7-069fcd9a61f6", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f7ad429-6d3c-4424-a12f-19e893e661f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14bf75a1-e041-441c-b2de-a4e25d6bb835");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efb02aa7-e307-4e96-83f1-d52fe20e6513");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b21cab2-5503-4fcd-a7ab-e0891808a45b", "c17891d4-f95a-4a42-8272-684004997fa7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdf41820-4882-4f8e-87da-2eabe806396a", "a36b4f22-07a9-45ad-85f8-9e94b3997655", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "408ec563-3fcc-4de5-b946-5e6db1d5b2b6", "75eba340-802f-4185-98be-a1229f7ab921", "Employee", "Employee" });
        }
    }
}
