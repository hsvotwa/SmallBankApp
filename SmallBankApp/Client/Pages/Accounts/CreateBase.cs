using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using SmallBankApp.Shared.Models;
using SmallBankApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SmallBankApp.Client.Pages.Accounts
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

        protected NewAccountViewModel _Account { get; set; } = new NewAccountViewModel();
        protected List<AccountType> _AccountTypes { get; set; } = new List<AccountType>();
        protected List<Currency> _Currencies { get; set; } = new List<Currency>();

        protected override async Task OnInitializedAsync()
        {
            await GetLookups();
        }

        protected async Task GetLookups()
        {
            _AccountTypes = await _HttpClient.GetFromJsonAsync<List<AccountType>>($"api/Lookups/get-all-account-types");
            _Currencies = await _HttpClient.GetFromJsonAsync<List<Currency>>($"api/Lookups/get-all-currencies");
        }

        protected async Task SaveAccount()
        {
            await _HttpClient.GetFromJsonAsync<List<AccountType>>($"api/Lookups/get-all-account-types");
            _Currencies = await _HttpClient.GetFromJsonAsync<List<Currency>>($"api/Lookups/get-all-currencies");
        }

        protected async Task SaveActionAsync()
        {
            var response = await _HttpClient.PostAsJsonAsync($"api/Accounts", _Account);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //
                StateHasChanged();
            }
            bool _bApiResponse = JsonConvert.DeserializeObject<bool>(apiResponse);

            if (_bApiResponse)
            {
                return;
            }
        }

        protected void CancelAsync()
        {
            _NavigationManager.NavigateTo("/Accounts");
        }
    }
}