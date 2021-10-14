using System;
using Volo.Abp.Domain.Repositories;

namespace MarketWatch.Simulation
{
    public interface IBacktestHistoryRepository : IRepository<BacktestHistory, long>
    {
    }
}