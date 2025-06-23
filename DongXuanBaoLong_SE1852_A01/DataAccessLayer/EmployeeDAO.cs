using BussinessObject;
using Helper;

namespace DataAccessLayer
{
    public class EmployeeDAO
    {
        private static List<Employee> employees = new List<Employee>();
        private static bool isInitialized = false;

        public EmployeeDAO() { }

        public void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            employees = new List<Employee>
            {
                new Employee
                {
                    EmployeeID = 1,
                    Name = "Davolio",
                    UserName = "Nancy",
                    Password = "123",
                    JobTitle = "Sales Representative",
                    BirthDate = new DateTime(1948, 12, 8),
                    HireDate = new DateTime(1992, 5, 1),
                    Address = "507 - 20th Ave. E.Apt. 2A"
                },
                new Employee
                {
                    EmployeeID = 2,
                    Name = "Fuller",
                    UserName = "Andrew",
                    Password = "456",
                    JobTitle = "Vice President, Sales",
                    BirthDate = new DateTime(1952, 2, 19),
                    HireDate = new DateTime(1992, 8, 14),
                    Address = "908 W. Capital Way"
                },
                new Employee
                {
                    EmployeeID = 3,
                    Name = "Leverling",
                    UserName = "Janet",
                    Password = "789",
                    JobTitle = "Sales Representative",
                    BirthDate = new DateTime(1963, 8, 30),
                    HireDate = new DateTime(1992, 4, 1),
                    Address = "722 Moss Bay Blvd."
                },
                new Employee
                {
                    EmployeeID = 4,
                    Name = "Peacock",
                    UserName = "Margaret",
                    Password = "321",
                    JobTitle = "Sales Representative",
                    BirthDate = new DateTime(1937, 9, 19),
                    HireDate = new DateTime(1993, 5, 3),
                    Address = "4110 Old Redmond Rd."
                },
                new Employee
                {
                    EmployeeID = 5,
                    Name = "Buchanan",
                    UserName = "Steven",
                    Password = "654",
                    JobTitle = "Sales Manager",
                    BirthDate = new DateTime(1955, 3, 4),
                    HireDate = new DateTime(1993, 10, 17),
                    Address = "14 Garrett Hill"
                },
                new Employee
                {
                    EmployeeID = 6,
                    Name = "Suyama",
                    UserName = "Michael",
                    Password = "987",
                    JobTitle = "Sales Representative",
                    BirthDate = new DateTime(1963, 7, 2),
                    HireDate = new DateTime(1993, 10, 17),
                    Address = "Coventry House\nMiner Rd."
                }
            };

            isInitialized = true;
        }

        public int AddEmployee(Employee employee)
        {
            // Check if the data is null
            if (employee != null)
            {
                // Generate the ID and apply the ID
                employee.EmployeeID = IDGenerator.IDGenerate(employees, employee => employee.EmployeeID);

                // Add the new employee into list
                employees.Add(employee);

                // Return the generated ID
                return employee.EmployeeID;
            }

            return -1;
        }

        public bool DeleteEmployee(int employeeID)
        {
            // Get the employee
            Employee employee =
                employees.FirstOrDefault(employee => employee.EmployeeID == employeeID);

            // Check if the employee is found
            if (employee == null)
            {
                return false;
            }

            // Remove the employee from the list
            employees.Remove(employee);

            return true;
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeByID(int employeeID)
        {
            return employees.FirstOrDefault(employee => employee.EmployeeID == employeeID);
        }

        public bool UpdateEmployee(Employee newEmployee)
        {
            // Get the old employee
            Employee employee =
                employees.FirstOrDefault(employee => employee.EmployeeID == newEmployee.EmployeeID);

            // Check if the employee is found
            if (employee == null)
            {
                return false;
            }

            // Update the old employee
            employee.Name = newEmployee.Name ?? employee.Name;
            employee.UserName = newEmployee.UserName ?? employee.UserName;
            employee.Address = newEmployee.Address ?? employee.Address;
            employee.BirthDate = newEmployee.BirthDate ?? employee.BirthDate;
            employee.HireDate = newEmployee.HireDate ?? employee.HireDate;
            employee.Password = newEmployee.Password ?? employee.Password;
            employee.JobTitle = newEmployee.JobTitle ?? employee.JobTitle;

            return true;
        }

        public Employee getEmployeeAccount(string userName, string password)
        {
            return employees.FirstOrDefault(employee => employee.UserName == userName && employee.Password == password);
        }
    }
}
