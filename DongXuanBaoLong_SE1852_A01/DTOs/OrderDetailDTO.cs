using System.ComponentModel;

namespace DTOs
{
    public class OrderDetailDTO : INotifyPropertyChanged
    {
        private int orderID;
        private string customerName;
        private string employeeName;
        private DateTime orderDate;
        private List<OrderDetailItemDTO> items = new();

        public int OrderID
        {
            get => orderID;
            set
            {
                if (orderID != value)
                {
                    orderID = value;
                    OnPropertyChanged(nameof(OrderID));
                }
            }
        }

        public string CustomerName
        {
            get => customerName;
            set
            {
                if (customerName != value)
                {
                    customerName = value;
                    OnPropertyChanged(nameof(CustomerName));
                }
            }
        }

        public string EmployeeName
        {
            get => employeeName;
            set
            {
                if (employeeName != value)
                {
                    employeeName = value;
                    OnPropertyChanged(nameof(EmployeeName));
                }
            }
        }

        public DateTime OrderDate
        {
            get => orderDate;
            set
            {
                if (orderDate != value)
                {
                    orderDate = value;
                    OnPropertyChanged(nameof(OrderDate));
                }
            }
        }

        public List<OrderDetailItemDTO> Items
        {
            get => items;
            set
            {
                if (items != value)
                {
                    items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
