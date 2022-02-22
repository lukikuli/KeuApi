using KeuAPI.Data;
using KeuAPI.Models;
using KeuAPI.Models.Jwt;
using KeuAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KeuAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] AuthenticateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                var refreshToken = Request.Cookies["RefreshToken"];
                var response = _userService.Authenticate(request);
                SetTokenCookie(response.RefreshToken);
                return Ok(response);
            }
            catch (InvalidCredentialException)
            {
                return Unauthorized();
            }
            //_context.User.Add(user);
            //await _context.SaveChangesAsync();
        }

        //[HttpGet("user")]
        //[Authorize]
        //public ActionResult GetCurrentUser()
        //{
        //    return Ok(new LoginResult
        //    {
        //        UserName = User.Identity?.Name,
        //        Role = User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty,
        //        OriginalUserName = User.FindFirst("OriginalUserName")?.Value
        //    });
        //}

        //[HttpPost("logout")]
        //[Authorize]
        //public ActionResult Logout()
        //{
        //    var userName = User.Identity?.Name;
        //    _jwtAuthManager.RemoveRefreshTokenByUserName(userName);
        //    _logger.LogInformation($"User [{userName}] logged out the system.");
        //    return Ok();
        //}

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        public async Task<ActionResult> RefreshToken()
        {
            try
            {
                var refreshToken = Request.Cookies["RefreshToken"];
                var accessToken = await HttpContext.GetTokenAsync("Bearer", "access_token");

                if (string.IsNullOrWhiteSpace(refreshToken))
                {
                    return Unauthorized();
                }
                var response = _userService.Refresh(refreshToken, accessToken, DateTime.Now);
                SetTokenCookie(response.RefreshToken);
                return Ok(response);
            }
            catch (SecurityTokenException e)
            {
                return Unauthorized(e.Message); // return 401 so that the client side can redirect the user to login page
            }
        }


        // helper methods
        private void SetTokenCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddMinutes(15),
                //Expires = DateTime.UtcNow.AddDays(7),
                SameSite = SameSiteMode.None,
                Secure = true
            };
            Response.Cookies.Append("RefreshToken", token, cookieOptions);
            //HttpContext.Session.SetString("RefreshToken", token);
            //HttpContext.Session.SetString("Expires", cookieOptions.Expires.ToString());
        }
        private string IpAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }

    }
}