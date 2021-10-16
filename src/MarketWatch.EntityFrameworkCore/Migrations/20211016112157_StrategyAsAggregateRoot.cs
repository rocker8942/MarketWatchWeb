using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketWatch.Migrations
{
    public partial class StrategyAsAggregateRoot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "strategy",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "strategy",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "strategy");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "strategy");
        }
    }
}
