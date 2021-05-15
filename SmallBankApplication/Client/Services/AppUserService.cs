using System.Threading.Tasks;

namespace SmallBankApplication.Client.Services
{
    public class AppUserService : IAppUserService
    {
        ApiClient _Client;
        public AppUserService() => _Client = new ApiClient(new Configuration());

        public async Task<ApiBooleanResponse> Create(ApplicationUser user)
        {
            try
            {
                return await _Client.ApplicationUsers_CreateAsync(user);
            }
            catch { }
            return new ApiBooleanResponse
            {
                Success = false,
                Description = "Error creating record"
            };
        }
    }
}
