using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class CaraBayar
    {
        public Guid? CaraBayarId { get; set; }
        public string Name { get; set; }
        public int? JumlahPembayaran { get; set; }
        public decimal? Discount { get; set; }
        public Guid? SekolahId { get; set; }
        public bool? BoolUangSekolah { get; set; }
        public string DetailCicilan { get; set; }
    }
}
