using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.Data.Repositories;
using WebApiExample.Domain;
using WebApiExample.Requests;

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

        [HttpPost]
        public async Task<ActionResult<Customer>> Get([FromBody] CustomerRequest customerRequest)
        {
            if (customerRequest?.CustomerID == null && customerRequest?.Email == null)
            {
                return new BadRequestObjectResult("No inquiry criteria");
            }

            var result = await _customerRepository.GetCustomer(customerRequest.CustomerID, customerRequest.Email, 5);
            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}