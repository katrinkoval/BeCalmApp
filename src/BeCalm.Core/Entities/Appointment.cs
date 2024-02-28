

namespace BeCalm.Core.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int TherapistId { get; set; }
        public int PatientId { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public AppointmentStatus Status { get; set; }

        public virtual Therapist TherapistAtAppointment { get; set; }
        public virtual Patient PatientAtAppointment { get; set;}

    }
}
