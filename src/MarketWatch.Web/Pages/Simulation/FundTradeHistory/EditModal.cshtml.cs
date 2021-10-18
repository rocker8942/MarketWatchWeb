using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketWatch.Simulation;
using MarketWatch.Simulation.Dtos;
using MarketWatch.Web.Pages.Simulation.FundTradeHistory.ViewModels;

namespace MarketWatch.Web.Pages.Simulation.FundTradeHistory
{
    public class EditModalModel : MarketWatchPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public long Id { get; set; }

        [BindProperty]
        public CreateEditFundTradeHistoryViewModel ViewModel { get; set; }

        private readonly IFundTradeHistoryAppService _service;

        public EditModalModel(IFundTradeHistoryAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<FundTradeHistoryDto, CreateEditFundTradeHistoryViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditFundTradeHistoryViewModel, CreateUpdateFundTradeHistoryDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}