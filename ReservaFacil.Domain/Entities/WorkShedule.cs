using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaFacil.Domain.Entities
{
    public class WorkShedule:EntityBase
    {
        public required Employee Employee { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }   
        public DateTime BreakStartDateTime { get; set; }
        public DateTime BreakEndDateTime { get; set; }
    }
}
