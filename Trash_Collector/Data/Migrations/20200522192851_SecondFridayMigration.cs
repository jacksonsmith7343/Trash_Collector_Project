using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class SecondFridayMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01cbe009-e6eb-45f5-bbae-be8488a0b11d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09e49b85-022d-45b9-9048-a814a49edd73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2404680e-ff09-4ae8-9426-36d4d6ed1fc4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a876ffd-309e-4efc-9942-07d6471e56c8", "b0329158-62cc-4865-8c51-f60b8cd7a693", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b600538-f592-4ee2-b38e-ba1129eeba3d", "d682976b-21ce-43db-8b5d-dca6d43765c2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43627a82-7db2-4667-a617-8911f8f0063d", "e2932686-b65e-41f4-8d28-49a9c107704a", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a876ffd-309e-4efc-9942-07d6471e56c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43627a82-7db2-4667-a617-8911f8f0063d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b600538-f592-4ee2-b38e-ba1129eeba3d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01cbe009-e6eb-45f5-bbae-be8488a0b11d", "192fbf54-3d0d-4de2-bc97-9f513df58573", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09e49b85-022d-45b9-9048-a814a49edd73", "47e76446-1563-4b75-8660-9b3b5cac57b8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2404680e-ff09-4ae8-9426-36d4d6ed1fc4", "a3342677-4977-4f1e-9200-7c35fcae4200", "Employee", "Employee" });
        }
    }
}
