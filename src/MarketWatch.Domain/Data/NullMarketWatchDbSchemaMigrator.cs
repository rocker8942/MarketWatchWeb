using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MarketWatch.Data
{
    /* This is used if database provider does't define
     * IMarketWatchDbSchemaMigrator implementation.
     */
    public class NullMarketWatchDbSchemaMigrator : IMarketWatchDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}