﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MarketWatch.ExistingDbObjectLoad.Models
{
    public partial class AspnetUsersInRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        public virtual AspnetRole Role { get; set; }
        public virtual AspnetUser User { get; set; }
    }
}
