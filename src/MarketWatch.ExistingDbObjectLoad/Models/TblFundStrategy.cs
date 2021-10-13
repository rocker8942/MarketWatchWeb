using System;
using System.Collections.Generic;

#nullable disable

namespace MarketWatch.ExistingDbObjectLoad.Models
{
    public partial class TblFundStrategy
    {
        public TblFundStrategy()
        {
            TblFundTradeHistories = new HashSet<TblFundTradeHistory>();
        }

        public long Id { get; set; }
        public decimal InvestTriggerRate { get; set; }
        public int AnalysisPeriod { get; set; }
        public int PortfolioNumber { get; set; }
        public int PriceToUse { get; set; }
        public decimal LossCutRate { get; set; }
        public DateTime InvestDate { get; set; }
        public int InUse { get; set; }
        public decimal? RatePerInvesmentPeriod { get; set; }
        public decimal? RatePerYear { get; set; }
        public int DaysToTest { get; set; }
        public decimal? Std { get; set; }
        public DateTime? InvestStartDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Disabled { get; set; }
        public string Name { get; set; }
        public int? CountryToInvest { get; set; }
        public decimal? CoefficientAllowed { get; set; }

        public virtual ICollection<TblFundTradeHistory> TblFundTradeHistories { get; set; }
    }
}
