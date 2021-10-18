using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MarketWatch.Simulation.Dtos;

namespace MarketWatch.Web.Pages.Simulation.FundStrategy.ViewModels
{
    public class CreateEditFundStrategyViewModel
    {
        [Display(Name = "FundStrategyInvestTriggerRate")]
        public decimal InvestTriggerRate { get; set; }

        [Display(Name = "FundStrategyAnalysisPeriod")]
        public int AnalysisPeriod { get; set; }

        [Display(Name = "FundStrategyPortfolioNumber")]
        public int PortfolioNumber { get; set; }

        [Display(Name = "FundStrategyPriceToUse")]
        public int PriceToUse { get; set; }

        [Display(Name = "FundStrategyLossCutRate")]
        public decimal LossCutRate { get; set; }

        [Display(Name = "FundStrategyInvestDate")]
        public DateTime InvestDate { get; set; }

        [Display(Name = "FundStrategyInUse")]
        public int InUse { get; set; }

        [Display(Name = "FundStrategyRatePerInvesmentPeriod")]
        public decimal? RatePerInvesmentPeriod { get; set; }

        [Display(Name = "FundStrategyRatePerYear")]
        public decimal? RatePerYear { get; set; }

        [Display(Name = "FundStrategyDaysToTest")]
        public int DaysToTest { get; set; }

        [Display(Name = "FundStrategyStd")]
        public decimal? Std { get; set; }

        [Display(Name = "FundStrategyInvestStartDate")]
        public DateTime? InvestStartDate { get; set; }

        [Display(Name = "FundStrategyCreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "FundStrategyDisabled")]
        public bool Disabled { get; set; }

        [Display(Name = "FundStrategyName")]
        public string Name { get; set; }

        [Display(Name = "FundStrategyCountryToInvest")]
        public int? CountryToInvest { get; set; }

        [Display(Name = "FundStrategyCoefficientAllowed")]
        public decimal? CoefficientAllowed { get; set; }

        [Display(Name = "FundStrategyFundTradeHistory")]
        public ICollection<FundTradeHistoryDto> FundTradeHistory { get; set; }
    }
}