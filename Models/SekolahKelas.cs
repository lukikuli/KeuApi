using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class SekolahKelas
    {
        public Guid SekolahKelasId { get; set; }
        public Guid? TahunAjaranId { get; set; }
        public Guid? SekolahId { get; set; }
        public int? Levels { get; set; }
        public string Name { get; set; }
        public bool? KelasOpen { get; set; }
        public string Pembayaran { get; set; }
        public decimal? NominalUangSekolah { get; set; }
        public decimal? NominalDanaSatuTahun { get; set; }
    }
}
