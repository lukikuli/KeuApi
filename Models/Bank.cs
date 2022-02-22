using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class Bank
    {
        public Guid? BankId { get; set; }
        public string Name { get; set; }
        public string PrefixVa { get; set; }
        public string PrefixVadanaSatuTahun { get; set; }
        public int? Keuangan { get; set; }
    }
}
