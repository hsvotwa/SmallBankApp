using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Services
{
    public class AccountService : IAccountService
    {
        ApiClient _Client;
        public AccountService() => _Client = new ApiClient(new Configuration());

        public async Task<ICollection<Account>> GetAll()
        {
            try
            {
                return await _Client.Accounts_GetAllAsync();
            }
            catch { }
            return null;
        }

        public async Task<Account> Details(Guid? id)
        {
            try
            {
                return await _Client.Accounts_DetailsAsync(id);
            }
            catch { }
            return null;
        }

        public async Task<ApiBooleanResponse> Create(NewAccountViewModel newAccount)
        {
            try
            {
                return await _Client.Accounts_CreateAsync(newAccount);
            }
            catch { }
            return new ApiBooleanResponse
            {
                Success = false,
                Description = "Error creating record"
            };
        }

        public async Task<ApiBooleanResponse> Edit(Guid id, Account account)
        {
            try
            {
                return await _Client.Accounts_EditAsync(id, account);
            }
            catch { }
            return new ApiBooleanResponse
            {
                Success = false,
                Description = "Error updating record"
            };
        }
    }
}