using Cadastro.Pro.Application.Abstractions;
using Cadastro.Pro.Application.DTOs;
using Cadastro.Pro.Application.Services;
using Cadastro.Pro.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Pro.Api.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer customer)
        {
            if (customer == null)
                return BadRequest("Cliente vazio");

            try
            {
                var created = await _service.Create(customer);
                return CreatedAtAction(nameof(GetCustomer), new { id = created.Id }, created);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var customer = await _service.GetByIdAsync(id);

            if (customer == null)
                return NotFound("Cliente não encontrado");

            return Ok(customer);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _service.List();
            return Ok(customers);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCustomerDto dto)
        {
            var updated = await _service.UpdateCustomer(id, dto);
            if(!updated)
            {
                return NotFound("Cliente não encontrado");
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var deleted = await _service.DeleteCustomer(id);

            if(!deleted)
            { 
                return NotFound("Cliente não encontrado");

            }

           return Ok(deleted);

        }
    }
}