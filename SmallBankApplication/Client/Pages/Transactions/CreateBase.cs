using Blazorise.Snackbar;
using Microsoft.AspNetCore.Components;
using SmallBankApplication.Client.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmallBankApplication.Client.Pages.Transactions
{
    public class CreateBase : ComponentBase
    {
        private string sourceAccountId;
        private string destinationAccountId;

        protected Snackbar _Snackbar;
        protected string _SnackbarMessage { get; set; }
        protected SnackbarColor _SnackbarColor { get; set; }

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
            _SnackbarColor = response.Success ? SnackbarColor.Success : SnackbarColor.Danger;
            _SnackbarMessage = response.Description;
            _Snackbar.Show();
            StateHasChanged();
        }

        protected void CancelAsync()
        {
            _NavigationManager.NavigateTo("/Transactions");
        }
    }
}