using System.ComponentModel.DataAnnotations;

namespace SmallBankApp.Shared.Models
{
    public class Currency
    {
        [Key]
        public int CurrencyID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}