using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketWatch.Simulation;
using MarketWatch.Simulation.Dtos;
using MarketWatch.Web.Pages.Simulation.FundStrategy.ViewModels;

namespace MarketWatch.Web.Pages.Simulation.FundStrategy
{
    public class EditModalModel : MarketWatchPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public long Id { get; set; }

        [BindProperty]
        public CreateEditFundStrategyViewModel ViewModel { get; set; }

        private readonly IFundStrategyAppService _service;

        public EditModalModel(IFundStrategyAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<FundStrategyDto, CreateEditFundStrategyViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditFundStrategyViewModel, CreateUpdateFundStrategyDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}