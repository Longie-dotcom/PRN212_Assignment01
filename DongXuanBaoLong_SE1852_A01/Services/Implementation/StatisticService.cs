using DTOs;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderDetailRepository orderDetailRepository;

        public StatisticsService(IOrderRepository orderRepo, IOrderDetailRepository detailRepo)
        {
            orderRepository = orderRepo;
            orderDetailRepository = detailRepo;
        }

        public List<OrderStatisticsDTO> GetStatisticsByDateRange(DateTime from, DateTime to)
        {
            // Filter order by date
            var orders = orderRepository.GetAllOrders().Where(order => order.OrderDate >= from && order.OrderDate <= to);

            // Fetch all order detail
            var orderDetails = orderDetailRepository.GetAllOrderDetails();

            var query = from order in orders
                            // Populate the order detail
                        join orderDetail in orderDetails on order.OrderID equals orderDetail.OrderID
                        // Count the total price, formular: TotalPrice = unitPrice * quanity * (1 - discount)
                        group new { order, orderDetail } by order.OrderDate.Date into g
                        let totalPrice = g.Sum(order => (double)order.orderDetail.UnitPrice * order.orderDetail.Quantity * (1 - order.orderDetail.Discount))
                        select new OrderStatisticsDTO()
                        {
                            Period = g.Key,
                            TotalOrders = orderDetails.Count,
                            TotalRevenue = totalPrice
                        };

            return query.OrderByDescending(order => order.Period).ToList();
        }
    }

}
