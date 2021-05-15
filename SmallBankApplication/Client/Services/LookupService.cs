using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Services
{
    public class LookupService : ILookupService
    {
        ApiClient _Client;
        public LookupService() => _Client = new ApiClient(new Configuration());

        public async Task<ICollection<AccountType>> GetAllAccountTypes()
        {
            try
            {
                return await _Client.Lookups_GetAllAccountTypesAsync();
            }
            catch { }
            return null;
        }

        public async Task<ICollection<Currency>> GetAllCurrencies()
        {
            try
            {
                return await _Client.Lookups_GetAllCurrenciesAsync();
            }
            catch { }
            return null;
        }

        public async Task<ApiBooleanResponse> InitAll()
        {
            try
            {
                return await _Client.Lookups_InitAllAsync();
            }
            catch { }
            return new ApiBooleanResponse
            {
                Success = false,
                Description = "Error updating records"
            };
        }
    }
}
