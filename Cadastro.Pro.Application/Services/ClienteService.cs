using Cadastro.Pro.Application.Abstractions;
using Cadastro.Pro.Domain.Entities;
using Cadastro.Pro.Domain.Interfaces;

namespace Cadastro.Pro.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Customer>> List()
        {
            return _repository.GetAllAsync();
        }

        public Task<Customer?> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<Customer> Create(Customer customer)
        {
            return _repository.AddAsync(customer);
        }

        public Task<bool> DeleteCustomer(int id)
        {
            return _repository.RemoveAsync(id);
        }
    }

}
