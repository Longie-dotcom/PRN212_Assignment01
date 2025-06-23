using Repositories.Interface;
using Services.Interface;
using DTOs;

namespace Services.Implementation
{
    public class OrderViewService : IOrderViewService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderDetailRepository orderDetailRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IProductRepository productRepository;

        public OrderViewService(
            IOrderRepository orderRepository, 
            IOrderDetailRepository orderDetailRepository,
            ICustomerRepository customerRepository,
            IEmployeeRepository employeeRepository,
            IProductRepository productRepository)
        {
            this.orderRepository = orderRepository;
            this.orderDetailRepository = orderDetailRepository;
            this.customerRepository = customerRepository;
            this.employeeRepository = employeeRepository;
            this.productRepository = productRepository;
        }

        public OrderDetailDTO? GetOrderDetailByID(int orderId)
        {
            var order = orderRepository.GetOrderByID(orderId);
            if (order == null)
            {
                return null;
            }

            var customer = customerRepository.GetCustomerByID(order.CustomerID);
            var employee = employeeRepository.GetEmployeeByID(order.EmployeeID);
            var orderDetail = orderDetailRepository.GetOrderDetailsByOrderID(orderId);

            var items = new List<OrderDetailItemDTO>();
            foreach (var item in orderDetail)
            {
                var product = productRepository.GetProductByID(item.ProductID);

                items.Add(new OrderDetailItemDTO()
                {
                    ProductID = item.ProductID,
                    ProductName = product?.ProductName ?? "Unknown",
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Discount = item.Discount
                });
            }

            OrderDetailDTO orderDetailDTO = new OrderDetailDTO()
            {
                OrderID = orderId,
                CustomerName = customer?.ContactName ?? "Unknown",
                EmployeeName = employee?.Name ?? "Unknown",
                Items = items,
                OrderDate = order.OrderDate
            };

            return orderDetailDTO; 
        }

        public List<OrderDetailDTO> GetAllOrderDetails()
        {
            var orders = orderRepository.GetAllOrders();

            List<OrderDetailDTO> list = new List<OrderDetailDTO>();
            foreach (var order in orders)
            {
                var employee = employeeRepository.GetEmployeeByID(order.EmployeeID);
                var customer = customerRepository.GetCustomerByID(order.CustomerID);
                var orderDetails = orderDetailRepository.GetOrderDetailsByOrderID(order.OrderID);

                List<OrderDetailItemDTO> items = new List<OrderDetailItemDTO>();
                foreach (var item in orderDetails)
                {
                    var product = productRepository.GetProductByID(item.ProductID);

                    items.Add(new OrderDetailItemDTO()
                    {
                        Discount = item.Discount,
                        ProductID = item.ProductID,
                        ProductName = product?.ProductName ?? "Unknown",
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice
                    });
                }
                list.Add(new OrderDetailDTO()
                {
                    OrderID = order.OrderID,
                    OrderDate = order.OrderDate,
                    CustomerName = customer?.ContactName ?? "Unknown",
                    EmployeeName = employee?.Name ?? "Unknown",
                    Items = items
                });
            }

            return list;
        }

        public List<OrderDetailDTO> GetAllOrderDetailsByCustomerId(int customerId)
        {
            var orders = orderRepository.GetAllOrders().Where(o => o.CustomerID == customerId);
            var orderDetails = orderDetailRepository.GetAllOrderDetails();
            var customer = customerRepository.GetAllCustomers().FirstOrDefault(c => c.CustomerID == customerId);
            var employees = employeeRepository.GetAllEmployees();
            var products = productRepository.GetAllProducts();

            var query = from order in orders
                        join employee in employees on order.EmployeeID equals employee.EmployeeID
                        join detail in orderDetails on order.OrderID equals detail.OrderID
                        join product in products on detail.ProductID equals product.ProductID
                        group new { order, employee, detail, product } by new
                        {
                            order.OrderID,
                            order.OrderDate,
                            EmployeeName = employee.Name,
                            CustomerName = customer?.ContactName ?? "Unknown"
                        } into g
                        select new OrderDetailDTO
                        {
                            OrderID = g.Key.OrderID,
                            OrderDate = g.Key.OrderDate,
                            EmployeeName = g.Key.EmployeeName,
                            CustomerName = g.Key.CustomerName,
                            Items = g.Select(x => new OrderDetailItemDTO
                            {
                                ProductID = x.detail.ProductID,
                                ProductName = x.product.ProductName,
                                Quantity = x.detail.Quantity,
                                UnitPrice = x.detail.UnitPrice,
                                Discount = x.detail.Discount
                            }).ToList()
                        };

            return query.ToList();
        }
    }
}
