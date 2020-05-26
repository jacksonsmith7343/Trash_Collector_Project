using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class EmployeeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99a2ec1f-b4e7-424d-9f21-6a08a9a73901", "1dccc00c-4dde-436f-a47b-45775d5deda4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "043148bf-1be1-4424-9850-a90b9f8ea8e4", "c63625fb-f7b4-4786-9116-19cd147afebb", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89df4e24-d670-47de-9d30-bc1698b27f37", "520afb82-8705-4948-857f-4616ed8c3e65", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "043148bf-1be1-4424-9850-a90b9f8ea8e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89df4e24-d670-47de-9d30-bc1698b27f37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99a2ec1f-b4e7-424d-9f21-6a08a9a73901");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employees");

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
    }
}
