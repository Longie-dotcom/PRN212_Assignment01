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
using System.Windows.Shapes;

namespace DongXuanBaoLongWPF.Views
{
    /// <summary>
    /// Interaction logic for CustomerDashBoard.xaml
    /// </summary>
    public partial class CustomerDashBoard : Window
    {
        private readonly int customerId;

        public CustomerDashBoard(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CustomerProfileView(customerId);
        }

        private void OrderHistory_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new OrderCustomerView(customerId);
        }
    }
}
