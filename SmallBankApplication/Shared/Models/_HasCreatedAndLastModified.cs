using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallBankApplication.Shared.Models
{
    public class HasCreatedAndLastModified
    {
        [Column(TypeName = "DateTime2")]
        public DateTime Created { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime LastModified { get; set; }
    }
}