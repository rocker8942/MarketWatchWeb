using System;
using Volo.Abp.Domain.Repositories;

namespace MarketWatch.Simulation
{
    public interface IStrategyRepository : IRepository<Strategy, long>
    {
    }
}