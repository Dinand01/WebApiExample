using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiExample.Data.Entities;

namespace WebApiExample.Data
{
    internal class WebApiExampleContext : DbContext
    {
        private static bool _isMigrated = false;

        public WebApiExampleContext(DbContextOptions<WebApiExampleContext> options) : base(options)
        {
            MigrateDatabase();
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var customer = modelBuilder.Entity<Customer>();
            customer.Property(c => c.ID).HasColumnType("decimal(10)");
            customer.Property(c => c.Name).HasColumnType("varchar(30)");
            customer.Property(c => c.Email).HasColumnType("varchar(25)");
            customer.Property(c => c.Mobile).HasColumnType("decimal(10)");

            var transation = modelBuilder.Entity<Transaction>();
            transation.Property(t => t.Amount).HasColumnType("decimal(10, 2)");
            transation.Property(t => t.Currency)
                .HasColumnType("varchar(3)")
                .HasConversion(new EnumToStringConverter<Domain.CurrencyCode>());
            transation.Property(t => t.Status)
                .HasColumnType("varchar(10)")
                .HasConversion(new EnumToStringConverter<Domain.TransactionStatus>());
            transation.Property(t => t.CustomerID).HasColumnType("decimal(10)");
        }

        private void MigrateDatabase()
        {
            if (!_isMigrated)
            {
                this.Database.Migrate();
                _isMigrated = true;
            }
        }
    }
}
