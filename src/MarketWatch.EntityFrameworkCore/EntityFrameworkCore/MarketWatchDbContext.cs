using MarketWatch.Simulation;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace MarketWatch.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class MarketWatchDbContext : 
        AbpDbContext<MarketWatchDbContext>,
        IIdentityDbContext,
        ITenantManagementDbContext
    {
        /* Add DbSet properties for your Aggregate Roots / Entities here. */

        public virtual DbSet<AnalysisDayInvestDayDiff> AnalysisDayInvestDayDiffs { get; set; }
        public virtual DbSet<BacktestHistory> BacktestHistories { get; set; }
        public virtual DbSet<CoefficientPair> CoefficientPairs { get; set; }
        public virtual DbSet<RefSellType> RefSellTypes { get; set; }
        public virtual DbSet<StockInfo> StockInfos { get; set; }
        public virtual DbSet<StockPrice> StockPrices { get; set; }
        public virtual DbSet<StockToAnalysis> StockToAnalyses { get; set; }
        public virtual DbSet<Strategy> Strategies { get; set; }
        public virtual DbSet<TblFundStrategy> TblFundStrategies { get; set; }
        public virtual DbSet<TblFundTradeHistory> TblFundTradeHistories { get; set; }
        public virtual DbSet<VwStockToAnalysis> VwStockToAnalyses { get; set; }


        
        #region Entities from the modules
        
        /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
         * and replaced them for this DbContext. This allows you to perform JOIN
         * queries for the entities of these modules over the repositories easily. You
         * typically don't need that for other modules. But, if you need, you can
         * implement the DbContext interface of the needed module and use ReplaceDbContext
         * attribute just like IIdentityDbContext and ITenantManagementDbContext.
         *
         * More info: Replacing a DbContext of a module ensures that the related module
         * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
         */
        
        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        
        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        #endregion
        
        public MarketWatchDbContext(DbContextOptions<MarketWatchDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MarketWatchConsts.DbTablePrefix + "YourEntities", MarketWatchConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<AnalysisDayInvestDayDiff>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AnalysisDayInvestDayDiff");

                entity.Property(e => e.AnalysisPeriod).HasColumnName("analysisPeriod");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.DaysToTest).HasColumnName("daysToTest");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("rate");
            });

                        builder.Entity<BacktestHistory>(entity =>
            {
                entity.ToTable("backtestHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuyPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("buyPrice");

                entity.Property(e => e.FollowStock)
                    .HasMaxLength(50)
                    .HasColumnName("followStock");

                entity.Property(e => e.LeaderChange)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("leaderChange");

                entity.Property(e => e.MainLeader)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mainLeader");

                entity.Property(e => e.Nav)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("nav");

                entity.Property(e => e.RateOfReturn)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rateOfReturn");

                entity.Property(e => e.SellPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sellPrice");

                entity.Property(e => e.SellType).HasColumnName("sellType");

                entity.Property(e => e.StrategyId).HasColumnName("strategyId");

                entity.Property(e => e.TradeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tradeDate");

                entity.HasOne(d => d.Strategy)
                    .WithMany(p => p.BacktestHistories)
                    .HasForeignKey(d => d.StrategyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_backtestHistory_strategy");
            });

            builder.Entity<CoefficientPair>(entity =>
            {
                entity.HasKey(e => new { e.CodeX, e.CodeY, e.Leader })
                    .HasName("PK_coefficient_pair_1");

                entity.ToTable("coefficient_pair");

                entity.Property(e => e.CodeX)
                    .HasMaxLength(50)
                    .HasColumnName("codeX");

                entity.Property(e => e.CodeY)
                    .HasMaxLength(50)
                    .HasColumnName("codeY");

                entity.Property(e => e.Leader)
                    .HasMaxLength(10)
                    .HasColumnName("leader");

                entity.Property(e => e.Coefficient)
                    .HasColumnType("decimal(18, 10)")
                    .HasColumnName("coefficient");

                entity.Property(e => e.LeadingBy)
                    .HasColumnType("datetime")
                    .HasColumnName("leading_by");

                entity.HasOne(d => d.CodeXNavigation)
                    .WithMany(p => p.CoefficientPairCodeXNavigations)
                    .HasForeignKey(d => d.CodeX)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_coefficient_pair_stockInfo");

                entity.HasOne(d => d.CodeYNavigation)
                    .WithMany(p => p.CoefficientPairCodeYNavigations)
                    .HasForeignKey(d => d.CodeY)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_coefficient_pair_stockInfo1");
            });

            builder.Entity<RefSellType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("refSellType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

                        builder.Entity<StockInfo>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("stockInfo");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.DateIncluded)
                    .HasColumnType("datetime")
                    .HasColumnName("dateIncluded");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedAt");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");
            });

            builder.Entity<StockPrice>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.Date });

                entity.ToTable("stockPrice");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.AdjClosePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("adjClosePrice");

                entity.Property(e => e.ClosePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("closePrice");

                entity.Property(e => e.CurrentPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("currentPrice");

                entity.Property(e => e.HighPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("highPrice");

                entity.Property(e => e.LowPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lowPrice");

                entity.Property(e => e.OpenPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("openPrice");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("volume");

                entity.HasOne(d => d.CodeNavigation)
                    .WithMany(p => p.StockPrices)
                    .HasForeignKey(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stockPrice_stockInfo");
            });

            builder.Entity<StockToAnalysis>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.Date });

                entity.ToTable("stockToAnalysis");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.AdjClosePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("adjClosePrice");

                entity.Property(e => e.Change)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("change");

                entity.Property(e => e.ClosePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("closePrice");

                entity.Property(e => e.CurrentPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("currentPrice");

                entity.Property(e => e.HighPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("highPrice");

                entity.Property(e => e.LowPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lowPrice");

                entity.Property(e => e.OpenPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("openPrice");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("volume");

                entity.HasOne(d => d.CodeNavigation)
                    .WithMany(p => p.StockToAnalyses)
                    .HasForeignKey(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stockToAnalysis_stockInfo");
            });

            builder.Entity<Strategy>(entity =>
            {
                entity.ToTable("strategy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnalysisPeriod).HasColumnName("analysisPeriod");

                entity.Property(e => e.CoefficientAllowed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CountryToInvest).HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((2000)-(1))-(1))");

                entity.Property(e => e.DaysToTest).HasColumnName("daysToTest");

                entity.Property(e => e.InUse).HasColumnName("inUse");

                entity.Property(e => e.InvestDate).HasColumnType("datetime");

                entity.Property(e => e.InvestStartDate).HasColumnType("datetime");

                entity.Property(e => e.InvestTriggerRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LossCutRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RatePerInvesmentPeriod).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RatePerYear)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ratePerYear");

                entity.Property(e => e.Std)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("std");
            });

            builder.Entity<TblFundStrategy>(entity =>
            {
                entity.ToTable("tblFundStrategy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnalysisPeriod).HasColumnName("analysisPeriod");

                entity.Property(e => e.CoefficientAllowed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DaysToTest).HasColumnName("daysToTest");

                entity.Property(e => e.InUse).HasColumnName("inUse");

                entity.Property(e => e.InvestDate).HasColumnType("datetime");

                entity.Property(e => e.InvestStartDate).HasColumnType("datetime");

                entity.Property(e => e.InvestTriggerRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LossCutRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RatePerInvesmentPeriod).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RatePerYear)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ratePerYear");

                entity.Property(e => e.Std)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("std");
            });

            builder.Entity<TblFundTradeHistory>(entity =>
            {
                entity.ToTable("tblFundTradeHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuyPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("buyPrice");

                entity.Property(e => e.Coefficient)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("coefficient");

                entity.Property(e => e.FollowStock)
                    .HasMaxLength(50)
                    .HasColumnName("followStock");

                entity.Property(e => e.LeaderChange)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("leaderChange");

                entity.Property(e => e.MainLeader)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mainLeader");

                entity.Property(e => e.Nav)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("nav");

                entity.Property(e => e.RateOfReturn)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rateOfReturn");

                entity.Property(e => e.SellPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sellPrice");

                entity.Property(e => e.SellType).HasColumnName("sellType");

                entity.Property(e => e.StrategyId).HasColumnName("strategyId");

                entity.Property(e => e.TradeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tradeDate");

                entity.HasOne(d => d.Strategy)
                    .WithMany(p => p.TblFundTradeHistories)
                    .HasForeignKey(d => d.StrategyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFundTradeHistory_tblFundStrategy");
            });

            builder.Entity<VwStockToAnalysis>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwStockToAnalysis");

                entity.Property(e => e.China).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Gold).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Korea).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sp500)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SP500");

                entity.Property(e => e.Tbond)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TBond");
            });
        }
    }
}
