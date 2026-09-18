using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaFacil.Domain.Enums;

namespace ReservaFacil.Domain.Entities
{
    public class Employee : EntityBase
    {
        public EmployeeType EmployeeType { get; set; }

        public  List<Appointment>? Appointments { get; set; }

        public string? Biography { get; set; }

        public List<WorkShedule>? WorkShedules { get; set; }
    }
}
