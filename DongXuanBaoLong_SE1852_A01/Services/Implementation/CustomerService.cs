using BussinessObject;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public int AddCustomer(Customer customer)
        {
            return customerRepository.AddCustomer(customer);
        }

        public bool DeleteCustomer(int customerID)
        {
            return customerRepository.DeleteCustomer(customerID);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerRepository.GetAllCustomers();
        }

        public Customer? GetCustomerByID(int customerID)
        {
            return customerRepository.GetCustomerByID(customerID);
        }

        public Customer? Login(string phone)
        {
            return customerRepository.GetCustomerAccount(phone);
        }

        public bool UpdateCustomer(Customer customer)
        {
            return customerRepository.UpdateCustomer(customer);
        }
        public List<Customer> SearchCustomersByName(string name)
        {
            return customerRepository.GetCustomersByName(name);
        }
    }
}
