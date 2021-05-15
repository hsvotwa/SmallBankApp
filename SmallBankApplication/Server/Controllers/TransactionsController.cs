using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmallBankApplication.Server.Data;
using SmallBankApplication.Shared.Models;
using Microsoft.EntityFrameworkCore;
using SmallBankApplication.Server.Models;
using NSwag.Annotations;

namespace SmallBankApplication.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ApplicationDbContext _Context;

        public TransactionsController(ApplicationDbContext context)
        {
            _Context = context;
        }

        [HttpGet("GetAll")]
        [SwaggerResponse(typeof(List<Transaction>))]
        public async Task<List<Transaction>> GetAll()
        {
            var applicationDbContext = _Context.Transactions.Include(t => t.DestinationAccount).Include(t => t.SourceAccount);
            return await applicationDbContext.ToListAsync();
        }

        [HttpGet("Details/{id}")]
        [SwaggerResponse(typeof(Transaction))]
        public async Task<Transaction> Details(Guid? id)
        {
            if (id == null)
            {
                return null;
            }
            return await _Context.Transactions
                .Include(t => t.DestinationAccount)
                .Include(t => t.SourceAccount)
                .FirstOrDefaultAsync(m => m.TransactionID == id);
        }

        [HttpPost("Create")]
        [SwaggerResponse(typeof(ApiBooleanResponse))]
        public async Task<ApiBooleanResponse> Create(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                transaction.TransactionID = Guid.NewGuid();
                _Context.Add(transaction);
                bool result = await _Context.SaveChangesAsync() > 0;
                return new ApiBooleanResponse
                {
                    Success = result,
                    Description = result ? "Success" : "Error saving record"
                };
            }
            return new ApiBooleanResponse
            {
                Success = false,
                Description = "Invalid fields"
            };
        }

        [HttpPut("Edit/{id}")]
        [SwaggerResponse(typeof(ApiBooleanResponse))]
        public async Task<ApiBooleanResponse> Edit(Guid id, Transaction transaction)
        {
            if (id != transaction.TransactionID)
            {
                return new ApiBooleanResponse
                {
                    Success = false,
                    Description = "Invalid transaction ID"
                };
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _Context.Update(transaction);
                    bool result = await _Context.SaveChangesAsync() > 0;
                    return new ApiBooleanResponse
                    {
                        Success = result,
                        Description = result ? "Success" : "Error saving record"
                    };
                }
                catch (Exception)
                {
                }
            }
            return new ApiBooleanResponse
            {
                Success = false,
                Description = "Error saving record"
            };
        }
    }
}