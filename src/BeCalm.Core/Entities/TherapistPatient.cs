using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeCalm.Core.Entities
{
    public class TherapistPatient
    {
        public int Id { get; set; }
        public int TherapistId { get; set; }
        public int PatientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte Status { get; set; }
    }
}
