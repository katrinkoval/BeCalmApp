

namespace BeCalm.Core.Entities
{
    public class Chat
    {
        public int Id { get; set; }
        public int TherapistId {  get; set; }
        public int PatientId { get; set; }

        public virtual Therapist Therapist { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual List<ChatMessage> Messages { get; set; }
    }
}
