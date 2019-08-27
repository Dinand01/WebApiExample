using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiExample.Data.Mapper;
using WebApiExample.Data.Repositories;

namespace WebApiExample.Data
{
    public static class DataModule
    {
        public static void Configure(IServiceCollection services, string dbConnection)
        {
            services.AddDbContext<WebApiExampleContext>(options =>
            {
                options.UseSqlServer(dbConnection);
            });

            services.AddAutoMapper(typeof(MapperProfile));

            services.AddTransient<ICustomerRepository, CustomerRepository>();
        }
    }
}
