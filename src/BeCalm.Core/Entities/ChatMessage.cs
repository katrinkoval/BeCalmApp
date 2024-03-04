
namespace BeCalm.Core.Entities
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public string SenderId {  get; set; }
        public string Text { get; set; }
        public DateTime SentAt { get; set; }

        public virtual User Sender { get; set; }
    }
}
