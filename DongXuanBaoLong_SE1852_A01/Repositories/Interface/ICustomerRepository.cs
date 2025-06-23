using BussinessObject;

namespace Repositories.Interface
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        Customer? GetCustomerByID(int customerID);
        int AddCustomer(Customer customer);
        bool DeleteCustomer(int customerID);
        bool UpdateCustomer(Customer customer);
        Customer GetCustomerAccount(string phone);
        List<Customer> GetCustomersByName(string name);
    }
}
