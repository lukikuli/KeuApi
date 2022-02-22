using System;
using System.Text.Json.Serialization;
using KeuAPI.Models.Jwt;

namespace KeuAPI.Models.Jwt
{
    public class AuthenticateResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string JwtToken { get; set; }

        [JsonIgnore] // refresh token is returned in http only cookie
        public string RefreshToken { get; set; }

        public AuthenticateResponse(User user, string jwtToken, string refreshToken)
        {
            Id = user.UserId.ToString();
            Name = user.Name;
            Username = user.UserName;
            JwtToken = jwtToken;
            RefreshToken = refreshToken;
        }
    }
}
