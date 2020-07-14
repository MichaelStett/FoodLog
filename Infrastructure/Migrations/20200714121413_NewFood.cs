using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodLog.Infrastructure.Migrations
{
    public partial class NewFood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 14, 12, 14, 12, 845, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryType", "Date", "Grams", "Name" },
                values: new object[,]
                {
                    { 2, 0, new DateTime(2020, 7, 14, 12, 14, 12, 845, DateTimeKind.Utc).AddTicks(4984), 300, "Potato" },
                    { 3, 8, new DateTime(2020, 7, 14, 12, 14, 12, 845, DateTimeKind.Utc).AddTicks(4987), 100, "Mozzarella" }
                });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Grams",
                value: 1.3);

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Grams",
                value: 28.0);

            migrationBuilder.InsertData(
                table: "Nutrients",
                columns: new[] { "Id", "Grams", "ItemId", "NutrientType" },
                values: new object[,]
                {
                    { 4, 0.089999999999999997, 2, 0 },
                    { 5, 17.0, 2, 1 },
                    { 6, 2.0, 2, 2 },
                    { 7, 17.0, 3, 0 },
                    { 8, 3.1000000000000001, 3, 1 },
                    { 9, 28.0, 3, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 14, 11, 37, 27, 784, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Grams",
                value: 2.1000000000000001);

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Grams",
                value: 101.5);
        }
    }
}
