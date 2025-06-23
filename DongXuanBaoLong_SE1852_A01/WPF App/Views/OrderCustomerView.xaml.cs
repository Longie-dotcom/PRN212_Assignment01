using DongXuanBaoLongWPF.ViewModels;
using Repositories.Implementation;
using Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DongXuanBaoLongWPF.Views
{
    /// <summary>
    /// Interaction logic for OrderCustomerView.xaml
    /// </summary>
    public partial class OrderCustomerView : UserControl
    {
        public OrderCustomerView(int customerId)
        {
            InitializeComponent();
            var orderService = new OrderViewService(
                new OrderRepository(),
                new OrderDetailRepository(),
                new CustomerRepository(),
                new EmployeeRepository(),
                new ProductRepository()
            );

            DataContext = new CustomerOrderHistoryViewModel(customerId, orderService);
        }
    }
}
