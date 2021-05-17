using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallBankApplication.Server.Models
{
    public class AccountType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountTypeID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
