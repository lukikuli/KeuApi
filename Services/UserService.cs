using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Security.Cryptography;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using KeuAPI.Data;
using KeuAPI.Infrastructure;
using KeuAPI.Models;
using KeuAPI.Models.Jwt;

namespace KeuAPI.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        AuthenticateResponse Refresh(string refreshToken, string accessToken, DateTime now);
    }

    public class UserService : IUserService
    {
        private readonly KeuApiContext _context;
        private readonly JwtTokenConfig _appSettings;

        public UserService(KeuApiContext context, IOptions<JwtTokenConfig> appSettings)
        {
            this._context = context;
            this._appSettings = appSettings.Value;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            try
            {
                var user = _context.User.Where(x => x.UserName == model.Username && x.Password == model.Password).FirstOrDefault();

                // authentication successful so generate jwt and refresh tokens
                var jwtToken = generateJwtToken(user);
                var refreshToken = generateRefreshToken();

                // save refresh token
                //user.RefreshToken = refreshToken;
                //user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
                //_context.Update(user);
                //_context.SaveChanges();

                return new AuthenticateResponse(user, jwtToken, refreshToken);
            }
            catch (NullReferenceException)
            {
                return null;
            }
            // return null if user not found
        }

        public AuthenticateResponse Refresh(string refreshToken, string accessToken, DateTime now)
        {
            var (principal, jwtToken) = DecodeJwtToken(accessToken);
            if (jwtToken == null || !jwtToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256Signature))
            {
                throw new SecurityTokenException("JWT token null or decode error");
            }
            var userName = principal.Claims.Where(x => x.Type == "UserName").Select(x => x.Value).SingleOrDefault();
            var userID = principal.Claims.Where(x => x.Type == "UserID").Select(x => x.Value).SingleOrDefault();
            var user = _context.User.Where(x => x.UserName == userName && x.UserId == new Guid(userID)).FirstOrDefault();
            if (user == null)
            {
                throw new SecurityTokenException("User not found");
            }
            if (user.UserName != userName)
            {
                throw new SecurityTokenException("Username invalid");
            }
            var newJwtToken = generateJwtToken(user);
            var newRefreshToken = generateRefreshToken();
            //if (user.RefreshTokenExpiryTime <= now)
            //{
            //    newRefreshToken = generateRefreshToken();
                // save refresh token
                //user.RefreshToken = newRefreshToken;
                //user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
                //_context.Update(user);
                //_context.SaveChanges();
            //}

            return new AuthenticateResponse(user, newJwtToken, newRefreshToken);
        }


        // helper methods
        private string generateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Name, ClaimValueTypes.String),
                new Claim("UserName", user.UserName, ClaimValueTypes.String),
                new Claim("UserID", user.UserId.ToString(), ClaimValueTypes.String)
            };

            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(claims),
            //    Expires = DateTime.UtcNow.AddMinutes(20),
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            //};
            //var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = new JwtSecurityToken(
                _appSettings.Issuer,
                _appSettings.Audience,
                claims,
                expires: DateTime.UtcNow.AddMinutes(_appSettings.AccessTokenExpiration),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature));

            return tokenHandler.WriteToken(jwtToken);
        }
        private static string generateRefreshToken()
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[64];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                return Convert.ToBase64String(randomBytes);
            }
        }
        private (ClaimsPrincipal, JwtSecurityToken) DecodeJwtToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                throw new SecurityTokenException("Invalid token (null)");
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var principal = tokenHandler.ValidateToken(token,
                    new TokenValidationParameters
                    {
                        ValidateAudience = true,
                        ValidateIssuer = true,
                        ValidateIssuerSigningKey = true,
                        ValidateLifetime = true,
                        ValidIssuer = _appSettings.Issuer,
                        ValidAudience = _appSettings.Audience,
                        ClockSkew = TimeSpan.FromMinutes(1),
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                    },
                    out var validatedToken);
            return (principal, validatedToken as JwtSecurityToken);
        }
    }
}
