using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class Siswa
    {
        public string NoSpj { get; set; }
        public Guid? SekolahKelasId { get; set; }
        public Guid? AgamaId { get; set; }
        public Guid? SubAgamaId { get; set; }
        public Guid? KodePosId { get; set; }
        public Guid? GolonganDarahId { get; set; }
        public string Name { get; set; }
        public string TempatLahir { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public string Alamat { get; set; }
        public decimal? JarakRumah { get; set; }
        public string NoTelepon { get; set; }
        public string NoMobile { get; set; }
        public string JenisKelamin { get; set; }
        public string Email { get; set; }
        public string Angkatan { get; set; }
        public string NoInduk { get; set; }
        public string NoUrut { get; set; }
        public string UrlPhoto { get; set; }
        public string EmailPenabur { get; set; }
        public bool? KebutuhanKhusus { get; set; }
        public string PasswordDefaultEmailPenabur { get; set; }
        public Guid? PengisianId { get; set; }
        public string NoRegPsb { get; set; }
    }
}
