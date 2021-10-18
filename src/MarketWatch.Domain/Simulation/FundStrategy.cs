using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

#nullable disable

namespace MarketWatch.Simulation
{
    public class FundStrategy : AggregateRoot<long>
    {
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

        public FundStrategy()
        {
            FundTradeHistory = new HashSet<FundTradeHistory>();
        }

        public FundStrategy(
            long id,
            decimal investTriggerRate,
            int analysisPeriod,
            int portfolioNumber,
            int priceToUse,
            decimal lossCutRate,
            DateTime investDate,
            int inUse,
            decimal? ratePerInvesmentPeriod,
            decimal? ratePerYear,
            int daysToTest,
            decimal? std,
            DateTime? investStartDate,
            DateTime createdAt,
            bool disabled,
            string name,
            int? countryToInvest,
            decimal? coefficientAllowed,
            ICollection<FundTradeHistory> fundTradeHistory
        ) : base(id)
        {
            InvestTriggerRate = investTriggerRate;
            AnalysisPeriod = analysisPeriod;
            PortfolioNumber = portfolioNumber;
            PriceToUse = priceToUse;
            LossCutRate = lossCutRate;
            InvestDate = investDate;
            InUse = inUse;
            RatePerInvesmentPeriod = ratePerInvesmentPeriod;
            RatePerYear = ratePerYear;
            DaysToTest = daysToTest;
            Std = std;
            InvestStartDate = investStartDate;
            CreatedAt = createdAt;
            Disabled = disabled;
            Name = name;
            CountryToInvest = countryToInvest;
            CoefficientAllowed = coefficientAllowed;
            FundTradeHistory = fundTradeHistory;
        }
    }
}
