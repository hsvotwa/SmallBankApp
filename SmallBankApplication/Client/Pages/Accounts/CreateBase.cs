using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using SmallBankApplication.Client.Services;
using SmallBankApplication.Shared.Models;
using SmallBankApplication.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Pages.Accounts
{
    public class CreateBase : ComponentBase
    {
        [Inject]
        HttpClient _HttpClient { get; set; }

        [Inject]
        protected NavigationManager _NavigationManager { get; set; }
        public bool IsBusy { get; set; }
        public string AccountTypeID { get; set; }
        public string CurrencyID { get; set; }

        [Inject]
        protected ILookupService _LookupService { get; set; }

        [Inject]
        protected IAccountService _AccountService { get; set; }

        protected NewAccountViewModel _Account { get; set; } = new NewAccountViewModel();
        protected List<AccountType> _AccountTypes { get; set; } = new List<AccountType>();
        protected List<Currency> _Currencies { get; set; } = new List<Currency>();

        protected override async Task OnInitializedAsync()
        {
            await GetLookups();
        }

        protected async Task GetLookups()
        {
            _AccountTypes = (List<AccountType>)await _LookupService.GetAllAccountTypes();
            _Currencies = (List<Currency>)await _LookupService.GetAllCurrencies();
        }

        protected async Task SaveActionAsync()
        {
            var response = await _AccountService.Create(_Account);
            if (response.Success)
            {
                //
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