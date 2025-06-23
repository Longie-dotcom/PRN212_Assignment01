using BussinessObject;

namespace Services.Interface
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order? GetOrderByID(int orderId);
        int AddOrder(Order order);
        bool DeleteOrder(int orderId);
        bool UpdateOrder(Order order);
    }
}
