using System;
using MarketWatch.Simulation.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketWatch.Simulation
{
    public interface IBacktestHistoryAppService :
        ICrudAppService< 
            BacktestHistoryDto, 
            long, 
            PagedAndSortedResultRequestDto,
            CreateUpdateBacktestHistoryDto,
            CreateUpdateBacktestHistoryDto>
    {

    }
}