using System.ComponentModel.DataAnnotations;

namespace SmallBankApplication.Shared.ViewModels
{
    public class NewAccountViewModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public decimal InitialDeposit { get; set; }

        [Required]
        public int AccountTypeID { get; set; }

        [Required]
        public int CurrencyID { get; set; }
    }
}
