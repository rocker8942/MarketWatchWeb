using System;
using System.Collections.Generic;

#nullable disable

namespace MarketWatch.ExistingDbObjectLoad.Models
{
    public partial class VwAlphaComparison
    {
        public DateTime Date { get; set; }
        public decimal? Nav { get; set; }
        public decimal? Gspc { get; set; }
        public decimal? AsxAx { get; set; }
        public decimal? Ewy { get; set; }
    }
}
