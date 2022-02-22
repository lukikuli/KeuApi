using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class TvSyncKeringanan
    {
        public int Id { get; set; }
        public string Nospj { get; set; }
        public string Nama { get; set; }
        public string Status { get; set; }
        public double? UsekFinal { get; set; }
        public string BlnBerlaku { get; set; }
        public string TglApproval { get; set; }
        public string Approval { get; set; }
        public int? IdKeringanan { get; set; }
    }
}
