using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiExample.Domain;

namespace WebApiExample.Data.Repositories
{
    internal class CustomerRepository : ICustomerRepository
    {
        private readonly WebApiExampleContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(WebApiExampleContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Customer> GetCustomer(long id, int maxAmountOfTransactions)
        {
            var customer = await GetCustomersWithLastTransactions(maxAmountOfTransactions).SingleOrDefaultAsync(c => c.ID == id);
            return _mapper.Map<Customer>(customer);
        }

        public async Task<Customer> GetCustomer(string email, int maxAmountOfTransactions)
        {
            var customer = await GetCustomersWithLastTransactions(maxAmountOfTransactions).SingleOrDefaultAsync(c => c.Email == email);
            return _mapper.Map<Customer>(customer);
        }

        private IQueryable<Entities.Customer> GetCustomersWithLastTransactions(int amountOfTransactions)
        {
            return _context.Customers
                .Select(c => new Entities.Customer
                {
                    Email = c.Email,
                    ID = c.ID,
                    Mobile = c.Mobile,
                    Name = c.Name,
                    Transactions = c.Transactions.OrderByDescending(t => t.Date).Take(amountOfTransactions)
                });
        }
    }
}
