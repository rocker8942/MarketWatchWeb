using System;
using Volo.Abp.Domain.Entities;

#nullable disable

namespace MarketWatch.Simulation
{
    public class BacktestHistory : Entity<long>
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

        public virtual Strategy Strategy { get; set; }

        protected BacktestHistory()
        {
        }

        public BacktestHistory(
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
            Strategy strategy
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
            Strategy = strategy;
        }
    }
}
