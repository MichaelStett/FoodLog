using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodLog.Infrastructure.Migrations
{
    public partial class RemovedCategoryType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryType",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Items",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "CategoryType",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
