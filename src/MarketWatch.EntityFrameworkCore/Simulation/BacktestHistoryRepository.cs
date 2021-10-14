using System;
using MarketWatch.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MarketWatch.Simulation
{
    public class BacktestHistoryRepository : EfCoreRepository<MarketWatchDbContext, BacktestHistory, long>, IBacktestHistoryRepository
    {
        public BacktestHistoryRepository(IDbContextProvider<MarketWatchDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}