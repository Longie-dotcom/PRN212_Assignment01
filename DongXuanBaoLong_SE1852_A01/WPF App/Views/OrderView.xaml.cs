using DongXuanBaoLongWPF.ViewModels;
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
    /// Interaction logic for OrderView.xaml
    /// </summary>
    public partial class OrderView : UserControl
    {
        private OrderViewModel ViewModel;
        public OrderView(int employeeId)
        {
            InitializeComponent();
            ViewModel = new OrderViewModel(employeeId);
            DataContext = ViewModel;
        }

        private void SearchProduct_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SearchProducts();
        }
    }
}
