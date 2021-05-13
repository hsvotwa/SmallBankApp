using Microsoft.AspNetCore.Components;
using SmallBankApp.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SmallBankApp.Client.Pages.Accounts
{
    public class ListBase : ComponentBase
    {
        [Inject]
        HttpClient _httpClient { get; set; }

        [Inject]
        protected NavigationManager navigationManager { get; set; }
        public bool IsBusy { get; set; }

        protected List<Account> _Accounts { get; set; } = new List<Account>();

        protected override async Task OnInitializedAsync()
        {
            await Refresh();
        }

        protected async Task Refresh()
        {
            IsBusy = true;
            _Accounts = await _httpClient.GetFromJsonAsync<List<Account>>($"api/Accounts/get-accounts");
            StateHasChanged();
            IsBusy = false;
        }


    }
}