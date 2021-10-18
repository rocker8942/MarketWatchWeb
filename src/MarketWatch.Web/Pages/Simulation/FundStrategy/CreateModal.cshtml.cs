using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketWatch.Simulation;
using MarketWatch.Simulation.Dtos;
using MarketWatch.Web.Pages.Simulation.FundStrategy.ViewModels;

namespace MarketWatch.Web.Pages.Simulation.FundStrategy
{
    public class CreateModalModel : MarketWatchPageModel
    {
        [BindProperty]
        public CreateEditFundStrategyViewModel ViewModel { get; set; }

        private readonly IFundStrategyAppService _service;

        public CreateModalModel(IFundStrategyAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditFundStrategyViewModel, CreateUpdateFundStrategyDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}