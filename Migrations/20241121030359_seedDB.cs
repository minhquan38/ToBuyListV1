using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToBuyListV1.Migrations
{
    /// <inheritdoc />
    public partial class seedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DisplayName", "Email", "OAuthId" },
                values: new object[,]
                {
                    { 1, "John Doe", "user1@example.com", "google-oauth-id-1" },
                    { 2, "Jane Smith", "user2@example.com", "google-oauth-id-2" }
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "Id", "MonthlyBudget", "TotalSpent", "UserId", "YearlyBudget" },
                values: new object[,]
                {
                    { 1, 2000.00m, 500.00m, 1, 24000.00m },
                    { 2, 1500.00m, 300.00m, 2, 18000.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsPurchased", "LastUpdated", "Name", "Price", "Priority", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2024, 11, 21, 3, 3, 58, 652, DateTimeKind.Utc).AddTicks(386), "Laptop", 1200.00m, 1, "https://example.com/laptop", 1 },
                    { 2, false, new DateTime(2024, 11, 14, 3, 3, 58, 652, DateTimeKind.Utc).AddTicks(1388), "Smartphone", 800.00m, 2, "https://example.com/smartphone", 1 },
                    { 3, true, new DateTime(2024, 11, 21, 3, 3, 58, 652, DateTimeKind.Utc).AddTicks(1558), "Headphones", 150.00m, 3, "https://example.com/headphones", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }
    }
}
