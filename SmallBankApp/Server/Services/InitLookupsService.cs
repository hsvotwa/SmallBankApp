using SmallBankApp.Server.Data;
using SmallBankApp.Shared.Common;
using SmallBankApp.Shared.Models;

namespace SmallBankApp.Server.Services
{
    public class InitLookupsService : IInitLookupsService
    {
        public InitLookupsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext _context { get; set; }

        public void InitAccountTypes()
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
        }

        public void InitCurrencies()
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
        }
    }

    public interface IInitLookupsService
    {
        ApplicationDbContext _context { get; set; }
        void InitAccountTypes();
        void InitCurrencies();
    }
}
