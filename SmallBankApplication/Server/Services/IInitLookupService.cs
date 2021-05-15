using SmallBankApplication.Server.Data;

namespace SmallBankApplication.Server.Services
{
    public interface IInitLookupService
    {
        ApplicationDbContext _context { get; set; }

        bool InitAccountTypes();
        bool InitCurrencies();
    }
}