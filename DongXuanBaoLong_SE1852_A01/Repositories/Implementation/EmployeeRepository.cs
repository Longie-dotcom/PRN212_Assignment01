using BussinessObject;
using DataAccessLayer;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDAO employeeDAO;

        public EmployeeRepository()
        {
            employeeDAO = new EmployeeDAO();
            employeeDAO.Initialize();
        }

        public int AddEmployee(Employee employee)
        {
            return employeeDAO.AddEmployee(employee);
        }

        public bool DeleteEmployee(int employeeId)
        {
            return employeeDAO.DeleteEmployee(employeeId);
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAO.GetAllEmployees();
        }

        public Employee? GetEmployeeByID(int employeeId)
        {
            return employeeDAO.GetEmployeeByID(employeeId);
        }

        public bool UpdateEmployee(Employee employee)
        {
            return employeeDAO.UpdateEmployee(employee);
        }
        public Employee GetEmployeeAccount(string userName, string password)
        {
            return employeeDAO.getEmployeeAccount(userName, password);
        }
    }
}
