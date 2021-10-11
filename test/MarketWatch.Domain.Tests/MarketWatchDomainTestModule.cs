using MarketWatch.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MarketWatch
{
    [DependsOn(
        typeof(MarketWatchEntityFrameworkCoreTestModule)
        )]
    public class MarketWatchDomainTestModule : AbpModule
    {

    }
}