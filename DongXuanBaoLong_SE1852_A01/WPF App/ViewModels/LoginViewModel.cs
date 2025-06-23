using BussinessObject;
using Repositories.Implementation;
using Services.Implementation;
using Services.Interface;
using System.ComponentModel;
using System.Windows;

namespace WPF_App.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string phone;
        private readonly ICustomerService customerService;

        private string password;
        private string userName;
        private readonly IEmployeeService employeeService;

        private string selectedRole = "Customer";

        public string Phone
        {
            get => phone;
            set { phone = value; OnPropertyChanged(nameof(Phone)); }
        }

        public string Password
        {
            get => password;
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }
        public string UserName
        {
            get => userName;
            set { userName = value; OnPropertyChanged(nameof(UserName)); }
        }

        public string SelectedRole
        {
            get => selectedRole;
            set
            {
                selectedRole = value;
                OnPropertyChanged(nameof(SelectedRole));
                OnPropertyChanged(nameof(IsCustomer));
                OnPropertyChanged(nameof(IsEmployee));
            }
        }

        public bool IsCustomer => SelectedRole == "Customer";
        public bool IsEmployee => SelectedRole == "Employee";

        public LoginViewModel()
        {
            customerService = new CustomerService(new CustomerRepository());
            employeeService = new EmployeeService(new EmployeeRepository());
        }

        public Customer? LoginCustomer()
        {
            return customerService.Login(phone);
        }

        public Employee? LoginEmployee()
        {
            return employeeService.Login(userName, password);
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
