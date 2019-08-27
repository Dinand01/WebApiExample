using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiExample.Data.Entities;

namespace WebApiExample.Data.Extensions
{
    internal static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    ID = 1,
                    Name = "John Doe",
                    Mobile = 9234567891,
                    Email = "john.doe@test.com"
                }
            );

            modelBuilder.Entity<Transaction>().HasData(
                new Transaction { ID = 1, CustomerID = 1, Date = DateTime.Now.AddDays(-1), Amount = 22.30, Currency = Domain.CurrencyCode.USD, Status = Domain.TransactionStatus.Success },
                new Transaction { ID = 2, CustomerID = 1, Date = DateTime.Now.AddDays(-2), Amount = 2500.30, Currency = Domain.CurrencyCode.THB, Status = Domain.TransactionStatus.Success },
                new Transaction { ID = 3, CustomerID = 1, Date = DateTime.Now.AddDays(-3), Amount = 27800.30, Currency = Domain.CurrencyCode.THB, Status = Domain.TransactionStatus.Canceled },
                new Transaction { ID = 4, CustomerID = 1, Date = DateTime.Now.AddDays(-4), Amount = 200.30, Currency = Domain.CurrencyCode.THB, Status = Domain.TransactionStatus.Canceled },
                new Transaction { ID = 5, CustomerID = 1, Date = DateTime.Now.AddDays(-5), Amount = 200.31, Currency = Domain.CurrencyCode.THB, Status = Domain.TransactionStatus.Canceled },
                new Transaction { ID = 6, CustomerID = 1, Date = DateTime.Now.AddDays(-6), Amount = 200.32, Currency = Domain.CurrencyCode.THB, Status = Domain.TransactionStatus.Canceled },
                new Transaction { ID = 7, CustomerID = 1, Date = DateTime.Now.AddDays(-7), Amount = 200.31, Currency = Domain.CurrencyCode.THB, Status = Domain.TransactionStatus.Canceled },
                new Transaction { ID = 8, CustomerID = 1, Date = DateTime.Now.AddDays(-8), Amount = 200.31, Currency = Domain.CurrencyCode.THB, Status = Domain.TransactionStatus.Canceled },
                new Transaction { ID = 9, CustomerID = 1, Date = DateTime.Now.AddDays(-9), Amount = 200.31, Currency = Domain.CurrencyCode.THB, Status = Domain.TransactionStatus.Canceled },
                new Transaction { ID = 10, CustomerID = 1, Date = DateTime.Now.AddDays(-10), Amount = 200.31, Currency = Domain.CurrencyCode.THB, Status = Domain.TransactionStatus.Canceled },
                new Transaction { ID = 11, CustomerID = 1, Date = DateTime.Now.AddDays(-10), Amount = 200.31, Currency = Domain.CurrencyCode.JPY, Status = Domain.TransactionStatus.Failed },
                new Transaction { ID = 12, CustomerID = 1, Date = DateTime.Now.AddDays(-10), Amount = 200.31, Currency = Domain.CurrencyCode.JPY, Status = Domain.TransactionStatus.Failed },
                new Transaction { ID = 13, CustomerID = 1, Date = DateTime.Now.AddDays(-10), Amount = 200.31, Currency = Domain.CurrencyCode.JPY, Status = Domain.TransactionStatus.Failed }
            ); 
        }
    }
}
