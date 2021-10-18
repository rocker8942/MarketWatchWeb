using System;

using System.ComponentModel.DataAnnotations;

namespace MarketWatch.Web.Pages.Simulation.FundTradeHistory.ViewModels
{
    public class CreateEditFundTradeHistoryViewModel
    {
        [Display(Name = "FundTradeHistoryMainLeader")]
        public string MainLeader { get; set; }

        [Display(Name = "FundTradeHistoryLeaderChange")]
        public decimal LeaderChange { get; set; }

        [Display(Name = "FundTradeHistoryBuyPrice")]
        public decimal BuyPrice { get; set; }

        [Display(Name = "FundTradeHistorySellPrice")]
        public decimal SellPrice { get; set; }

        [Display(Name = "FundTradeHistoryTradeDate")]
        public DateTime TradeDate { get; set; }

        [Display(Name = "FundTradeHistoryRateOfReturn")]
        public decimal RateOfReturn { get; set; }

        [Display(Name = "FundTradeHistoryStrategyId")]
        public long StrategyId { get; set; }

        [Display(Name = "FundTradeHistoryFollowStock")]
        public string FollowStock { get; set; }

        [Display(Name = "FundTradeHistoryNav")]
        public decimal? Nav { get; set; }

        [Display(Name = "FundTradeHistorySellType")]
        public int? SellType { get; set; }

        [Display(Name = "FundTradeHistoryCoefficient")]
        public decimal? Coefficient { get; set; }

        //[Display(Name = "FundTradeHistoryStrategy")]
        //public FundStrategy Strategy { get; set; }
    }
}