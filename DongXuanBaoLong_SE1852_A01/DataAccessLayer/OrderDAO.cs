using BussinessObject;
using Helper;

namespace DataAccessLayer
{
    public class OrderDAO
    {
        private static List<Order> orders = new List<Order>();
        private static bool isInitialized = false;

        public OrderDAO() { }

        public void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            orders = new List<Order>
            {
                new Order { OrderID = 1, CustomerID = 1, EmployeeID = 1, OrderDate = new DateTime(2024, 1, 10) },
                new Order { OrderID = 2, CustomerID = 2, EmployeeID = 3, OrderDate = new DateTime(2024, 2, 15) },
                new Order { OrderID = 3, CustomerID = 3, EmployeeID = 2, OrderDate = new DateTime(2024, 3, 20) },
                new Order { OrderID = 4, CustomerID = 4, EmployeeID = 4, OrderDate = new DateTime(2024, 4, 5) },
                new Order { OrderID = 5, CustomerID = 5, EmployeeID = 5, OrderDate = new DateTime(2024, 5, 12) },
                new Order { OrderID = 6, CustomerID = 6, EmployeeID = 6, OrderDate = new DateTime(2024, 6, 8) },
                new Order { OrderID = 7, CustomerID = 7, EmployeeID = 1, OrderDate = new DateTime(2024, 7, 1) },
                new Order { OrderID = 8, CustomerID = 8, EmployeeID = 2, OrderDate = new DateTime(2024, 7, 15) },
                new Order { OrderID = 9, CustomerID = 9, EmployeeID = 3, OrderDate = new DateTime(2024, 8, 10) },
                new Order { OrderID = 10, CustomerID = 10, EmployeeID = 4, OrderDate = new DateTime(2024, 9, 5) }
            };

            isInitialized = true;
        }

        public int AddOrder(Order order)
        {
            // Check if the data is null
            if (order != null)
            {
                // Generate the ID and apply the ID
                order.OrderID = IDGenerator.IDGenerate(orders, order => order.OrderID);

                // Add the new order into list
                orders.Add(order);

                // Return the generated ID
                return order.OrderID;
            }

            return -1;
        }

        public bool DeleteOrder(int orderID)
        {
            // Get the order ID
            Order order =
                orders.FirstOrDefault(order => order.OrderID == orderID);

            // Check if the order is found
            if (order == null)
            {
                return false;
            }

            // Remove the order from the list
            orders.Remove(order);

            return true;
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }

        public Order GetOrderByID(int orderID)
        {
            return orders.FirstOrDefault(order => order.OrderID == orderID);
        }

        public bool UpdateOrder(Order newOrder)
        {
            // Get the old order
            Order order =
                orders.FirstOrDefault(order => order.OrderID == newOrder.OrderID);

            // Check if the order is found
            if (order == null)
            {
                return false;
            }

            // Update the old order
            order.CustomerID = newOrder.CustomerID;
            order.EmployeeID = newOrder.EmployeeID;
            order.OrderDate = newOrder.OrderDate;

            return true;
        }
    }
}
