using System;
using MarketWatch.Simulation.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketWatch.Simulation
{
    public interface IFundStrategyAppService :
        ICrudAppService< 
            FundStrategyDto, 
            long, 
            PagedAndSortedResultRequestDto,
            CreateUpdateFundStrategyDto,
            CreateUpdateFundStrategyDto>
    {

    }
}