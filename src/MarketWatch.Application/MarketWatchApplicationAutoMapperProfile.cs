using MarketWatch.Simulation;
using MarketWatch.Simulation.Dtos;
using AutoMapper;

namespace MarketWatch
{
    public class MarketWatchApplicationAutoMapperProfile : Profile
    {
        public MarketWatchApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Strategy, StrategyDto>();
            CreateMap<CreateUpdateStrategyDto, Strategy>(MemberList.Source);
            CreateMap<BacktestHistory, BacktestHistoryDto>();
            CreateMap<CreateUpdateBacktestHistoryDto, BacktestHistory>(MemberList.Source);
            CreateMap<FundTradeHistory, FundTradeHistoryDto>();
            CreateMap<CreateUpdateFundTradeHistoryDto, FundTradeHistory>(MemberList.Source);
        }
    }
}
