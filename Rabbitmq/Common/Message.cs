using System;

namespace Common
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public string TextMessage { get; set; }
        public DateTime Date { get; set; }
    }
}
