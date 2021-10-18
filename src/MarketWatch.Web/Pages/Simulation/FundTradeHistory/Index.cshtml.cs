using System.Threading.Tasks;

namespace MarketWatch.Web.Pages.Simulation.FundTradeHistory
{
    public class IndexModel : MarketWatchPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
