using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MarketWatch.Simulation
{
    public static class BacktestHistoryEfCoreQueryableExtensions
    {
        public static IQueryable<BacktestHistory> IncludeDetails(this IQueryable<BacktestHistory> queryable, bool include = true)
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