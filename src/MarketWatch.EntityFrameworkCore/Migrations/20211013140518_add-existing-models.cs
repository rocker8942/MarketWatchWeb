using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketWatch.Migrations
{
    public partial class addexistingmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "refSellType",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "stockInfo",
            //    columns: table => new
            //    {
            //        code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
            //        dateIncluded = table.Column<DateTime>(type: "datetime", nullable: true),
            //        country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        enabled = table.Column<bool>(type: "bit", nullable: false),
            //        modifiedAt = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_stockInfo", x => x.code);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "strategy",
            //    columns: table => new
            //    {
            //        id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        InvestTriggerRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        analysisPeriod = table.Column<int>(type: "int", nullable: false),
            //        PortfolioNumber = table.Column<int>(type: "int", nullable: false),
            //        PriceToUse = table.Column<int>(type: "int", nullable: false),
            //        LossCutRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        InvestDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        inUse = table.Column<int>(type: "int", nullable: false),
            //        RatePerInvesmentPeriod = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
            //        ratePerYear = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        daysToTest = table.Column<int>(type: "int", nullable: false),
            //        std = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
            //        InvestStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CountryToInvest = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(((2000)-(1))-(1))"),
            //        Disabled = table.Column<bool>(type: "bit", nullable: false),
            //        CoefficientAllowed = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_strategy", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tblFundStrategy",
            //    columns: table => new
            //    {
            //        id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        InvestTriggerRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        analysisPeriod = table.Column<int>(type: "int", nullable: false),
            //        PortfolioNumber = table.Column<int>(type: "int", nullable: false),
            //        PriceToUse = table.Column<int>(type: "int", nullable: false),
            //        LossCutRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        InvestDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        inUse = table.Column<int>(type: "int", nullable: false),
            //        RatePerInvesmentPeriod = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
            //        ratePerYear = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        daysToTest = table.Column<int>(type: "int", nullable: false),
            //        std = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
            //        InvestStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Disabled = table.Column<bool>(type: "bit", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        CountryToInvest = table.Column<int>(type: "int", nullable: true),
            //        CoefficientAllowed = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tblFundStrategy", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "coefficient_pair",
            //    columns: table => new
            //    {
            //        codeX = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        codeY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        leader = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //        coefficient = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
            //        leading_by = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_coefficient_pair_1", x => new { x.codeX, x.codeY, x.leader });
            //        table.ForeignKey(
            //            name: "FK_coefficient_pair_stockInfo",
            //            column: x => x.codeX,
            //            principalTable: "stockInfo",
            //            principalColumn: "code",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_coefficient_pair_stockInfo1",
            //            column: x => x.codeY,
            //            principalTable: "stockInfo",
            //            principalColumn: "code",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "stockPrice",
            //    columns: table => new
            //    {
            //        code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        currentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        openPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        highPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        lowPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        closePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        volume = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        adjClosePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_stockPrice", x => new { x.code, x.date });
            //        table.ForeignKey(
            //            name: "FK_stockPrice_stockInfo",
            //            column: x => x.code,
            //            principalTable: "stockInfo",
            //            principalColumn: "code",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "stockToAnalysis",
            //    columns: table => new
            //    {
            //        code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        adjClosePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        change = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
            //        currentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        openPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        highPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        lowPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        closePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        volume = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_stockToAnalysis", x => new { x.code, x.date });
            //        table.ForeignKey(
            //            name: "FK_stockToAnalysis_stockInfo",
            //            column: x => x.code,
            //            principalTable: "stockInfo",
            //            principalColumn: "code",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "backtestHistory",
            //    columns: table => new
            //    {
            //        id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        mainLeader = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        leaderChange = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
            //        buyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        sellPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        tradeDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        rateOfReturn = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
            //        strategyId = table.Column<long>(type: "bigint", nullable: false),
            //        followStock = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        nav = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
            //        sellType = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_backtestHistory", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_backtestHistory_strategy",
            //            column: x => x.strategyId,
            //            principalTable: "strategy",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tblFundTradeHistory",
            //    columns: table => new
            //    {
            //        id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        mainLeader = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        leaderChange = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
            //        buyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        sellPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        tradeDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        rateOfReturn = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
            //        strategyId = table.Column<long>(type: "bigint", nullable: false),
            //        followStock = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        nav = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
            //        sellType = table.Column<int>(type: "int", nullable: true),
            //        coefficient = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tblFundTradeHistory", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_tblFundTradeHistory_tblFundStrategy",
            //            column: x => x.strategyId,
            //            principalTable: "tblFundStrategy",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_backtestHistory_strategyId",
            //    table: "backtestHistory",
            //    column: "strategyId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_coefficient_pair_codeY",
            //    table: "coefficient_pair",
            //    column: "codeY");

            //migrationBuilder.CreateIndex(
            //    name: "IX_tblFundTradeHistory_strategyId",
            //    table: "tblFundTradeHistory",
            //    column: "strategyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "backtestHistory");

            migrationBuilder.DropTable(
                name: "coefficient_pair");

            migrationBuilder.DropTable(
                name: "refSellType");

            migrationBuilder.DropTable(
                name: "stockPrice");

            migrationBuilder.DropTable(
                name: "stockToAnalysis");

            migrationBuilder.DropTable(
                name: "tblFundTradeHistory");

            migrationBuilder.DropTable(
                name: "strategy");

            migrationBuilder.DropTable(
                name: "stockInfo");

            migrationBuilder.DropTable(
                name: "tblFundStrategy");
        }
    }
}
