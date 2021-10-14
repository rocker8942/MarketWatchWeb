using System;
using MarketWatch.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MarketWatch.Simulation
{
    public class StrategyRepository : EfCoreRepository<MarketWatchDbContext, Strategy, long>, IStrategyRepository
    {
        public StrategyRepository(IDbContextProvider<MarketWatchDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}