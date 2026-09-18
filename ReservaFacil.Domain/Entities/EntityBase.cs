using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaFacil.Domain.Entities
{
    public class EntityBase
    {
        public long Id { get; set; }
        public bool Ativo { get; set; }

        public DateTime DataCriacao { get; set;}
    }
}
