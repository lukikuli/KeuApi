using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class WaliSiswa
    {
        public Guid? WaliSiswaId { get; set; }
        public Guid? AgamaId { get; set; }
        public Guid? SubAgamaId { get; set; }
        public Guid? KodePosId { get; set; }
        public string Name { get; set; }
        public string TempatLahir { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public string JenisKelamin { get; set; }
        public string Alamat { get; set; }
        public string NoTelepon { get; set; }
        public string NoMobile { get; set; }
        public string Email { get; set; }
    }
}
