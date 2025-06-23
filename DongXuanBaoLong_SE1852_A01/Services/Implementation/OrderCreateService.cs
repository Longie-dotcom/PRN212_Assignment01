using BussinessObject;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class OrderCreateService : IOrderCreateService
    {
        IOrderDetailRepository orderDetailRepository;
        IOrderRepository orderRepository;
        public OrderCreateService(
            IOrderRepository orderRepository, 
            IOrderDetailRepository orderDetailRepository)
        {
            this.orderRepository = orderRepository;
            this.orderDetailRepository = orderDetailRepository;
        }

        public void CreateOrder(Order order, OrderDetail orderDetail)
        {
            int orderId = orderRepository.AddOrder(order);

            orderDetail.OrderID = orderId;

            orderDetailRepository.AddOrderDetail(orderDetail);
        }
    }
}
