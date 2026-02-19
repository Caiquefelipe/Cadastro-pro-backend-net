using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.Pro.Domain.Entities
{
    [Table("Customers")]
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string BirthDate { get; set; }

        public string PostalCode { get; set; }

        public string Address { get; set; }

        public string AddressNumber { get; set; }

        public string Neighborhood { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string? Description { get; set; }
    }
}
