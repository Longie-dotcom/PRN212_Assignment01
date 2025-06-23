namespace DTOs
{
    public class OrderStatisticsDTO
    {
        public DateTime Period { get; set; }
        public int TotalOrders { get; set; }
        public double TotalRevenue { get; set; }
    }
}
