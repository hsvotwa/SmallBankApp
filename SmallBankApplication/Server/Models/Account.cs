using System;
using SmallBankApplication.Shared.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallBankApplication.Server.Models
{
    public class Account : HasCreatedAndLastModified
    {
        [Key]
        public Guid AccountID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string SortCode { get; set; }

        [Required]
        [ForeignKey("AccountType")]
        public int AccountTypeID { get; set; }
        public virtual AccountType AccountType { get; set; }

        [Required]
        [ForeignKey("Currency")]
        public int CurrencyID { get; set; }
        public virtual Currency Currency { get; set; }
    }
}