using BussinessObject;
using DataAccessLayer;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        private CustomerDAO customerDAO;

        public CustomerRepository()
        {
            customerDAO = new CustomerDAO();
            customerDAO.Initialize();
        }

        public int AddCustomer(Customer customer)
        {
            return customerDAO.AddCustomer(customer);
        }

        public bool DeleteCustomer(int customerID)
        {
            return customerDAO.DeleteCustomer(customerID);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerDAO.GetAllCustomers();
        }

        public Customer? GetCustomerByID(int customerID)
        {
            return customerDAO.GetCustomerByID(customerID);
        }

        public bool UpdateCustomer(Customer customer)
        {
            return customerDAO.UpdateCustomer(customer);
        }

        public Customer GetCustomerAccount(string phone)
        {
            return customerDAO.getCustomerAccount(phone);
        }

        public List<Customer> GetCustomersByName(string name)
        {
            return customerDAO.GetCustomersByName(name);
        }
    }
}
