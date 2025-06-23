using BussinessObject;
using DataAccessLayer;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private OrderDetailDAO orderDetailDAO;

        public OrderDetailRepository()
        {
            orderDetailDAO = new OrderDetailDAO();
            orderDetailDAO.Initialize();
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            orderDetailDAO.AddOrderDetail(orderDetail);
        }

        public bool DeleteOrderDetail(int orderID, int productID)
        {
            return orderDetailDAO.DeleteOrderDetail(orderID, productID);
        }

        public List<OrderDetail> GetAllOrderDetails()
        {
            return orderDetailDAO.GetAllOrderDetails();
        }

        public OrderDetail? GetOrderDetailByID(int orderID, int productID)
        {
            return orderDetailDAO.GetOrderDetailByID(orderID, productID);
        }

        public List<OrderDetail> GetOrderDetailsByOrderID(int orderID)
        {
            return orderDetailDAO.GetOrderDetailByOrderID(orderID);
        }

        public bool UpdateOrderDetail(OrderDetail orderDetail)
        {
            return orderDetailDAO.UpdateOrderDetail(orderDetail);
        }
    }
}
