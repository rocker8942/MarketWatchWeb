using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketWatch.Simulation;
using MarketWatch.Simulation.Dtos;
using MarketWatch.Web.Pages.Simulation.BacktestHistory.ViewModels;

namespace MarketWatch.Web.Pages.Simulation.BacktestHistory
{
    public class EditModalModel : MarketWatchPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public long Id { get; set; }

        [BindProperty]
        public CreateEditBacktestHistoryViewModel ViewModel { get; set; }

        private readonly IBacktestHistoryAppService _service;

        public EditModalModel(IBacktestHistoryAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<BacktestHistoryDto, CreateEditBacktestHistoryViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditBacktestHistoryViewModel, CreateUpdateBacktestHistoryDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}