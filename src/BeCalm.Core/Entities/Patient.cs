

namespace BeCalm.Core.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
                
        public virtual User Identity { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<TherapistPatient> Therapists { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }

    }
}
