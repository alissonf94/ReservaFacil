using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaFacil.Domain.Enums;

namespace ReservaFacil.Domain.Entities
{
    public class Appointment : EntityBase
    {
        public DateTime StartDateTime { get; set;}
        public DateTime EndDateTime { get; set;}

        public AppointmentStatusEnum Status { get; set;}

        public required Client Client { get; set;}

        public required ServiceOffering ServiceOffering { get; set;}
    }
}
