using Microsoft.AspNetCore.Components;
using SmallBankApplication.Client.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Pages.Accounts
{
    public class ListBase : ComponentBase
    {
        [Inject]
        HttpClient _httpClient { get; set; }

        [Inject]
        protected NavigationManager _NavigationManager { get; set; }
        public bool IsBusy { get; set; }

        protected ICollection<Account> _Accounts { get; set; } = new List<Account>();

        [Inject]
        protected ILookupService _LookupService { get; set; }

        [Inject]
        protected IAccountService _AccountService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Refresh();
        }

        protected async Task Refresh()
        {
            IsBusy = true;
            _Accounts = await _AccountService.GetAll();
            StateHasChanged();
            IsBusy = false;
        }

        protected void EditAccount(Guid accountId)
        {
            _NavigationManager.NavigateTo($"/EditAccount/{accountId}");
        }

        protected void Create()
        {
            _NavigationManager.NavigateTo("/CreateAccount");
        }
    }
}