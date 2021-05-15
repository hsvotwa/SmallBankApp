using System;

namespace SmallBankApplication.Server.Services
{
    public class AccountService : IAccountService
    {
        public string GenerateNewAccountNumber()
        {
            return DateTime.Now.ToString("dd MM yyyy HH mm ss ff").Replace(" ", ""); //Just a number that will be unique
        }
    }
}