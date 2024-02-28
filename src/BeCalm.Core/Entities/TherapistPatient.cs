

namespace BeCalm.Core.Entities
{
    public class TherapistPatient
    {
        public int TherapistId { get; set; }
        public int PatientId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Therapist Therapist { get; set; }
    }
}
