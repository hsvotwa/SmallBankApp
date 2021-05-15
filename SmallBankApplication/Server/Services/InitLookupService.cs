using SmallBankApplication.Server.Data;
using SmallBankApplication.Server.Models;
using SmallBankApplication.Shared.Common;
using SmallBankApplication.Shared.Models;
using System;

namespace SmallBankApplication.Server.Services
{
    public class InitLookupService : IInitLookupService
    {
        public InitLookupService(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext _context { get; set; }

        public bool InitAccountTypes()
        {
            try
            {
                _context.AccountTypes.Update(new AccountType
                {
                    AccountTypeID = (int)EnumAccountType.Cheque,
                    Name = EnumAccountType.Cheque.ToString()
                });
                _context.AccountTypes.Update(new AccountType
                {
                    AccountTypeID = (int)EnumAccountType.Savings,
                    Name = EnumAccountType.Savings.ToString()
                });
                _context.AccountTypes.Update(new AccountType
                {
                    AccountTypeID = (int)EnumAccountType.Investment,
                    Name = EnumAccountType.Investment.ToString()
                });
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex){ }
            return false;
        }

        public bool InitCurrencies()
        {
            try
            {
                _context.Currencies.Update(new Currency
                {
                    CurrencyID = (int)EnumCurrency.GBP,
                    Name = EnumCurrency.GBP.ToString()
                });
                _context.Currencies.Update(new Currency
                {
                    CurrencyID = (int)EnumCurrency.USD,
                    Name = EnumCurrency.USD.ToString()
                });
                _context.Currencies.Update(new Currency
                {
                    CurrencyID = (int)EnumCurrency.ZAR,
                    Name = EnumCurrency.ZAR.ToString()
                });
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex) { }
            return false;
        }
    }
}
