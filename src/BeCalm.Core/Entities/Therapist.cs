

namespace BeCalm.Core.Entities
{
    public class Therapist
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }

        public virtual User Identity { get; set; }
        public virtual ICollection<TherapistPatient> Patients { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }  
        public virtual ICollection<Speciality> Specialities { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }

    }
}
