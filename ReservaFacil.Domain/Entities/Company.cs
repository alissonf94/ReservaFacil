using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaFacil.Domain.Entities
{
    public class Company : EntityBase
    {
        public required string Document {  get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        public List<Employee>? Employees { get; set; }
    }
}
