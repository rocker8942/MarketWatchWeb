using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MarketWatch.ExistingDbObjectLoad.Models;

#nullable disable

namespace MarketWatch.ExistingDbObjectLoad.DbContext
{
    public partial class MarketWatchContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MarketWatchContext()
        {
        }

        public MarketWatchContext(DbContextOptions<MarketWatchContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }
        public virtual DbSet<AnalysisDayInvestDayDiff> AnalysisDayInvestDayDiffs { get; set; }
        public virtual DbSet<AspNetRole1> AspNetRoles1 { get; set; }
        public virtual DbSet<AspNetUser1> AspNetUsers1 { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; }
        public virtual DbSet<AspnetPath> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; }
        public virtual DbSet<AspnetRole> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUser> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRole> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; }
        public virtual DbSet<BacktestHistory> BacktestHistories { get; set; }
        public virtual DbSet<CoefficientPair> CoefficientPairs { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }
        public virtual DbSet<DateTimeDefaultTest> DateTimeDefaultTests { get; set; }
        public virtual DbSet<Hash> Hashes { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobParameter> JobParameters { get; set; }
        public virtual DbSet<JobQueue> JobQueues { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<RefSellType> RefSellTypes { get; set; }
        public virtual DbSet<Schema> Schemas { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<Set> Sets { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StockInfo> StockInfos { get; set; }
        public virtual DbSet<StockPrice> StockPrices { get; set; }
        public virtual DbSet<StockToAnalysis> StockToAnalyses { get; set; }
        public virtual DbSet<Strategy> Strategies { get; set; }
        public virtual DbSet<TblFundStrategy> TblFundStrategies { get; set; }
        public virtual DbSet<TblFundTradeHistory> TblFundTradeHistories { get; set; }
        public virtual DbSet<VwAlphaComparison> VwAlphaComparisons { get; set; }
        public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }
        public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; }
        public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; }
        public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; }
        public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }
        public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; }
        public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; }
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; }
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; }
        public virtual DbSet<VwStockToAnalysis> VwStockToAnalyses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=marketwatch_Prod;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Korean_Wansung_CI_AS");

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.Key, "UX_HangFire_CounterAggregated_Key")
                    .IsUnique();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AnalysisDayInvestDayDiff>(entity =>
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

            modelBuilder.Entity<AspNetRole1>(entity =>
            {
                entity.ToTable("AspNetRoles");

                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser1>(entity =>
            {
                entity.ToTable("AspNetUsers");

                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId, "IX_RoleId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspnetApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C98716DA476")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_A__17477DE4AAB4CD19")
                    .IsUnique();

                entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_A__309103314EF40381")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4DD42D9DF3")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index")
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMemberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__3A4CA8FD");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__3B40CD36");
            });

            modelBuilder.Entity<AspnetPath>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5873E41E9A")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__3E1D39E1");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC59ED327166");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUser)
                    .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__3D2915A8");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC0692483FFF")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId }, "aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__30C33EC3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__31B762FC");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C32EE5DF3");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__2FCF1A8A");
            });

            modelBuilder.Entity<AspnetRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1B5456B6CB")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__395884C4");
            });

            modelBuilder.Entity<AspnetSchemaVersion>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC1B150F207");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D813488AB")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate }, "aspnet_Users_Index2");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__3864608B");
            });

            modelBuilder.Entity<AspnetUsersInRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_U__AF2760AD2B51F29E");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasIndex(e => e.RoleId, "aspnet_UsersInRoles_index");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__367C1819");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__37703C52");
            });

            modelBuilder.Entity<AspnetWebEventEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C810F0A07568");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<BacktestHistory>(entity =>
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

            modelBuilder.Entity<CoefficientPair>(entity =>
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

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key, "IX_HangFire_Counter_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DateTimeDefaultTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DateTimeDefaultTest");

                entity.Property(e => e.CreatedData)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate2).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDateOffset).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt");

                entity.HasIndex(e => e.Key, "IX_HangFire_Hash_Key");

                entity.HasIndex(e => new { e.Key, e.Field }, "UX_HangFire_Hash_Key_Field")
                    .IsUnique();

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt");

                entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.ToTable("JobParameter", "HangFire");

                entity.HasIndex(e => new { e.JobId, e.Name }, "IX_HangFire_JobParameter_JobIdAndName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameters)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.ToTable("JobQueue", "HangFire");

                entity.HasIndex(e => new { e.Queue, e.FetchedAt }, "IX_HangFire_JobQueue_QueueAndFetchedAt");

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt");

                entity.HasIndex(e => e.Key, "IX_HangFire_List_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<RefSellType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("refSellType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt");

                entity.HasIndex(e => e.Key, "IX_HangFire_Set_Key");

                entity.HasIndex(e => new { e.Key, e.Value }, "UX_HangFire_Set_KeyAndValue")
                    .IsUnique();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State", "HangFire");

                entity.HasIndex(e => e.JobId, "IX_HangFire_State_JobId");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<StockInfo>(entity =>
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

            modelBuilder.Entity<StockPrice>(entity =>
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

            modelBuilder.Entity<StockToAnalysis>(entity =>
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

            modelBuilder.Entity<Strategy>(entity =>
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

            modelBuilder.Entity<TblFundStrategy>(entity =>
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

            modelBuilder.Entity<TblFundTradeHistory>(entity =>
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

            modelBuilder.Entity<VwAlphaComparison>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAlphaComparison");

                entity.Property(e => e.AsxAx)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ASX.AX");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Ewy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EWY");

                entity.Property(e => e.Gspc)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("^GSPC");

                entity.Property(e => e.Nav)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("nav");
            });

            modelBuilder.Entity<VwAspnetApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwStockToAnalysis>(entity =>
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
