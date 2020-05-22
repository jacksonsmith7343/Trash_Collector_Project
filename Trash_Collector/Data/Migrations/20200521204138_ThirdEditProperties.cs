using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class ThirdEditProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PaymentOwed",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "PaymentOwed",
                table: "Customers");

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
    }
}
