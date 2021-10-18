using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MarketWatch.Simulation
{
    public static class FundStrategyEfCoreQueryableExtensions
    {
        public static IQueryable<FundStrategy> IncludeDetails(this IQueryable<FundStrategy> queryable, bool include = true)
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