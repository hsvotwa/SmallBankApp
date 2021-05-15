using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Services
{
    public interface ITransactionService
    {
        Task<ApiBooleanResponse> Create(Transaction newTransaction);
        Task<Transaction> Details(Guid? id);
        Task<ApiBooleanResponse> Edit(Guid id, Transaction Transaction);
        Task<ICollection<Transaction>> GetAll();
    }
}