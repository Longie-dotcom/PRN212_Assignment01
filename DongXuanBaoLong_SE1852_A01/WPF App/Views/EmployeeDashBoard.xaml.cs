using BussinessObject;
using System.Windows;

namespace DongXuanBaoLongWPF.Views
{
    public partial class EmployeeDashBoard : Window
    {
        private readonly int employeeId;

        public EmployeeDashBoard(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
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
            MainContent.Content = new OrderView(employeeId); // Create this UserControl
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
