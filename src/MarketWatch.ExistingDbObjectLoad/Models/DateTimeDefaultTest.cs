using System;
using System.Collections.Generic;

#nullable disable

namespace MarketWatch.ExistingDbObjectLoad.Models
{
    public partial class DateTimeDefaultTest
    {
        public int Id { get; set; }
        public DateTimeOffset? CreatedDateOffset { get; set; }
        public DateTime? CreatedDate2 { get; set; }
        public DateTime? CreatedData { get; set; }
    }
}
