using System.Threading.Tasks;

namespace MarketWatch.Data
{
    public interface IMarketWatchDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
