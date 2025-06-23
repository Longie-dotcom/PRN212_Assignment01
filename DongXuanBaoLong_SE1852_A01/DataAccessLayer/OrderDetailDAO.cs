using BussinessObject;
using Helper;

namespace DataAccessLayer
{
    public class OrderDetailDAO
    {
        private static List<OrderDetail> orderDetails = new List<OrderDetail>();
        private static bool isInitialized = false;

        public OrderDetailDAO() { }

        public void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            orderDetails = new List<OrderDetail>
            {
                new OrderDetail { OrderID = 1, ProductID = 1, UnitPrice = 18.00, Quantity = 10, Discount = 0 },
                new OrderDetail { OrderID = 1, ProductID = 2, UnitPrice = 19.00, Quantity = 5, Discount = 0.1f },

                new OrderDetail { OrderID = 2, ProductID = 3, UnitPrice = 10.00, Quantity = 8, Discount = 0 },

                new OrderDetail { OrderID = 3, ProductID = 4, UnitPrice = 22.00, Quantity = 6, Discount = 0.05f },

                new OrderDetail { OrderID = 4, ProductID = 5, UnitPrice = 21.35, Quantity = 4, Discount = 0 },
                new OrderDetail { OrderID = 4, ProductID = 6, UnitPrice = 25.00, Quantity = 3, Discount = 0.2f },

                new OrderDetail { OrderID = 5, ProductID = 7, UnitPrice = 30.00, Quantity = 2, Discount = 0 },

                new OrderDetail { OrderID = 6, ProductID = 8, UnitPrice = 40.00, Quantity = 5, Discount = 0 },
                new OrderDetail { OrderID = 6, ProductID = 9, UnitPrice = 97.00, Quantity = 1, Discount = 0.3f },

                new OrderDetail { OrderID = 7, ProductID = 10, UnitPrice = 31.00, Quantity = 6, Discount = 0 },

                new OrderDetail { OrderID = 8, ProductID = 11, UnitPrice = 21.00, Quantity = 7, Discount = 0.15f },

                new OrderDetail { OrderID = 9, ProductID = 12, UnitPrice = 38.00, Quantity = 3, Discount = 0 },
                new OrderDetail { OrderID = 9, ProductID = 13, UnitPrice = 6.00, Quantity = 10, Discount = 0.05f },

                new OrderDetail { OrderID = 10, ProductID = 14, UnitPrice = 23.25, Quantity = 4, Discount = 0 },
                new OrderDetail { OrderID = 10, ProductID = 15, UnitPrice = 15.50, Quantity = 8, Discount = 0.1f },
            };

            isInitialized = true;
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            // Check if the data is null
            if (orderDetail != null)
            {
                // Add the new order detail into list
                orderDetails.Add(orderDetail);
            }
        }

        public bool DeleteOrderDetail(int orderID, int productID)
        {
            // Get the order detail
            OrderDetail orderDetail =
                orderDetails.FirstOrDefault(orderDetail => orderDetail.OrderID == orderID && orderDetail.ProductID == productID);

            // Check if the order detail is found
            if (orderDetail == null)
            {
                return false;
            }

            // Remove the order detail from the list
            orderDetails.Remove(orderDetail);

            return true;
        }

        public List<OrderDetail> GetAllOrderDetails()
        {
            return orderDetails;
        }

        public OrderDetail GetOrderDetailByID(int orderID, int productID)
        {
            return orderDetails.FirstOrDefault(orderDetail => orderDetail.OrderID == orderID && orderDetail.ProductID == productID);
        }

        public bool UpdateOrderDetail(OrderDetail newOrderDetail)
        {
            // Get the old order detail
            OrderDetail orderDetail =
                orderDetails.FirstOrDefault(orderDetail => orderDetail.OrderID == newOrderDetail.OrderID && orderDetail.ProductID == newOrderDetail.ProductID);

            // Check if the order detail is found
            if (orderDetail == null)
            {
                return false;
            }

            // Update the old order detail
            orderDetail.Discount = newOrderDetail.Discount;
            orderDetail.Quantity = newOrderDetail.Quantity;
            orderDetail.UnitPrice = newOrderDetail.UnitPrice;

            return true;
        }

        public List<OrderDetail> GetOrderDetailByOrderID(int orderID)
        {
            return orderDetails.Where(orderDetail => orderDetail.OrderID == orderID).ToList();
        }
    }
}
