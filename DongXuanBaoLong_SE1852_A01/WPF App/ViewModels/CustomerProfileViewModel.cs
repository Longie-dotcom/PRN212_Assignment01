using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using BussinessObject;
using Services.Interface;

namespace DongXuanBaoLongWPF.ViewModels
{
    public class CustomerProfileViewModel : INotifyPropertyChanged
    {
        private readonly ICustomerService _customerService;
        private Customer _customer;

        public CustomerProfileViewModel(int customerId, ICustomerService customerService)
        {
            _customerService = customerService;
            LoadCustomer(customerId);
        }

        private void LoadCustomer(int customerId)
        {
            Customer = _customerService.GetCustomerByID(customerId) ?? new Customer();
        }

        public Customer Customer
        {
            get => _customer;
            set
            {
                _customer = value;
                OnPropertyChanged();
            }
        }

        public void UpdateCustomer()
        {
            bool success = _customerService.UpdateCustomer(Customer);
            if (success)
                MessageBox.Show("Profile updated successfully.");
            else
                MessageBox.Show("Update failed.");
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
