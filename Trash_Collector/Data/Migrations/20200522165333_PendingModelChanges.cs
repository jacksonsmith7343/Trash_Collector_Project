using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class PendingModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3b99f349-7379-4067-8240-83eb7e58252c", "a064bca3-083c-4f31-8c35-d9b71651bec7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67b1cf3d-9f2e-4147-8ecf-4a0d20df7d5d", "3a1d6615-884e-46f3-99a1-94fec907b4cb", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17ca762b-9c13-412d-b9ec-b0a105b0013c", "818bfc93-9007-4ecf-b5f1-6483be21fa90", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17ca762b-9c13-412d-b9ec-b0a105b0013c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b99f349-7379-4067-8240-83eb7e58252c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67b1cf3d-9f2e-4147-8ecf-4a0d20df7d5d");

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
    }
}
