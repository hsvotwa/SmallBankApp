using System.ComponentModel.DataAnnotations;

namespace SmallBankApplication.Server.Models
{
    public class AccountType
    {
        [Key]
        public int AccountTypeID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
