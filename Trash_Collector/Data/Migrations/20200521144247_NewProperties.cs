using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class NewProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647b521d-76be-4193-87b2-136adf95f7c0");

            migrationBuilder.DropColumn(
                name: "RequestExtraPickUp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StartEndPickUpDay",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "ContinuePickUpDay",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraPickUp",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuspendPickUpDay",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3985004c-8158-4fcd-b480-95b21ab77ef2", "18b13400-2a95-4b6d-83f5-3e897b7d718d", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3985004c-8158-4fcd-b480-95b21ab77ef2");

            migrationBuilder.DropColumn(
                name: "ContinuePickUpDay",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ExtraPickUp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SuspendPickUpDay",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "RequestExtraPickUp",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartEndPickUpDay",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "647b521d-76be-4193-87b2-136adf95f7c0", "ca8c67f8-7453-49ed-800d-36da1a320a06", "Admin", "ADMIN" });
        }
    }
}
