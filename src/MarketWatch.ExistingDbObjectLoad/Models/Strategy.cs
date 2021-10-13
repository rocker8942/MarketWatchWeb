using System;
using System.Collections.Generic;

#nullable disable

namespace MarketWatch.ExistingDbObjectLoad.Models
{
    public partial class Strategy
    {
        public Strategy()
        {
            BacktestHistories = new HashSet<BacktestHistory>();
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
        public string CountryToInvest { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Disabled { get; set; }
        public decimal? CoefficientAllowed { get; set; }

        public virtual ICollection<BacktestHistory> BacktestHistories { get; set; }
    }
}
