using System.Windows;
using System.Windows.Controls;

namespace WPF_App.Views
{
    public partial class EmployeeDashBoard : Window
    {
        public EmployeeDashBoard()
        {
            InitializeComponent();
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CustomerView(); // Create this UserControl
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ProductView(); // Create this UserControl
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new OrderView(); // Create this UserControl
        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ReportView(); // Create this UserControl
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
