using BussinessObject;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Employee Login(string username, string password)
        {
            return employeeRepository.GetEmployeeAccount(username, password);
        }
    }
}
