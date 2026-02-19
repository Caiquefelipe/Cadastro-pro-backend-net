using Cadastro.Pro.Application.Abstractions;
using Cadastro.Pro.Application.DTOs;
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
        public async Task<bool> UpdateCustomer(int id, UpdateCustomerDto dto)
        {
            var customer = await _repository.GetByIdAsync(id);

            if (customer == null)
                return false;

            customer.Name = dto.Name;
            customer.Phone = dto.Phone;
            customer.PostalCode = dto.PostalCode;
            customer.Address = dto.Address;
            customer.AddressNumber = dto.AddressNumber;
            customer.Neighborhood = dto.Neighborhood;
            customer.City = dto.City;
            customer.State = dto.State;
            customer.Description = dto.Description;

            await _repository.SaveChangesAsync();

            return true;
        }

    }

}
