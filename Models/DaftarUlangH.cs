using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class DaftarUlangH
    {
        public Guid DafulId { get; set; }
        public string DafulNo { get; set; }
        public string NoSpj { get; set; }
        public Guid TahunAjaranId { get; set; }
        public DateTime? TanggalEdit { get; set; }
        public DateTime? TanggalCreated { get; set; }
        public decimal? NominalUsek { get; set; }
        public decimal? NominalAdmin { get; set; }
        public string NoVabca { get; set; }
        public int? CaraBayar { get; set; }
        public int? BankBayar { get; set; }
        public int? PrintNo { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public Guid? EditUserId { get; set; }
        public Guid? PengisianId { get; set; }
        public Guid? SekolahKelasId { get; set; }
        public DateTime? TanggalLunas { get; set; }
        public DateTime? TanggalJatuhTempo { get; set; }
        public string Keterangan { get; set; }
        public DateTime? TanggalEntry { get; set; }
        public bool? Dinaikkan { get; set; }
        public int? Status { get; set; }
    }
}
