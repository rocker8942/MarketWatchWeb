using System;

using System.ComponentModel.DataAnnotations;
using MarketWatch.Simulation.Dtos;

namespace MarketWatch.Web.Pages.Simulation.BacktestHistory.ViewModels
{
    public class CreateEditBacktestHistoryViewModel
    {
        [Display(Name = "BacktestHistoryMainLeader")]
        public string MainLeader { get; set; }

        [Display(Name = "BacktestHistoryLeaderChange")]
        public decimal LeaderChange { get; set; }

        [Display(Name = "BacktestHistoryBuyPrice")]
        public decimal BuyPrice { get; set; }

        [Display(Name = "BacktestHistorySellPrice")]
        public decimal SellPrice { get; set; }

        [Display(Name = "BacktestHistoryTradeDate")]
        public DateTime TradeDate { get; set; }

        [Display(Name = "BacktestHistoryRateOfReturn")]
        public decimal RateOfReturn { get; set; }

        [Display(Name = "BacktestHistoryStrategyId")]
        public long StrategyId { get; set; }

        [Display(Name = "BacktestHistoryFollowStock")]
        public string FollowStock { get; set; }

        [Display(Name = "BacktestHistoryNav")]
        public decimal? Nav { get; set; }

        [Display(Name = "BacktestHistorySellType")]
        public int? SellType { get; set; }

        [Display(Name = "BacktestHistoryStrategy")]
        public StrategyDto Strategy { get; set; }
    }
}