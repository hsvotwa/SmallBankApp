using Blazorise.Snackbar;
using Microsoft.AspNetCore.Components;
using SmallBankApplication.Client.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Pages.Accounts
{
    public class CreateBase : ComponentBase
    {
        private string accountTypeID;
        private string currencyID;

        protected Snackbar _Snackbar;
        protected string _SnackbarMessage { get; set; }
        protected SnackbarColor _SnackbarColor { get; set; }

        [Inject]
        protected NavigationManager _NavigationManager { get; set; }
        public bool IsBusy { get; set; }
        public string AccountTypeID { get => accountTypeID; set { accountTypeID = value; SetAccountType(); } }
        public string CurrencyID { get => currencyID; set { currencyID = value; SetCurrency(); } }

        [Inject]
        protected ILookupService _LookupService { get; set; }

        [Inject]
        protected IAccountService _AccountService { get; set; }

        protected NewAccountViewModel _Account { get; set; } = new NewAccountViewModel();
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
            AccountTypeID = _AccountTypes.FirstOrDefault()?.AccountTypeID.ToString();
            CurrencyID = _Currencies.FirstOrDefault()?.CurrencyID.ToString();
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
            var response = await _AccountService.Create(_Account);
            _SnackbarColor = response.Success ? SnackbarColor.Success : SnackbarColor.Danger;
            _SnackbarMessage = response.Description;
            _Snackbar.Show();
            StateHasChanged();
        }

        protected void CancelAsync()
        {
            _NavigationManager.NavigateTo("/Accounts");
        }
    }
}