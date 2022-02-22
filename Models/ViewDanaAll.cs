using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class ViewDanaAll
    {
        public string Tahun { get; set; }
        public string NoSpj { get; set; }
        public string Kodesek { get; set; }
        public string NamaSek { get; set; }
        public string Kelas { get; set; }
        public string Namasiswa { get; set; }
        public string JnsPemb { get; set; }
        public string Cicilan1 { get; set; }
        public string Cicilan2 { get; set; }
        public string Cicilan3 { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
