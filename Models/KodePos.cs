﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class KodePos
    {
        public Guid? KodePosId { get; set; }
        public Guid? KotaId { get; set; }
        public string Name { get; set; }
    }
}
