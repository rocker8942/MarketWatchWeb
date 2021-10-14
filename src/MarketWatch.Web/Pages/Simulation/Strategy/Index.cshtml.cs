using System.Threading.Tasks;

namespace MarketWatch.Web.Pages.Simulation.Strategy
{
    public class IndexModel : MarketWatchPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
