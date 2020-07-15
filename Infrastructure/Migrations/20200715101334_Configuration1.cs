using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodLog.Infrastructure.Migrations
{
    public partial class Configuration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Nutrients",
                table: "Nutrients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nutrients",
                table: "Nutrients",
                columns: new[] { "Id", "ItemId" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Utc));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Nutrients",
                table: "Nutrients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nutrients",
                table: "Nutrients",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 7, 14, 12, 14, 12, 845, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 7, 14, 12, 14, 12, 845, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 7, 14, 12, 14, 12, 845, DateTimeKind.Utc).AddTicks(4987));
        }
    }
}
