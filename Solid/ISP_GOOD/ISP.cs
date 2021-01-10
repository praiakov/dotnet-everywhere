using System;

namespace ISP_GOOD
{
    public interface IBase
    {
        void ChangeId(int id);
    }

    public interface ICustomer : IBase
    {
        void ChangeAddress(string address);
    }

    public interface IProduct : IBase
    {
        void ChangePrice(decimal price);
    }

    public sealed class Customer : ICustomer
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
    }

    public sealed class Product : IProduct
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
    }
}
