using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketWatch.Simulation;
using MarketWatch.Simulation.Dtos;
using MarketWatch.Web.Pages.Simulation.Strategy.ViewModels;

namespace MarketWatch.Web.Pages.Simulation.Strategy
{
    public class CreateModalModel : MarketWatchPageModel
    {
        [BindProperty]
        public CreateEditStrategyViewModel ViewModel { get; set; }

        private readonly IStrategyAppService _service;

        public CreateModalModel(IStrategyAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditStrategyViewModel, CreateUpdateStrategyDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}