using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallBankApp.Shared.Models
{
    public class Transaction
    {
        [Key]
        public Guid TransactionID { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string TraceReference { get; set; }

        [Required]
        [ForeignKey("SourceAccount")]
        public Guid SourceAccountID { get; set; }
        public virtual Account SourceAccount { get; set; }

        [Required]
        [ForeignKey("DestinationAccount")]
        public Guid DestinationAccountID { get; set; }
        public virtual Account DestinationAccount { get; set; }
    }
}