using BussinessObject;

namespace Repositories.Interface
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetAllOrderDetails();
        OrderDetail? GetOrderDetailByID(int orderID, int productID);
        void AddOrderDetail(OrderDetail orderDetail);
        bool DeleteOrderDetail(int orderID, int productID);
        bool UpdateOrderDetail(OrderDetail orderDetail);
        List<OrderDetail> GetOrderDetailsByOrderID(int orderID);
    }
}
