using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketWatch.Simulation;
using MarketWatch.Simulation.Dtos;
using MarketWatch.Web.Pages.Simulation.BacktestHistory.ViewModels;

namespace MarketWatch.Web.Pages.Simulation.BacktestHistory
{
    public class CreateModalModel : MarketWatchPageModel
    {
        [BindProperty]
        public CreateEditBacktestHistoryViewModel ViewModel { get; set; }

        private readonly IBacktestHistoryAppService _service;

        public CreateModalModel(IBacktestHistoryAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditBacktestHistoryViewModel, CreateUpdateBacktestHistoryDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}