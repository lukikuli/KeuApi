using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class Pengisian
    {
        public Guid? PengisianId { get; set; }
        public string Kode { get; set; }
        public string Keterangan { get; set; }
        public decimal? Ssp { get; set; }
        public decimal? Usek { get; set; }
        public decimal? UsekMin { get; set; }
        public Guid? TahunAjaranId { get; set; }
        public Guid? EditUserId { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
