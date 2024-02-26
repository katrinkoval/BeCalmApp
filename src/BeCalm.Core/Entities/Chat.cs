using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeCalm.Core.Entities
{
    public class Chat
    {
        public int Id { get; set; }
        public int TherapistId {  get; set; }
        public int PatientId { get; set; }
    }
}
