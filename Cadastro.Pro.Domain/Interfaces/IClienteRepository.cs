using Cadastro.Pro.Domain.Entities;

namespace Cadastro.Pro.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task<Customer> AddAsync(Customer customer);
        Task<bool> RemoveAsync(int id);
        Task<Customer> UpdateClientAsync(Customer customer);
    }
}
