using System.Collections.ObjectModel;
using System.ComponentModel;
using Services.Interface;
using Services.Implementation;
using Repositories.Implementation;
using DTOs;
using BussinessObject;
using System;
using System.Linq;

namespace DongXuanBaoLongWPF.ViewModels
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        private readonly IOrderViewService orderViewService;
        private readonly IProductService productService;
        private readonly IOrderCreateService orderCreateService;

        public ObservableCollection<OrderDetailDTO> Orders { get; set; } = new();
        public ObservableCollection<Product> Products { get; set; } = new();

        public ObservableCollection<OrderDetailItemDTO> SelectedOrderItems =>
            new(SelectedOrder?.Items ?? new List<OrderDetailItemDTO>());

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

        // --- New Order Inputs ---
        public int SelectedCustomerID { get; set; }
        public Product? SelectedProduct { get; set; }
        public int Quantity { get; set; } = 1;
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
            orderCreateService = new OrderCreateService(
                new OrderRepository(),
                new OrderDetailRepository());

            LoadOrders();
            LoadAllProducts();
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

        // --- ADD ORDER FUNCTION ---
        public void AddOrder()
        {
            if (SelectedProduct == null || SelectedCustomerID <= 0 || Quantity <= 0)
                return;

            var order = new Order
            {
                CustomerID = SelectedCustomerID,
                EmployeeID = employeeId,
                OrderDate = DateTime.Now
            };

            var orderDetail = new OrderDetail
            {
                ProductID = SelectedProduct.ProductID,
                Quantity = Quantity,
                UnitPrice = SelectedProduct?.UnitPrice ?? -1,
                Discount = Discount
            };

            orderCreateService.CreateOrder(order, orderDetail);

            LoadOrders(); // Refresh view
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
