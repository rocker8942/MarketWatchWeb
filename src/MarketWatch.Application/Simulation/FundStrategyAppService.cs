using System;
using MarketWatch.Permissions;
using MarketWatch.Simulation.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketWatch.Simulation
{
    public class FundStrategyAppService : CrudAppService<FundStrategy, FundStrategyDto, long, PagedAndSortedResultRequestDto, CreateUpdateFundStrategyDto, CreateUpdateFundStrategyDto>,
        IFundStrategyAppService
    {
        protected override string GetPolicyName { get; set; } = MarketWatchPermissions.FundStrategy.Default;
        protected override string GetListPolicyName { get; set; } = MarketWatchPermissions.FundStrategy.Default;
        protected override string CreatePolicyName { get; set; } = MarketWatchPermissions.FundStrategy.Create;
        protected override string UpdatePolicyName { get; set; } = MarketWatchPermissions.FundStrategy.Update;
        protected override string DeletePolicyName { get; set; } = MarketWatchPermissions.FundStrategy.Delete;

        private readonly IFundStrategyRepository _repository;
        
        public FundStrategyAppService(IFundStrategyRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
