using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiExample.Domain
{
    public class Customer
    {
        public long CustomerID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public long Mobile { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
