using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class PembayaranUangSekolah
    {
        public Guid? PembayaranUangSekolahId { get; set; }
        public Guid? EditUserId { get; set; }
        public DateTime? TanggalEdit { get; set; }
        public decimal? Nominal { get; set; }
        public DateTime? TanggalEntry { get; set; }
        public DateTime? TanggalLunas { get; set; }
        public string CaraPembayaran { get; set; }
        public string NoVa { get; set; }
        public string NoRekening { get; set; }
        public int? NomorPembayaran { get; set; }
        public Guid? UangSekolahId { get; set; }
        public Guid? BankId { get; set; }
        public DateTime? TanggalJatuhTempo { get; set; }
        public decimal? NominalDibayar { get; set; }
    }
}
