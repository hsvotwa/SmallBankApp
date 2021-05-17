using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using SmallBankApplication.Client.Services;
using SmallBankApplication.Shared.Models;
using SmallBankApplication.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Pages.Transactions
{
    public class CreateBase : ComponentBase
    {
        private string sourceAccountId;
        private string destinationAccountId;

        [Inject]
        protected NavigationManager _NavigationManager { get; set; }
        public bool IsBusy { get; set; }
        public string SourceAccountId { get => sourceAccountId; set { sourceAccountId = value; SetSourceAccount(); } }
        public string DestinationAccountId { get => destinationAccountId; set { destinationAccountId = value; SetDestinationAccount(); } }

        protected Transaction _Transaction { get; set; } = new Transaction();
        protected ICollection<Account> _Accounts { get; set; } = new List<Account>();
        protected ICollection<Currency> _Currencies { get; set; } = new List<Currency>();
        [Inject]
        protected IAccountService _AccountService { get; set; }
        [Inject]
        protected ITransactionService _TransactionService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _Accounts = await _AccountService.GetAll();
            _Accounts.Add(new Account
            {
                FullName = " Please Select",
                AccountID = Guid.Empty,
                AccountNumber = "--"
            });
            SourceAccountId = Guid.Empty.ToString();
            DestinationAccountId = Guid.Empty.ToString();
            StateHasChanged();
        }

        protected void SetSourceAccount()
        {
            _Transaction.SourceAccountID = Guid.Parse(SourceAccountId);
        }

        protected void SetDestinationAccount()
        {
            _Transaction.DestinationAccountID = Guid.Parse(DestinationAccountId);
        }

        protected async Task SaveActionAsync()
        {
            var response = await _TransactionService.Create(_Transaction);
            if (response.Success)
            {
                //
                StateHasChanged();
                return;
            }
        }

        protected void CancelAsync()
        {
            _NavigationManager.NavigateTo("/Transactions");
        }
    }
}