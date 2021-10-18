using System;
using MarketWatch.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MarketWatch.Simulation
{
    public class FundTradeHistoryRepository : EfCoreRepository<MarketWatchDbContext, FundTradeHistory, long>, IFundTradeHistoryRepository
    {
        public FundTradeHistoryRepository(IDbContextProvider<MarketWatchDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}