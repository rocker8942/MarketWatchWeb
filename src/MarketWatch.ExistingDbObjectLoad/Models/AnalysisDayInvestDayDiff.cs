using System;
using System.Collections.Generic;

#nullable disable

namespace MarketWatch.ExistingDbObjectLoad.Models
{
    public partial class AnalysisDayInvestDayDiff
    {
        public int DaysToTest { get; set; }
        public int AnalysisPeriod { get; set; }
        public int? Diff { get; set; }
        public decimal? Rate { get; set; }
        public int? Count { get; set; }
    }
}
