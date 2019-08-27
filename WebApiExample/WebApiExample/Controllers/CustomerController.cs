using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.Data.Repositories;
using WebApiExample.Domain;

namespace WebApiExample.Controllers
{
    [Route("customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [Route("email/{email}")]
        [HttpGet]
        public async Task<ActionResult<Customer>> Get(string email)
        {
            var result = await _customerRepository.GetCustomer(email, 5);
            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<ActionResult<Customer>> Get(long id)
        {
            var result = await _customerRepository.GetCustomer(id, 5);
            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet]
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