using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using SmallBankApp.Shared.Models;
using SmallBankApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SmallBankApp.Client.Pages.Transactions
{
    public class CreateBase : ComponentBase
    {
        [Inject]
        HttpClient _HttpClient { get; set; }

        [Inject]
        protected NavigationManager _NavigationManager { get; set; }
        public bool IsBusy { get; set; }
        public string SourceAccountId { get; set; }
        public string DestinationAccountId { get; set; }

        protected Transaction _Transaction { get; set; } = new Transaction();
        protected List<Account> _Accounts { get; set; } = new List<Account>();
        protected List<Currency> _Currencies { get; set; } = new List<Currency>();

        protected override async Task OnInitializedAsync()
        {
            _Accounts = await _HttpClient.GetFromJsonAsync<List<Account>>($"api/Accounts/GetAll");
        }

        protected async Task SaveActionAsync()
        {
            var response = await _HttpClient.PostAsJsonAsync($"api/Transactions", _Transaction);
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
            _NavigationManager.NavigateTo("/Transactions");
        }
    }
}