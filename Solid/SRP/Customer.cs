namespace SRP
{
    public sealed class Customer
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

        public void Insert()
        {
            /// Implementation for ADDING to DATABASE
        }

        public void Delete()
        {
            /// Implementation for DELETING to DATABASE
        }
    }
}
