using System;
using System.Collections.Generic;

#nullable disable

namespace MarketWatch.ExistingDbObjectLoad.Models
{
    public partial class StockPrice
    {
        public string Code { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime Date { get; set; }
        public decimal? OpenPrice { get; set; }
        public decimal? HighPrice { get; set; }
        public decimal? LowPrice { get; set; }
        public decimal? ClosePrice { get; set; }
        public decimal? Volume { get; set; }
        public decimal? AdjClosePrice { get; set; }

        public virtual StockInfo CodeNavigation { get; set; }
    }
}
