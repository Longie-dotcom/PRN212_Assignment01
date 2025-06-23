using DTOs;

namespace Services.Interface
{
    public interface IStatisticsService
    {
        public List<OrderStatisticsDTO> GetStatisticsByDateRange(DateTime from, DateTime to);
    }
}
