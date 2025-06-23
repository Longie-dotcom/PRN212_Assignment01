using Services.Interface;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DTOs;

namespace DongXuanBaoLongWPF.ViewModels
{
    public class CustomerOrderHistoryViewModel : INotifyPropertyChanged
    {
        private readonly IOrderViewService _orderService;
        private OrderDetailDTO selectedOrder;

        public ObservableCollection<OrderDetailDTO> Orders { get; set; }

        public OrderDetailDTO SelectedOrder
        {
            get { return selectedOrder; }
            set {
                selectedOrder = value; 
                OnPropertyChanged(nameof(SelectedOrder));
                OnPropertyChanged(nameof(Items));
            }
        }

        public ObservableCollection<OrderDetailItemDTO> Items =>
            new(selectedOrder?.Items ?? new List<OrderDetailItemDTO>());

        public CustomerOrderHistoryViewModel(int customerId, IOrderViewService orderService)
        {
            _orderService = orderService;
            var list = _orderService.GetAllOrderDetailsByCustomerId(customerId);
            Orders = new ObservableCollection<OrderDetailDTO>(list);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
