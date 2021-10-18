namespace MarketWatch.Permissions
{
    public static class MarketWatchPermissions
    {
        public const string GroupName = "MarketWatch";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public class Strategy
        {
            public const string Default = GroupName + ".Strategy";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class BacktestHistory
        {
            public const string Default = GroupName + ".BacktestHistory";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class FundTradeHistory
        {
            public const string Default = GroupName + ".FundTradeHistory";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class FundStrategy
        {
            public const string Default = GroupName + ".FundStrategy";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}
