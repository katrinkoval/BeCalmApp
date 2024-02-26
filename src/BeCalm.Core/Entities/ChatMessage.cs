using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeCalm.Core.Entities
{
    internal class ChatMessage
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public int SenderId {  get; set; }
        public string Text { get; set; }
        public DateTime SentAt { get; set; }
    }
}
