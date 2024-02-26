using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeCalm.Core.Entities
{
    internal class Appointment
    {
        public int Id { get; set; }
        public int TherapistId { get; set; }
        public int PatientId { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public int Status { get; set; }
    }
}
