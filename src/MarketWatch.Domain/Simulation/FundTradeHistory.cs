using System;
using Volo.Abp.Domain.Entities;

#nullable disable

namespace MarketWatch.Simulation
{
    public class FundTradeHistory : Entity<long>
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

        public virtual FundStrategy Strategy { get; set; }

        protected FundTradeHistory()
        {
        }

        public FundTradeHistory(
            long id,
            string mainLeader,
            decimal leaderChange,
            decimal buyPrice,
            decimal sellPrice,
            DateTime tradeDate,
            decimal rateOfReturn,
            long strategyId,
            string followStock,
            decimal? nav,
            int? sellType,
            decimal? coefficient,
            FundStrategy strategy
        ) : base(id)
        {
            MainLeader = mainLeader;
            LeaderChange = leaderChange;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            TradeDate = tradeDate;
            RateOfReturn = rateOfReturn;
            StrategyId = strategyId;
            FollowStock = followStock;
            Nav = nav;
            SellType = sellType;
            Coefficient = coefficient;
            Strategy = strategy;
        }
    }
}
