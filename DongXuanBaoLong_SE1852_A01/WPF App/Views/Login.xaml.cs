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
using DongXuanBaoLongWPF.ViewModels;

namespace DongXuanBaoLongWPF.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly LoginViewModel loginViewModel;

        public Login()
        {
            InitializeComponent();
            loginViewModel = new LoginViewModel();
            DataContext = loginViewModel;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            loginViewModel.Password = employeePasswordBox.Password;

            string role = (loginRoleComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (role == "Customer")
            {
                var customer = loginViewModel.LoginCustomer();
                if (customer != null)
                {
                    MessageBox.Show("Login successful!");
                    var customerWindow = new CustomerDashBoard(customer.CustomerID);
                    customerWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
            }
            else if (role == "Employee")
            {
                var employee = loginViewModel.LoginEmployee();
                if (employee != null)
                {
                    MessageBox.Show("Login successful!");
                    var employeeWindow = new EmployeeDashBoard(employee.EmployeeID);
                    employeeWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
            }
        }
    }
}
