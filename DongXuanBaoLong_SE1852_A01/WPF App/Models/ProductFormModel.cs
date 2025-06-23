using System.ComponentModel;

namespace WPF_App.Models
{
    public class ProductFormModel : INotifyPropertyChanged
    {
        private string productName;
        private int? supplierID;
        private int? categoryID;
        private string quantityPerUnit;
        private double? unitPrice;
        private int? unitsInStock;
        private int? unitsOnOrder;
        private int? reorderLevel;
        private bool? discontinued;

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

        public int? SupplierID
        {
            get => supplierID;
            set
            {
                if (supplierID != value)
                {
                    supplierID = value;
                    OnPropertyChanged(nameof(SupplierID));
                }
            }
        }

        public int? CategoryID
        {
            get => categoryID;
            set
            {
                if (categoryID != value)
                {
                    categoryID = value;
                    OnPropertyChanged(nameof(CategoryID));
                }
            }
        }

        public string QuantityPerUnit
        {
            get => quantityPerUnit;
            set
            {
                if (quantityPerUnit != value)
                {
                    quantityPerUnit = value;
                    OnPropertyChanged(nameof(QuantityPerUnit));
                }
            }
        }

        public double? UnitPrice
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

        public int? UnitsInStock
        {
            get => unitsInStock;
            set
            {
                if (unitsInStock != value)
                {
                    unitsInStock = value;
                    OnPropertyChanged(nameof(UnitsInStock));
                }
            }
        }

        public int? UnitsOnOrder
        {
            get => unitsOnOrder;
            set
            {
                if (unitsOnOrder != value)
                {
                    unitsOnOrder = value;
                    OnPropertyChanged(nameof(UnitsOnOrder));
                }
            }
        }

        public int? ReorderLevel
        {
            get => reorderLevel;
            set
            {
                if (reorderLevel != value)
                {
                    reorderLevel = value;
                    OnPropertyChanged(nameof(ReorderLevel));
                }
            }
        }

        public bool? Discontinued
        {
            get => discontinued;
            set
            {
                if (discontinued != value)
                {
                    discontinued = value;
                    OnPropertyChanged(nameof(Discontinued));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
