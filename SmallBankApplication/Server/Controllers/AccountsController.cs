using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmallBankApplication.Server.Data;
using SmallBankApplication.Shared.Models;
using Microsoft.EntityFrameworkCore;
using SmallBankApplication.Shared.ViewModels;
using SmallBankApplication.Shared.Common;
using SmallBankApplication.Server.Services;
using SmallBankApplication.Server.Models;
using NSwag.Annotations;

namespace SmallBankApplication.Server.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _Context;
        private readonly IAccountService _AccountService;

        public AccountsController(ApplicationDbContext context, IAccountService accountService)
        {
            _Context = context;
            _AccountService = accountService;
        }

        [HttpGet("GetAll")]
        [SwaggerResponse(typeof(List<Account>))]
        public async Task<List<Account>> GetAll()
        {
            var result = _Context.Accounts.Include(a => a.AccountType).Include(a => a.Currency).AsNoTracking();
            return await result.ToListAsync();
        }

        [HttpGet("Details/{id}")]
        [SwaggerResponse(typeof(Account))]
        public async Task<Account> Details(Guid? id)
        {
            if (id == null)
            {
                return null;
            }

            var account = await _Context.Accounts
                .Include(a => a.AccountType)
                .Include(a => a.Currency)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.AccountID == id);
            return account;
        }

        [HttpPost("Create")]
        [SwaggerResponse(typeof(ApiBooleanResponse))]
        public async Task<ApiBooleanResponse> Create(NewAccountViewModel newAccount)
        {
            if (ModelState.IsValid)
            {
                var account = new Account
                {
                    AccountID = Guid.NewGuid(),
                    CurrencyID = newAccount.CurrencyID,
                    AccountTypeID = newAccount.AccountTypeID,
                    FullName = newAccount.FullName,
                    AccountNumber = _AccountService.GenerateNewAccountNumber(),
                    SortCode = Constants.BANK_SORT_CODE
                };
                _Context.Add(account);
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
        public async Task<ApiBooleanResponse> Edit(Guid id, Account account)
        {
            if (id != account.AccountID)
            {
                return new ApiBooleanResponse
                {
                    Success = false,
                    Description = "Invalid account ID"
                };
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _Context.Update(account);
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