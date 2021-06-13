using System;

namespace Redis
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }

        public Client()
        {
            Id = Guid.NewGuid();
        }
    }
}
