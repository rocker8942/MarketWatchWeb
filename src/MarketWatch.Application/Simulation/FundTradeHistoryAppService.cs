using System;
using MarketWatch.Permissions;
using MarketWatch.Simulation.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketWatch.Simulation
{
    public class FundTradeHistoryAppService : CrudAppService<FundTradeHistory, FundTradeHistoryDto, long, PagedAndSortedResultRequestDto, CreateUpdateFundTradeHistoryDto, CreateUpdateFundTradeHistoryDto>,
        IFundTradeHistoryAppService
    {
        protected override string GetPolicyName { get; set; } = MarketWatchPermissions.FundTradeHistory.Default;
        protected override string GetListPolicyName { get; set; } = MarketWatchPermissions.FundTradeHistory.Default;
        protected override string CreatePolicyName { get; set; } = MarketWatchPermissions.FundTradeHistory.Create;
        protected override string UpdatePolicyName { get; set; } = MarketWatchPermissions.FundTradeHistory.Update;
        protected override string DeletePolicyName { get; set; } = MarketWatchPermissions.FundTradeHistory.Delete;

        private readonly IFundTradeHistoryRepository _repository;
        
        public FundTradeHistoryAppService(IFundTradeHistoryRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
