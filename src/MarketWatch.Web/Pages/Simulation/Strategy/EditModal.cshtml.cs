using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketWatch.Simulation;
using MarketWatch.Simulation.Dtos;
using MarketWatch.Web.Pages.Simulation.Strategy.ViewModels;

namespace MarketWatch.Web.Pages.Simulation.Strategy
{
    public class EditModalModel : MarketWatchPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public long Id { get; set; }

        [BindProperty]
        public CreateEditStrategyViewModel ViewModel { get; set; }

        private readonly IStrategyAppService _service;

        public EditModalModel(IStrategyAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<StrategyDto, CreateEditStrategyViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditStrategyViewModel, CreateUpdateStrategyDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}