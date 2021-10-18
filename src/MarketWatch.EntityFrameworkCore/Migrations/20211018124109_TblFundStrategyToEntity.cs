using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketWatch.Migrations
{
    public partial class TblFundStrategyToEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "tblFundStrategy",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "tblFundStrategy",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "tblFundStrategy");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "tblFundStrategy");
        }
    }
}
