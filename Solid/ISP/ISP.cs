namespace ISP
{
    public interface IBase
    {
        void ChangeId(int id);

        void ChangeAddress(string address);

        void ChangePrice(decimal price);
    }
    public sealed class Customer : IBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public void ChangeId(int id)
        {
            Id = id;
        }

        public void ChangeAddress(string address)
        {
            Address = address;
        }

        public void ChangePrice(decimal price)
        {
            throw new NotImplementedException();
        }
    }

    public sealed class Product : IBase
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public void ChangeId(int id)
        {
            Id = id;
        }

        public void ChangePrice(decimal price)
        {
            Price = price;
        }

        public void ChangeAddress(string address)
        {
            throw new NotImplementedException();
        }
    }
}
