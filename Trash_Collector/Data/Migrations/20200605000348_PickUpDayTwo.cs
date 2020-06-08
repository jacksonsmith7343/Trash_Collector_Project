using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class PickUpDayTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "ExtraPickUp",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfbfaf73-8012-4a90-9781-3dfd9fc90bbc", "2b2202d3-0272-4463-9967-73f9b92a63b4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70a48f88-5f1a-46d0-9242-51db513b730d", "451c5990-bb69-4ed4-b7ee-de9a17d275c0", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "208459b1-4993-4d4a-a2d6-a5e5bf34fe2a", "8772ef99-47f4-4577-a698-d0328e38d863", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "208459b1-4993-4d4a-a2d6-a5e5bf34fe2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70a48f88-5f1a-46d0-9242-51db513b730d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfbfaf73-8012-4a90-9781-3dfd9fc90bbc");

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
    }
}
