using System;
using MarketWatch.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MarketWatch.Simulation
{
    public class FundStrategyRepository : EfCoreRepository<MarketWatchDbContext, FundStrategy, long>, IFundStrategyRepository
    {
        public FundStrategyRepository(IDbContextProvider<MarketWatchDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}