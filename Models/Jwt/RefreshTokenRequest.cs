using System;
using System.ComponentModel.DataAnnotations;

namespace KeuAPI.Models.Jwt
{
    public class RefreshTokenRequest
    {
        [Required]
        public string Token { get; set; }
    }
}
