using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class SeedingRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3985004c-8158-4fcd-b480-95b21ab77ef2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3985004c-8158-4fcd-b480-95b21ab77ef2", "18b13400-2a95-4b6d-83f5-3e897b7d718d", "Admin", "ADMIN" });
        }
    }
}
