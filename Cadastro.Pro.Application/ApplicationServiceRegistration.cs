using Cadastro.Pro.Application.Abstractions;
using Cadastro.Pro.Application.Services;
using Cadastro.Pro.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Cadastro.Pro.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Services
            services.AddTransient<ICustomerService, CustomerService>();

            return services;
        }
    }
}
