using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MarketWatch.Simulation.Dtos;

namespace MarketWatch.Web.Pages.Simulation.Strategy.ViewModels
{
    public class CreateEditStrategyViewModel
    {
        [Display(Name = "StrategyInvestTriggerRate")]
        public decimal InvestTriggerRate { get; set; }

        [Display(Name = "StrategyAnalysisPeriod")]
        public int AnalysisPeriod { get; set; }

        [Display(Name = "StrategyPortfolioNumber")]
        public int PortfolioNumber { get; set; }

        [Display(Name = "StrategyPriceToUse")]
        public int PriceToUse { get; set; }

        [Display(Name = "StrategyLossCutRate")]
        public decimal LossCutRate { get; set; }

        [Display(Name = "StrategyInvestDate")]
        public DateTime InvestDate { get; set; }

        [Display(Name = "StrategyInUse")]
        public int InUse { get; set; }

        [Display(Name = "StrategyRatePerInvesmentPeriod")]
        public decimal? RatePerInvesmentPeriod { get; set; }

        [Display(Name = "StrategyRatePerYear")]
        public decimal? RatePerYear { get; set; }

        [Display(Name = "StrategyDaysToTest")]
        public int DaysToTest { get; set; }

        [Display(Name = "StrategyStd")]
        public decimal? Std { get; set; }

        [Display(Name = "StrategyInvestStartDate")]
        public DateTime? InvestStartDate { get; set; }

        [Display(Name = "StrategyCountryToInvest")]
        public string CountryToInvest { get; set; }

        [Display(Name = "StrategyCreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "StrategyDisabled")]
        public bool Disabled { get; set; }

        [Display(Name = "StrategyCoefficientAllowed")]
        public decimal? CoefficientAllowed { get; set; }

        [Display(Name = "StrategyBacktestHistories")]
        public ICollection<BacktestHistoryDto> BacktestHistories { get; set; }
    }
}