using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Pro.Application.DTOs
{
    public class UpdateCustomerDto
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string PostalCode { get; set; }

        public string Address { get; set; }

        public string AddressNumber { get; set; }

        public string Neighborhood { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string? Description { get; set; }
    }
}
