using System.ComponentModel.DataAnnotations;

namespace SmallBankApp.Shared.Models
{
    public class AccountType
    {
        [Key]
        public int AccountTypeID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
