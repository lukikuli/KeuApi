using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class PergantianKelas
    {
        public Guid? PergantianKelasId { get; set; }
        public Guid? SekolahKelasIdasal { get; set; }
        public Guid? SekolahKelasIdtujuan { get; set; }
        public Guid? AlasanPergantianKelasId { get; set; }
        public string NoSpj { get; set; }
        public DateTime? TanggalKeluar { get; set; }
        public DateTime? TanggalMasuk { get; set; }
        public string Keterangan { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? TanggalProses { get; set; }
    }
}
