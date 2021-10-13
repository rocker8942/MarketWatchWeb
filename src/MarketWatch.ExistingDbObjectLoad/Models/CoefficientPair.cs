using System;
using System.Collections.Generic;

#nullable disable

namespace MarketWatch.ExistingDbObjectLoad.Models
{
    public partial class CoefficientPair
    {
        public string CodeX { get; set; }
        public string CodeY { get; set; }
        public decimal Coefficient { get; set; }
        public string Leader { get; set; }
        public DateTime? LeadingBy { get; set; }

        public virtual StockInfo CodeXNavigation { get; set; }
        public virtual StockInfo CodeYNavigation { get; set; }
    }
}
