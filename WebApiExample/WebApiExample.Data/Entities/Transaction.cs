using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebApiExample.Domain;

namespace WebApiExample.Data.Entities
{
    internal class Transaction
    {
        [Key]
        public long ID { get; set; }

        public DateTime Date { get; set; }

        public double Amount { get; set; }

        public CurrencyCode Currency { get; set; }

        public TransactionStatus Status { get; set; }

        public long CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
