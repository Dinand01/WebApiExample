using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApiExample.Domain;

namespace WebApiExample.Data.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomer(long id, int maxAmountOfTransactions);

        Task<Customer> GetCustomer(string email, int maxAmountOfTransactions);

        Task<Customer> GetCustomer(long? id, string email, int maxAmountOfTransactions);
    }
}
