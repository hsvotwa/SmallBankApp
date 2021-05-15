using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Services
{
    public class TransactionService : ITransactionService
    {
        ApiClient _Client;
        public TransactionService() => _Client = new ApiClient(new Configuration());

        public async Task<ICollection<Transaction>> GetAll()
        {
            try
            {
                return await _Client.Transactions_GetAllAsync();
            }
            catch { }
            return null;
        }

        public async Task<Transaction> Details(Guid? id)
        {
            try
            {
                return await _Client.Transactions_DetailsAsync(id);
            }
            catch { }
            return null;
        }

        public async Task<ApiBooleanResponse> Create(Transaction newTransaction)
        {
            try
            {
                return await _Client.Transactions_CreateAsync(newTransaction);
            }
            catch { }
            return new ApiBooleanResponse
            {
                Success = false,
                Description = "Error creating record"
            };
        }

        public async Task<ApiBooleanResponse> Edit(Guid id, Transaction Transaction)
        {
            try
            {
                return await _Client.Transactions_EditAsync(id, Transaction);
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
