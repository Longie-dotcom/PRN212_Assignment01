using BussinessObject;

namespace Repositories.Interface
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee? GetEmployeeByID(int employeeId);
        int AddEmployee(Employee employee);
        bool DeleteEmployee(int employeeId);
        bool UpdateEmployee(Employee employee);
        Employee GetEmployeeAccount(string userName, string password);
    }
}
