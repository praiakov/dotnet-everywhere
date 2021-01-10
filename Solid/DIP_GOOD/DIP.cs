using System;

namespace DIP_GOOD
{
    public sealed class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public interface ICustomerRepository
    {
        void Add(Customer customer);
    }

    public sealed class CustomerRepository : ICustomerRepository
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
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Add(Customer customer)
        {
            _customerRepository.Add(customer);
        }
    }
}
