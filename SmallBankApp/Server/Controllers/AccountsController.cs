using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmallBankApp.Server.Data;
using SmallBankApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using SmallBankApp.Shared.ViewModels;
using SmallBankApp.Shared.Common;
using SmallBankApp.Server.Services;

namespace SmallBankApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IAccountService _accountService;

        public AccountsController(ApplicationDbContext context, IAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }

        public async Task<List<Account>> GetAll()
        {
            var applicationDbContext = _context.Accounts.Include(a => a.AccountType).Include(a => a.Currency);
            return await applicationDbContext.ToListAsync();
        }

        public async Task<Account> Details(Guid? id)
        {
            if (id == null)
            {
                return null;
            }

            var account = await _context.Accounts
                .Include(a => a.AccountType)
                .Include(a => a.Currency)
                .FirstOrDefaultAsync(m => m.AccountID == id);
            return account;
        }

        [HttpPost]
        public async Task<bool> Create(NewAccountViewModel newAccount)
        {
            if (ModelState.IsValid)
            {
                var account = new Account
                {
                    AccountID = Guid.NewGuid(),
                    CurrencyID = newAccount.CurrencyID,
                    AccountTypeID = newAccount.AccountTypeID,
                    FullName = newAccount.FullName,
                    AccountNumber = _accountService.GenerateNewAccountNumber(),
                    SortCode = Constants.BANK_SORT_CODE
                };
                _context.Add(account);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }

        [HttpPost]
        public async Task<bool> Edit(Guid id, Account account)
        {
            if (id != account.AccountID)
            {
                return false;
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    return await _context.SaveChangesAsync() > 0;
                }
                catch (Exception)
                {
                }
            }
            return false;
        }
    }
}