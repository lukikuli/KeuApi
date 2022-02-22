using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class Hubungan
    {
        public string NoSpj { get; set; }
        public Guid? HubunganId { get; set; }
        public Guid? WaliSiswaId { get; set; }
        public string HubunganName { get; set; }
        public bool? PreferensiKontak { get; set; }
    }
}
