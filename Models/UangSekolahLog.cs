using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class UangSekolahLog
    {
        public Guid? UangSekolahId { get; set; }
        public Guid? TahunAjaranId { get; set; }
        public Guid? CaraBayarId { get; set; }
        public Guid? PengisianId { get; set; }
        public string NoSpj { get; set; }
        public decimal? Nominal { get; set; }
        public DateTime? TanggalEdit { get; set; }
        public Guid? EditUserId { get; set; }
        public Guid? SekolahKelasId { get; set; }
        public decimal? NominalDanaSatuTahun { get; set; }
        public Guid? CaraBayarDanaSatuTahunId { get; set; }
        public Guid? UangSekolahBankId { get; set; }
        public Guid? DanaSatuTahunBankId { get; set; }
        public bool? PembayaranGenerated { get; set; }
        public string Pembayaran { get; set; }
        public bool? DanaSatuTahunGenerated { get; set; }
        public bool? DanaSatuTahunPembayaranGenerated { get; set; }
        public bool? Archived { get; set; }
    }
}
