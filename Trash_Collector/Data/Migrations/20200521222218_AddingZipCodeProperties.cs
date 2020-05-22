using Microsoft.EntityFrameworkCore.Migrations;



namespace Trash_Collector.Data.Migrations
{
    public partial class AddingZipCodeProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "085d22a4-21db-4193-9e73-1cad2904060e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12b64faa-79a9-441e-a9b8-41191d8af1d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ed0579f-0497-4292-b7c2-5ebdabce793f");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Customers",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12b64faa-79a9-441e-a9b8-41191d8af1d8", "ff26d2f9-a9f1-464b-b476-41649b9f8d9d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ed0579f-0497-4292-b7c2-5ebdabce793f", "b4ca1713-7b52-4f00-a638-901a077e7131", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "085d22a4-21db-4193-9e73-1cad2904060e", "7a1b7d7a-8b26-47b6-9b52-b940d9803070", "Employee", "Employee" });
        }
    }
}
