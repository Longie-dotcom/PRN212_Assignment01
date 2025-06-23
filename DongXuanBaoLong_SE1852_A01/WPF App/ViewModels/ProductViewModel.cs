using BussinessObject;
using Services.Interface;
using Services.Implementation;
using Repositories.Implementation;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DongXuanBaoLongWPF.Models;

namespace DongXuanBaoLongWPF.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        private readonly IProductService productService;

        public ProductFormModel Input { get; set; } = new ProductFormModel();

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get => products;
            set
            {
                products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

        private Product selectedProduct;
        public Product SelectedProduct
        {
            get => selectedProduct;
            set
            {
                selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));

                // Optionally update input fields when selection changes
                if (value != null)
                {
                    Input.ProductName = value.ProductName;
                    Input.SupplierID = value.SupplierID;
                    Input.CategoryID = value.CategoryID;
                    Input.QuantityPerUnit = value.QuantityPerUnit;
                    Input.UnitPrice = value.UnitPrice;
                    Input.UnitsInStock = value.UnitsInStock;
                    Input.UnitsOnOrder = value.UnitsOnOrder;
                    Input.ReorderLevel = value.ReorderLevel;
                    Input.Discontinued = value.Discontinued;
                }
            }
        }

        public ProductViewModel()
        {
            productService = new ProductService(new ProductRepository());
            Products = new ObservableCollection<Product>(productService.GetAllProducts());
        }

        public void AddProduct()
        {
            var newProduct = new Product
            {
                ProductName = Input.ProductName,
                SupplierID = Input.SupplierID,
                CategoryID = Input.CategoryID,
                QuantityPerUnit = Input.QuantityPerUnit,
                UnitPrice = Input.UnitPrice,
                UnitsInStock = Input.UnitsInStock,
                UnitsOnOrder = Input.UnitsOnOrder,
                ReorderLevel = Input.ReorderLevel,
                Discontinued = Input.Discontinued
            };

            int id = productService.AddProduct(newProduct);
            if (id > 0)
            {
                newProduct.ProductID = id;
                Products.Add(newProduct);
                ClearForm();
            }
        }

        public void UpdateProduct()
        {
            if (SelectedProduct == null) return;

            SelectedProduct.ProductName = Input.ProductName;
            SelectedProduct.SupplierID = Input.SupplierID;
            SelectedProduct.CategoryID = Input.CategoryID;
            SelectedProduct.QuantityPerUnit = Input.QuantityPerUnit;
            SelectedProduct.UnitPrice = Input.UnitPrice;
            SelectedProduct.UnitsInStock = Input.UnitsInStock;
            SelectedProduct.UnitsOnOrder = Input.UnitsOnOrder;
            SelectedProduct.ReorderLevel = Input.ReorderLevel;
            SelectedProduct.Discontinued = Input.Discontinued;

            bool success = productService.UpdateProduct(SelectedProduct);
            if (success)
            {
                // Notify change
                Products = new ObservableCollection<Product>(productService.GetAllProducts());
                ClearForm();
            }
        }

        public void DeleteProduct()
        {
            if (SelectedProduct == null) return;

            bool success = productService.DeleteProduct(SelectedProduct.ProductID);
            if (success)
            {
                Products.Remove(SelectedProduct);
                ClearForm();
            }
        }

        private void ClearForm()
        {
            Input.ProductName = string.Empty;
            Input.SupplierID = null;
            Input.CategoryID = null;
            Input.QuantityPerUnit = string.Empty;
            Input.UnitPrice = null;
            Input.UnitsInStock = null;
            Input.UnitsOnOrder = null;
            Input.ReorderLevel = null;
            Input.Discontinued = null;
            SelectedProduct = null;
        }

        public void SearchProduct(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Products = new ObservableCollection<Product>(productService.GetAllProducts());
            } else
            {
                Products = new ObservableCollection<Product>(productService.SearchProductsByName(name));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
