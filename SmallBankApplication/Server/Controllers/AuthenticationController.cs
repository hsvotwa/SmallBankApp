using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmallBankApplication.Server.Services;
using SmallBankApplication.Shared.Models;
using System.IdentityModel.Tokens.Jwt;

namespace TwinkleAPI.Server.Controllers
{
    public class AuthenticationController : Controller
    {
        private IAuthenticationService _AuthenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _AuthenticationService = authenticationService;
        }

        [AllowAnonymous]
        [HttpPost("Token")]
        public string Token([FromBody] AuthenticationModel authenticationModel)
        {
            var token = _AuthenticationService.Authenticate(authenticationModel);
            if (token != null)
            {
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            return "Invalid credentials";
        }
    }
}
