using System.ComponentModel;

namespace DTOs
{
    public class OrderDetailItemDTO : INotifyPropertyChanged
    {
        private int productID;
        private string productName;
        private int quantity;
        private double unitPrice;
        private float discount;

        public int ProductID
        {
            get => productID;
            set
            {
                if (productID != value)
                {
                    productID = value;
                    OnPropertyChanged(nameof(ProductID));
                }
            }
        }

        public string ProductName
        {
            get => productName;
            set
            {
                if (productName != value)
                {
                    productName = value;
                    OnPropertyChanged(nameof(ProductName));
                }
            }
        }

        public int Quantity
        {
            get => quantity;
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                }
            }
        }

        public double UnitPrice
        {
            get => unitPrice;
            set
            {
                if (unitPrice != value)
                {
                    unitPrice = value;
                    OnPropertyChanged(nameof(UnitPrice));
                }
            }
        }

        public float Discount
        {
            get => discount;
            set
            {
                if (discount != value)
                {
                    discount = value;
                    OnPropertyChanged(nameof(Discount));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}