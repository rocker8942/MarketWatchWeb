using System;
using Volo.Abp.Application.Dtos;

namespace MarketWatch.Simulation.Dtos
{
    [Serializable]
    public class FundTradeHistoryDto : EntityDto<long>
    {
        public string MainLeader { get; set; }

        public decimal LeaderChange { get; set; }

        public decimal BuyPrice { get; set; }

        public decimal SellPrice { get; set; }

        public DateTime TradeDate { get; set; }

        public decimal RateOfReturn { get; set; }

        public long StrategyId { get; set; }

        public string FollowStock { get; set; }

        public decimal? Nav { get; set; }

        public int? SellType { get; set; }

        public decimal? Coefficient { get; set; }

        // public FundStrategy Strategy { get; set; }
    }
}