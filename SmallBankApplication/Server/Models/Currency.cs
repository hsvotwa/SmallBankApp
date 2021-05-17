using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallBankApplication.Server.Models
{
    public class Currency
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CurrencyID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}