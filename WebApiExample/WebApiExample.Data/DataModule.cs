using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
        }
    }
}
