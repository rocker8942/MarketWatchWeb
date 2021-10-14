using System;
using MarketWatch.Simulation.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketWatch.Simulation
{
    public interface IStrategyAppService :
        ICrudAppService< 
            StrategyDto, 
            long, 
            PagedAndSortedResultRequestDto,
            CreateUpdateStrategyDto,
            CreateUpdateStrategyDto>
    {

    }
}