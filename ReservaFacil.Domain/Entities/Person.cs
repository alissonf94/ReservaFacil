using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaFacil.Domain.Entities
{
    public class Person : EntityBase
    {
        public required string Name { get; set; }
        public required string Senha { get; set; }

        public required string Email { get; set;}
    }
}
