using System;
using Volo.Abp.Domain.Repositories;

namespace MarketWatch.Simulation
{
    public interface IFundTradeHistoryRepository : IRepository<FundTradeHistory, long>
    {
    }
}