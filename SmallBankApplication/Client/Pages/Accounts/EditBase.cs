using System;
using Microsoft.AspNetCore.Components;
using SmallBankApplication.Client.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Pages.Accounts
{
    public class EditBase : ComponentBase
    {
        private string accountTypeID;
        private string currencyID;

        [Inject]
        protected NavigationManager _NavigationManager { get; set; }
        public bool IsBusy { get; set; }
        public string AccountTypeID { get => accountTypeID; set { accountTypeID = value; SetAccountType(); } }
        public string CurrencyID { get => currencyID; set { currencyID = value; SetCurrency(); } }
        [Parameter] public string AccountID { get; set; }

        [Inject]
        protected ILookupService _LookupService { get; set; }
        [Inject]
        protected IAccountService _AccountService { get; set; }

        protected Account _Account { get; set; } = new Account();
        protected ICollection<AccountType> _AccountTypes { get; set; } = new List<AccountType>();
        protected ICollection<Currency> _Currencies { get; set; } = new List<Currency>();

        protected override async Task OnInitializedAsync()
        {
            await GetLookups();
        }

        protected async Task GetLookups()
        {
            _AccountTypes = await _LookupService.GetAllAccountTypes();
            _Currencies = await _LookupService.GetAllCurrencies();
            _Account = await _AccountService.Details(Guid.Parse(AccountID));
            AccountTypeID = _Account.AccountTypeID.ToString();
            CurrencyID = _Account.CurrencyID.ToString();
        }

        protected void SetAccountType()
        {
            _Account.AccountTypeID = int.Parse(AccountTypeID);
        }

        protected void SetCurrency()
        {
            _Account.CurrencyID = int.Parse(CurrencyID);
        }

        protected async Task SaveActionAsync()
        {
            var response = await _AccountService.Edit(_Account.AccountID, _Account);
            if (response.Success)
            {
                StateHasChanged();
                return;
            }
        }

        protected void CancelAsync()
        {
            _NavigationManager.NavigateTo("/Accounts");
        }
    }
}
