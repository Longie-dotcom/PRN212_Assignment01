using System.Collections.ObjectModel;
using System.ComponentModel;
using Services.Interface;
using Services.Implementation;
using Repositories.Implementation;
using DTOs;
using BussinessObject;
using System;
using System.Linq;
using System.Windows;

namespace DongXuanBaoLongWPF.ViewModels
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        private readonly IOrderViewService orderViewService;
        private readonly IProductService productService;
        private readonly IOrderCreateService orderCreateService;
        private readonly ICustomerService customerService;

        public ObservableCollection<OrderDetailDTO> Orders { get; set; } = new();
        public ObservableCollection<Customer> Customers { get; set; } = new();
        public ObservableCollection<Product> Products { get; set; } = new();
        public string CustomerSearchText { get; set; }
        public ObservableCollection<OrderDetailItemDTO> SelectedOrderItems =>
            new(SelectedOrder?.Items ?? new List<OrderDetailItemDTO>());
        private Customer? selectedCustomer;
        private OrderDetailDTO selectedOrder;

        public OrderDetailDTO SelectedOrder
        {
            get => selectedOrder;
            set
            {
                if (selectedOrder != value)
                {
                    selectedOrder = value;
                    OnPropertyChanged(nameof(SelectedOrder));
                    OnPropertyChanged(nameof(SelectedOrderItems));
                }
            }
        }
        public Customer? SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                if (value != null)
                {
                    SelectedCustomerID = value.CustomerID;
                    CustomerName = value.ContactName;
                }
                OnPropertyChanged(nameof(SelectedCustomer));
                OnPropertyChanged(nameof(CustomerName));
            }
        }

        public Product? SelectedProduct
        { get => selectedProduct;
          set
            {
                selectedProduct = value;
                ProductName = value.ProductName;
                OnPropertyChanged(nameof(SelectedProduct));
                OnPropertyChanged(nameof(ProductName));
            }
        }

        public string ProductName
        {
            get; set;
        }

        // --- New Order Inputs ---
        public int SelectedCustomerID { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; } = 1;
        public Product selectedProduct;
        public float Discount { get; set; } = 0;
        public string ProductSearchText { get; set; }

        private readonly int employeeId;

        public OrderViewModel(int employeeId)
        {
            this.employeeId = employeeId;

            orderViewService = new OrderViewService(
                new OrderRepository(),
                new OrderDetailRepository(),
                new CustomerRepository(),
                new EmployeeRepository(),
                new ProductRepository());

            productService = new ProductService(new ProductRepository());
            customerService = new CustomerService(new CustomerRepository());
            orderCreateService = new OrderCreateService(
                new OrderRepository(),
                new OrderDetailRepository());

            LoadOrders();
            LoadAllProducts();
            LoadAllCustomers();
        }

        private void LoadOrders()
        {
            Orders.Clear();
            var allOrders = orderViewService.GetAllOrderDetails();
            foreach (var order in allOrders)
            {
                Orders.Add(order);
            }
            SelectedOrder = Orders.FirstOrDefault();
        }

        public void LoadAllProducts()
        {
            Products.Clear();
            foreach (var p in productService.GetAllProducts())
                Products.Add(p);
        }

        public void SearchProducts()
        {
            var matched = productService.SearchProductsByName(ProductSearchText ?? "");
            Products.Clear();
            foreach (var p in matched)
                Products.Add(p);
        }

        public void LoadAllCustomers()
        {
            Customers.Clear();
            foreach (var c in customerService.GetAllCustomers())
                Customers.Add(c);
        }

        public void SearchCustomers()
        {
            var matched = customerService.SearchCustomersByName(CustomerSearchText ?? "");
            Customers.Clear();
            foreach (var c in matched)
                Customers.Add(c);
        }

        // --- ADD ORDER FUNCTION ---
        public void AddOrder()
        {
            if (selectedProduct == null || SelectedCustomerID <= 0 || Quantity <= 0)
                return;

            var order = new Order
            {
                CustomerID = SelectedCustomerID,
                EmployeeID = employeeId,
                OrderDate = DateTime.Now
            };

            var orderDetail = new OrderDetail
            {
                ProductID = selectedProduct.ProductID,
                Quantity = Quantity,
                UnitPrice = selectedProduct?.UnitPrice ?? -1,
                Discount = Discount
            };

            orderCreateService.CreateOrder(order, orderDetail);

            LoadOrders(); // Refresh view

            MessageBox.Show("Added successfully!");
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
