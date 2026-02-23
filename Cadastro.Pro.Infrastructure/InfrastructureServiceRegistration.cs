using Cadastro.Pro.Domain.Interfaces;
using Cadastro.Pro.Infrastructure.Data;
using Cadastro.Pro.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cadastro.Pro.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
         options.UseNpgsql(
             config.GetConnectionString("DefaultConnection"),
             o =>
             {
                 o.EnableRetryOnFailure(3);
                 o.CommandTimeout(60);
             }
         )
     );

            // Repositories
            services.AddTransient<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}
