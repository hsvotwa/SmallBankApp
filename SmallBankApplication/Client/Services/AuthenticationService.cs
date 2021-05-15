using System.Threading.Tasks;

namespace SmallBankApplication.Client.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        ApiClient _Client;
        public AuthenticationService() => _Client = new ApiClient(new Configuration());

        public async Task<string> Token(AuthenticationModel authenticationModel)
        {
            try
            {
                return await _Client.Authentication_TokenAsync(authenticationModel);
            }
            catch { }
            return "Error authenticating user";
        }
    }
}
