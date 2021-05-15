using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Services
{
    public interface ILookupService
    {
        Task<ICollection<AccountType>> GetAllAccountTypes();
        Task<ICollection<Currency>> GetAllCurrencies();
        Task<ApiBooleanResponse> InitAll();
    }
}