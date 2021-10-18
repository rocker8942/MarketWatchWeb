using System;
using MarketWatch.Simulation.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketWatch.Simulation
{
    public interface IFundTradeHistoryAppService :
        ICrudAppService< 
            FundTradeHistoryDto, 
            long, 
            PagedAndSortedResultRequestDto,
            CreateUpdateFundTradeHistoryDto,
            CreateUpdateFundTradeHistoryDto>
    {

    }
}