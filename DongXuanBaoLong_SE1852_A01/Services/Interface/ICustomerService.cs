using BussinessObject;

namespace Services.Interface
{
    public interface ICustomerService
    {
        Customer? Login(string phone);
        List<Customer> GetAllCustomers();
        Customer? GetCustomerByID(int customerID);
        int AddCustomer(Customer customer);
        bool DeleteCustomer(int customerID);
        bool UpdateCustomer(Customer customer);
        List<Customer> SearchCustomersByName(string name);
    }
}
