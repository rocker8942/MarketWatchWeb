using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MarketWatch.Simulation
{
    public static class StrategyEfCoreQueryableExtensions
    {
        public static IQueryable<Strategy> IncludeDetails(this IQueryable<Strategy> queryable, bool include = true)
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