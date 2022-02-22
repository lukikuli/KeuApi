using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class TempSiswa
    {
        public string Nama { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public string TempatLahir { get; set; }
        public string JenisKelamin { get; set; }
        public string Alamat { get; set; }
        public string NoTelepon { get; set; }
        public string Email { get; set; }
        public string NoSpj { get; set; }
        public Guid? SekolahKelasId { get; set; }
        public Guid? PengisianId { get; set; }
        public Guid? PergantianKelasId { get; set; }
        public Guid? SekolahKelasIdasal { get; set; }
        public Guid? SekolahKelasIdtujuan { get; set; }
        public Guid? AlasanPergantianKelasId { get; set; }
        public DateTime? TanggalKeluar { get; set; }
        public DateTime? TanggalMasuk { get; set; }
        public string Keterangan { get; set; }
        public Guid? UangSekolahId { get; set; }
        public Guid? TahunAjaranId { get; set; }
        public Guid? CaraBayarId { get; set; }
        public decimal? Nominal { get; set; }
        public int? NoUrutSekolah { get; set; }
        public string NamaSekolah { get; set; }
        public string NamaKelas { get; set; }
        public DateTime? TglEntryDibayar { get; set; }
        public string NoRegPsb { get; set; }
        public string IdSiswa { get; set; }
    }
}
