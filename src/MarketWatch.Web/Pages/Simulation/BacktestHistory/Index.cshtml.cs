using System.Threading.Tasks;

namespace MarketWatch.Web.Pages.Simulation.BacktestHistory
{
    public class IndexModel : MarketWatchPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
