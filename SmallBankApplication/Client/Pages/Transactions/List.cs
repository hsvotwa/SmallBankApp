using Microsoft.AspNetCore.Components;
using SmallBankApplication.Client.Services;
using SmallBankApplication.Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Pages.Transactions
{
    public class ListBase : ComponentBase
    {

        [Inject]
        protected NavigationManager navigationManager { get; set; }
        public bool IsBusy { get; set; }

        protected ICollection<Transaction> _Transactions { get; set; } = new List<Transaction>();

        [Inject]
        protected ILookupService _LookupService { get; set; }

        [Inject]
        protected NavigationManager _NavigationManager { get; set; }

        [Inject]
        protected ITransactionService _TransactionService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Refresh();
        }

        protected async Task Refresh()
        {
            IsBusy = true;
            _Transactions = await _TransactionService.GetAll();
            StateHasChanged();
            IsBusy = false;
        }

        protected void Create()
        {
            _NavigationManager.NavigateTo("/CreateTransaction");
        }

        protected void EditTransaction(Guid accountId)
        {
            _NavigationManager.NavigateTo($"/EditTransaction/{accountId}");
        }
    }
}