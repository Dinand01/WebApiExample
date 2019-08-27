using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiExample.Domain
{
    public class Transaction
    {
        public long ID { get; set; }

        public DateTime Date { get; set; }

        public double Amount { get; set; }

        public CurrencyCode Currency { get; set; }

        public TransactionStatus Status { get; set; }
    }
}
