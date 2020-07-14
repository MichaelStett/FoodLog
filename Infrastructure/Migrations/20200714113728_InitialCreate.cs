using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodLog.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Grams = table.Column<int>(nullable: false),
                    CategoryType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutrients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    NutrientType = table.Column<int>(nullable: false),
                    Grams = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nutrients_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryType", "Date", "Grams", "Name" },
                values: new object[] { 1, 7, new DateTime(2020, 7, 14, 11, 37, 27, 784, DateTimeKind.Utc).AddTicks(3361), 350, "Tuna" });

            migrationBuilder.InsertData(
                table: "Nutrients",
                columns: new[] { "Id", "Grams", "ItemId", "NutrientType" },
                values: new object[] { 1, 2.1000000000000001, 1, 0 });

            migrationBuilder.InsertData(
                table: "Nutrients",
                columns: new[] { "Id", "Grams", "ItemId", "NutrientType" },
                values: new object[] { 2, 0.0, 1, 1 });

            migrationBuilder.InsertData(
                table: "Nutrients",
                columns: new[] { "Id", "Grams", "ItemId", "NutrientType" },
                values: new object[] { 3, 101.5, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_ItemId",
                table: "Nutrients",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nutrients");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
