using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class SubAgama
    {
        public Guid? SubAgamaId { get; set; }
        public Guid? AgamaId { get; set; }
        public string Name { get; set; }
    }
}
