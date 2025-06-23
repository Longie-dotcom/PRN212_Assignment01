using System.Collections.ObjectModel;
using System.ComponentModel;
using DTOs;
using Services.Interface;
using Services.Implementation;
using Repositories.Implementation;

namespace DongXuanBaoLongWPF.ViewModels
{
    public class StatisticsViewModel : INotifyPropertyChanged
    {
        private readonly IStatisticsService statisticsService;

        public ObservableCollection<OrderStatisticsDTO> Statistics { get; set; } = new();

        private DateTime fromDate = DateTime.Today.AddMonths(-1);
        private DateTime toDate = DateTime.Today;

        public DateTime FromDate
        {
            get => fromDate;
            set
            {
                fromDate = value;
                OnPropertyChanged(nameof(FromDate));
            }
        }

        public DateTime ToDate
        {
            get => toDate;
            set
            {
                toDate = value;
                OnPropertyChanged(nameof(ToDate));
            }
        }

        public StatisticsViewModel()
        {
            statisticsService = new StatisticsService(
                new OrderRepository(),
                new OrderDetailRepository()
            );

            LoadStatistics();
        }

        public void LoadStatistics()
        {
            var result = statisticsService.GetStatisticsByDateRange(FromDate, ToDate);
            Statistics.Clear();
            foreach (var stat in result)
                Statistics.Add(stat);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
