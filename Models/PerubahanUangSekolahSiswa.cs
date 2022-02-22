using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class PerubahanUangSekolahSiswa
    {
        public Guid? PerubahanUangSekolahSiswaId { get; set; }
        public Guid? UangSekolahId { get; set; }
        public decimal? NominalAwal { get; set; }
        public decimal? NominalAkhir { get; set; }
        public int? BulanBerlaku { get; set; }
        public DateTime? TanggalPermohonan { get; set; }
        public DateTime? TanggalProses { get; set; }
        public string Keterangan { get; set; }
        public Guid? PengurusId { get; set; }
        public Guid? EditUserId { get; set; }
    }
}
