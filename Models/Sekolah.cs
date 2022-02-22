using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class Sekolah
    {
        public Guid SekolahId { get; set; }
        public Guid? KotaId { get; set; }
        public Guid? JenjangPendidikanId { get; set; }
        public string Name { get; set; }
        public string Alamat { get; set; }
        public string NoTelepon { get; set; }
        public string KodeSekolah { get; set; }
        public string NoFax { get; set; }
        public string Email { get; set; }
        public bool? Archive { get; set; }
        public int? NoUrut { get; set; }
        public decimal? Administrasi { get; set; }
        public int? Keuangan { get; set; }
    }
}
