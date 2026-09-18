using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaFacil.Domain.Entities
{
    public class ServiceOffering : EntityBase
    {
        public required string Name { get; set; }
        public required int DurationInMinutes {  get; set; }
    }
}
