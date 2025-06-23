using DTOs;

namespace Services.Interface
{
    public interface IOrderViewService
    {
        OrderDetailDTO? GetOrderDetailByID(int orderId);
        List<OrderDetailDTO> GetAllOrderDetails();
        List<OrderDetailDTO> GetAllOrderDetailsByCustomerId(int customerId);
    }
}
