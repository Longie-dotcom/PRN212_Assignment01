using BussinessObject;
using Helper;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        private static List<Customer> customers = new List<Customer>();
        private static bool isInitialized = false;

        public CustomerDAO() { }

        public void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            customers = new List<Customer>
            {
                new Customer { CustomerID = 1, CompanyName = "Alfreds Futterkiste", ContactName = "Maria Anders", ContactTitle = "Sales Representative", Address = "Obere Str. 57", Phone = "030-0074321" },
                new Customer { CustomerID = 2, CompanyName = "Ana Trujillo Emparedados y helados", ContactName = "Ana Trujillo", ContactTitle = "Owner", Address = "Avda. de la Constitución 2222", Phone = "(5) 555-4729" },
                new Customer { CustomerID = 3, CompanyName = "Antonio Moreno Taquería", ContactName = "Antonio Moreno", ContactTitle = "Owner", Address = "Mataderos  2312", Phone = "(5) 555-3932" },
                new Customer { CustomerID = 4, CompanyName = "Around the Horn", ContactName = "Thomas Hardy", ContactTitle = "Sales Representative", Address = "120 Hanover Sq.", Phone = "(171) 555-7788" },
                new Customer { CustomerID = 5, CompanyName = "Berglunds snabbköp", ContactName = "Christina Berglund", ContactTitle = "Order Administrator", Address = "Berguvsvägen  8", Phone = "0921-12 34 65" },
                new Customer { CustomerID = 6, CompanyName = "Blauer See Delikatessen", ContactName = "Hanna Moos", ContactTitle = "Sales Representative", Address = "Forsterstr. 57", Phone = "0621-08460" },
                new Customer { CustomerID = 7, CompanyName = "Blondesddsl père et fils", ContactName = "Frédérique Citeaux", ContactTitle = "Marketing Manager", Address = "24, place Kléber", Phone = "88.60.15.31" },
                new Customer { CustomerID = 8, CompanyName = "Bólido Comidas preparadas", ContactName = "Martín Sommer", ContactTitle = "Owner", Address = "C/ Araquil, 67", Phone = "(91) 555 22 82" },
                new Customer { CustomerID = 9, CompanyName = "Bon app'", ContactName = "Laurence Lebihan", ContactTitle = "Owner", Address = "12, rue des Bouchers", Phone = "91.24.45.40" },
                new Customer { CustomerID = 10, CompanyName = "Bottom-Dollar Markets", ContactName = "Elizabeth Lincoln", ContactTitle = "Accounting Manager", Address = "23 Tsawassen Blvd.", Phone = "(604) 555-4729" },
            };

            isInitialized = true;
        }

        public int AddCustomer(Customer customer)
        {
            // Check if the data is null
            if (customer != null)
            {
                // Generate the ID and apply the ID
                customer.CustomerID = IDGenerator.IDGenerate(customers, customer => customer.CustomerID);
                
                // Add the new customer into list
                customers.Add(customer);

                // Return the generated ID
                return customer.CustomerID;
            }

            return -1;
        }

        public bool DeleteCustomer(int customerID)
        {
            // Get the customer
            Customer customer = 
                customers.FirstOrDefault(customer => customer.CustomerID == customerID);
            
            // Check if the customer is found
            if (customer == null)
            {
                return false;
            }

            // Remove the customer from the list
            customers.Remove(customer);

            return true;
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        public Customer GetCustomerByID(int customerID)
        {
            return customers.FirstOrDefault(customer => customer.CustomerID == customerID);
        }

        public bool UpdateCustomer(Customer newCustomer)
        {
            // Get the old customer
            Customer customer = 
                customers.FirstOrDefault(customer => customer.CustomerID == newCustomer.CustomerID);

            // Check if the customer is found
            if (customer == null)
            {
                return false;
            }

            // Update the old customer
            customer.ContactName = newCustomer.ContactName ?? customer.ContactName;
            customer.ContactTitle = newCustomer.ContactTitle ?? customer.ContactTitle;
            customer.Address = newCustomer.Address ?? customer.Address;
            customer.Phone = newCustomer.Phone ?? customer.Phone;
            customer.CompanyName = newCustomer.CompanyName ?? customer.CompanyName;

            return true;
        }

        public Customer getCustomerAccount(string phone)
        {
            return customers.FirstOrDefault(customer => customer.Phone == phone);
        }

        public List<Customer> GetCustomersByName(string name)
        {
            return customers.FindAll(customer => customer.ContactName.Contains(name));
        }
    }
}
