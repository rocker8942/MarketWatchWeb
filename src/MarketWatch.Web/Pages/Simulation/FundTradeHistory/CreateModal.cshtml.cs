using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketWatch.Simulation;
using MarketWatch.Simulation.Dtos;
using MarketWatch.Web.Pages.Simulation.FundTradeHistory.ViewModels;

namespace MarketWatch.Web.Pages.Simulation.FundTradeHistory
{
    public class CreateModalModel : MarketWatchPageModel
    {
        [BindProperty]
        public CreateEditFundTradeHistoryViewModel ViewModel { get; set; }

        private readonly IFundTradeHistoryAppService _service;

        public CreateModalModel(IFundTradeHistoryAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditFundTradeHistoryViewModel, CreateUpdateFundTradeHistoryDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}