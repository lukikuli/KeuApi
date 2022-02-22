using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KeuAPI.Models
{
    public partial class User
    {
        public Guid UserId { get; set; }
        public Guid? RoleId { get; set; }
        public string Name { get; set; }
        public string Nik { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? Archive { get; set; }
        //public DateTime? RefreshTokenExpiryTime { get; set; }
        //public string RefreshToken { get; set; }
    }
}
