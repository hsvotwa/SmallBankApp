using Microsoft.AspNetCore.Components;
using SmallBankApp.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SmallBankApp.Client.Pages.Transactions
{
    public class ListBase : ComponentBase
    {
        [Inject]
        HttpClient _HttpClient { get; set; }

        [Inject]
        protected NavigationManager navigationManager { get; set; }
        public bool IsBusy { get; set; }

        protected List<Transaction> _Transactions { get; set; } = new List<Transaction>();

        protected override async Task OnInitializedAsync()
        {
            await Refresh();
        }

        protected async Task Refresh()
        {
            IsBusy = true;
            _Transactions = await _HttpClient.GetFromJsonAsync<List<Transaction>>($"api/Transactions/GetAll");
            StateHasChanged();
            IsBusy = false;
        }
    }
}