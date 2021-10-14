using System;
using MarketWatch.Permissions;
using MarketWatch.Simulation.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketWatch.Simulation
{
    public class BacktestHistoryAppService : CrudAppService<BacktestHistory, BacktestHistoryDto, long, PagedAndSortedResultRequestDto, CreateUpdateBacktestHistoryDto, CreateUpdateBacktestHistoryDto>,
        IBacktestHistoryAppService
    {
        protected override string GetPolicyName { get; set; } = MarketWatchPermissions.BacktestHistory.Default;
        protected override string GetListPolicyName { get; set; } = MarketWatchPermissions.BacktestHistory.Default;
        protected override string CreatePolicyName { get; set; } = MarketWatchPermissions.BacktestHistory.Create;
        protected override string UpdatePolicyName { get; set; } = MarketWatchPermissions.BacktestHistory.Update;
        protected override string DeletePolicyName { get; set; } = MarketWatchPermissions.BacktestHistory.Delete;

        private readonly IBacktestHistoryRepository _repository;
        
        public BacktestHistoryAppService(IBacktestHistoryRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
