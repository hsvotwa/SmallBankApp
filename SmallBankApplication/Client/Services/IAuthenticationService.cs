using System.Threading.Tasks;

namespace SmallBankApplication.Client.Services
{
    public interface IAuthenticationService
    {
        Task<string> Token(AuthenticationModel authenticationModel);
    }
}