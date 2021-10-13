using System;
using System.Collections.Generic;

#nullable disable

namespace MarketWatch.ExistingDbObjectLoad.Models
{
    public partial class StockInfo
    {
        public StockInfo()
        {
            CoefficientPairCodeXNavigations = new HashSet<CoefficientPair>();
            CoefficientPairCodeYNavigations = new HashSet<CoefficientPair>();
            StockPrices = new HashSet<StockPrice>();
            StockToAnalyses = new HashSet<StockToAnalysis>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? DateIncluded { get; set; }
        public string Country { get; set; }
        public bool Enabled { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual ICollection<CoefficientPair> CoefficientPairCodeXNavigations { get; set; }
        public virtual ICollection<CoefficientPair> CoefficientPairCodeYNavigations { get; set; }
        public virtual ICollection<StockPrice> StockPrices { get; set; }
        public virtual ICollection<StockToAnalysis> StockToAnalyses { get; set; }
    }
}
