using System;
using MarketWatch.Permissions;
using MarketWatch.Simulation.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketWatch.Simulation
{
    public class StrategyAppService : CrudAppService<Strategy, StrategyDto, long, PagedAndSortedResultRequestDto, CreateUpdateStrategyDto, CreateUpdateStrategyDto>,
        IStrategyAppService
    {
        protected override string GetPolicyName { get; set; } = MarketWatchPermissions.Strategy.Default;
        protected override string GetListPolicyName { get; set; } = MarketWatchPermissions.Strategy.Default;
        protected override string CreatePolicyName { get; set; } = MarketWatchPermissions.Strategy.Create;
        protected override string UpdatePolicyName { get; set; } = MarketWatchPermissions.Strategy.Update;
        protected override string DeletePolicyName { get; set; } = MarketWatchPermissions.Strategy.Delete;

        private readonly IStrategyRepository _repository;
        
        public StrategyAppService(IStrategyRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
