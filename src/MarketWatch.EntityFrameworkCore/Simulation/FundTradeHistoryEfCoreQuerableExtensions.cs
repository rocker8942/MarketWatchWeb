using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MarketWatch.Simulation
{
    public static class FundTradeHistoryEfCoreQueryableExtensions
    {
        public static IQueryable<FundTradeHistory> IncludeDetails(this IQueryable<FundTradeHistory> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}