using MarketWatch.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MarketWatch.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MarketWatchController : AbpController
    {
        protected MarketWatchController()
        {
            LocalizationResource = typeof(MarketWatchResource);
        }
    }
}