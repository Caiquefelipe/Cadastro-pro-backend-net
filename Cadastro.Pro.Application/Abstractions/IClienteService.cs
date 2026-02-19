using Cadastro.Pro.Application.DTOs;
using Cadastro.Pro.Domain.Entities;

namespace Cadastro.Pro.Application.Abstractions
{
    public interface ICustomerService
    {
        Task<Customer> Create(Customer customer);
        Task<bool> DeleteCustomer(int id);
        Task<Customer?> GetByIdAsync(int id);
        Task<List<Customer>> List();
        Task<bool> UpdateCustomer(int id, UpdateCustomerDto dto);


    }
}