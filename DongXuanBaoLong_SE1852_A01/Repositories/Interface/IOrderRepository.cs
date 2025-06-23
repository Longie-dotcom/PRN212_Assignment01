using BussinessObject;

namespace Repositories.Interface
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        Order? GetOrderByID(int orderId);
        int AddOrder(Order order);
        bool DeleteOrder(int orderId);
        bool UpdateOrder(Order order);
    }
}
