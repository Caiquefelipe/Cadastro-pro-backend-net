using Cadastro.Pro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Pro.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
