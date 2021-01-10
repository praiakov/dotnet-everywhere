using System;

namespace DIP
{
    public sealed class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public sealed class CustomerRepository
    {
        public CustomerRepository(string connectionString)
        {
            /// Implementation
        }

        public void Add(Customer customer)
        {
            /// Implementation
        }
    }

    public sealed class CustomerService
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository("ConnectionString");

        public void Add(Customer customer)
        {
            _customerRepository.Add(customer);
        }
    }
}
