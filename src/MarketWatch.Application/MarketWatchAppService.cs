using System;
using System.Collections.Generic;
using System.Text;
using MarketWatch.Localization;
using Volo.Abp.Application.Services;

namespace MarketWatch
{
    /* Inherit your application services from this class.
     */
    public abstract class MarketWatchAppService : ApplicationService
    {
        protected MarketWatchAppService()
        {
            LocalizationResource = typeof(MarketWatchResource);
        }
    }
}
