using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

#nullable disable

namespace MarketWatch.Simulation
{
    public class FundStrategy : AggregateRoot<long>
    {
        public FundStrategy()
        {
            FundTradeHistory = new HashSet<FundTradeHistory>();
        }

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

        public virtual ICollection<FundTradeHistory> FundTradeHistory { get; set; }
    }
}
