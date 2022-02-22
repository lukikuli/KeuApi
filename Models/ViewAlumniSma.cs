using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class ViewAlumniSma
    {
        public DateTime DateTime { get; set; }
        public string Angkatan { get; set; }
        public string Sekolah { get; set; }
        public string Kelas { get; set; }
        public string Spj { get; set; }
        public string NamaSiswa { get; set; }
        public string Jurusan { get; set; }
    }
}
