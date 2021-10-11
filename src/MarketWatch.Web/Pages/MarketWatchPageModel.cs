using MarketWatch.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MarketWatch.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MarketWatchPageModel : AbpPageModel
    {
        protected MarketWatchPageModel()
        {
            LocalizationResourceType = typeof(MarketWatchResource);
        }
    }
}