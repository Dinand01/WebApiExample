using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.Domain;

namespace WebApiExample.Controllers
{
    [Route("customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public List<Customer> Get()
        {
            return new List<Customer>
            {
                new Customer
                {
                    CustomerID = 1,
                    Email = "temp",
                    Name = "temp",
                    Transactions = new List<Transaction>
                    {
                        new Transaction
                        {
                            Date = new DateTime(2019, 1, 1, 12, 1, 0),
                            Currency = CurrencyCode.JPY,
                            Status = TransactionStatus.Failed
                        }
                    }
                }
            };
        }

    }
}