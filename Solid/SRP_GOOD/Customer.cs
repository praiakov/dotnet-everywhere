using System;

namespace SRP_GOOD
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public void Activate()
        {
            Active = true;
        }

        public void Inactivate()
        {
            Active = false;
        }
    }
}
