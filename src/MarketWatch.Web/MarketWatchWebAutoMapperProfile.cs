using MarketWatch.Simulation.Dtos;
using MarketWatch.Web.Pages.Simulation.Strategy.ViewModels;
using MarketWatch.Web.Pages.Simulation.BacktestHistory.ViewModels;
using MarketWatch.Simulation.Dtos;
using MarketWatch.Web.Pages.Simulation.FundTradeHistory.ViewModels;
using AutoMapper;

namespace MarketWatch.Web
{
    public class MarketWatchWebAutoMapperProfile : Profile
    {
        public MarketWatchWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<StrategyDto, CreateEditStrategyViewModel>();
            CreateMap<CreateEditStrategyViewModel, CreateUpdateStrategyDto>();
            CreateMap<BacktestHistoryDto, CreateEditBacktestHistoryViewModel>();
            CreateMap<CreateEditBacktestHistoryViewModel, CreateUpdateBacktestHistoryDto>();
            CreateMap<FundTradeHistoryDto, CreateEditFundTradeHistoryViewModel>();
            CreateMap<CreateEditFundTradeHistoryViewModel, CreateUpdateFundTradeHistoryDto>();
        }
    }
}
