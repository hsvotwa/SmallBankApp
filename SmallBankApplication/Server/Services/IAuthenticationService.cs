using System.IdentityModel.Tokens.Jwt;
using SmallBankApplication.Shared.Models;

namespace SmallBankApplication.Server.Services
{
    public interface IAuthenticationService
    {
        JwtSecurityToken Authenticate(AuthenticationModel authenticationModel);
    }
}