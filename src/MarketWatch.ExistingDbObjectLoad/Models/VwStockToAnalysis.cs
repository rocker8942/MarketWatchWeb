using System;
using System.Collections.Generic;

#nullable disable

namespace MarketWatch.ExistingDbObjectLoad.Models
{
    public partial class VwStockToAnalysis
    {
        public DateTime Date { get; set; }
        public decimal? Korea { get; set; }
        public decimal? Sp500 { get; set; }
        public decimal? China { get; set; }
        public decimal? Gold { get; set; }
        public decimal? Tbond { get; set; }
    }
}
