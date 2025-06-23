using BussinessObject;
using DataAccessLayer;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private OrderDAO orderDAO;

        public OrderRepository()
        {
            orderDAO = new OrderDAO();
            orderDAO.Initialize();
        }

        public int AddOrder(Order order)
        {
            return orderDAO.AddOrder(order);
        }

        public bool DeleteOrder(int orderId)
        {
            return orderDAO.DeleteOrder(orderId);
        }

        public List<Order> GetAllOrders()
        {
            return orderDAO.GetAllOrders();
        }

        public Order? GetOrderByID(int orderId)
        {
            return orderDAO.GetOrderByID(orderId);
        }

        public bool UpdateOrder(Order order)
        {
            return orderDAO.UpdateOrder(order);
        }
    }
}
