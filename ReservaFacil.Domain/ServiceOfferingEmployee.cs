using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaFacil.Domain.Entities;

namespace ReservaFacil.Domain
{
    public class ServiceOfferingEmployee
    {
        public required Employee Employee { get; set; }
        public required ServiceOffering ServiceOffering {  get; set; }
        
        public decimal Price { get; set; }
    }
}
