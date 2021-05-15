using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using SmallBankApplication.Server.Data;
using SmallBankApplication.Server.Models;
using SmallBankApplication.Shared.Models;

namespace SmallBankApplication.Server.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ApplicationDbContext db;
        private IConfiguration _configuration;
        public AuthenticationService(ApplicationDbContext db, IConfiguration config)
        {
            this.db = db;
            _configuration = config;
        }

        public JwtSecurityToken Authenticate(AuthenticationModel authenticationModel)
        {
            try
            {
                ApplicationUser applicationUser = db.ApplicationUsers?.FirstOrDefault(item => item.Email == authenticationModel.Email);

                if (applicationUser is null)
                {
                    return null;
                }
                var claims = new[]
               {
                new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim("FullName", authenticationModel.FullName),
                new Claim("Email",authenticationModel.Email),
                new Claim("Id", applicationUser.Id)
            };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                return new JwtSecurityToken(_configuration["Jwt:Issuer"],
                                   _configuration["Jwt:Audience"],
                                   claims,
                                   expires: DateTime.UtcNow.AddHours(1),
                                   signingCredentials: signIn);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}