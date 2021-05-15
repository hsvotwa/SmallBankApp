using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Services
{
    public interface IAccountService
    {
        Task<ApiBooleanResponse> Create(NewAccountViewModel newAccount);
        Task<Account> Details(Guid? id);
        Task<ApiBooleanResponse> Edit(Guid id, Account account);
        Task<ICollection<Account>> GetAll();
    }
}