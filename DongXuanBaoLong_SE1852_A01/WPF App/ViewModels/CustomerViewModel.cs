using BussinessObject;
using Services.Interface;
using Services.Implementation;
using Repositories.Implementation;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DongXuanBaoLongWPF.Models;

namespace DongXuanBaoLongWPF.ViewModels
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        private readonly ICustomerService customerService;

        public CustomerFormModel Input { get; set; } = new CustomerFormModel();

        private ObservableCollection<Customer> customers;
        private Customer selectedCustomer;

        public ObservableCollection<Customer> Customers
        {
            get => customers;
            set
            {
                customers = value;
                OnPropertyChanged(nameof(Customers));
            }
        }

        public Customer SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                OnPropertyChanged(nameof(SelectedCustomer));
            }
        }

        public CustomerViewModel()
        {
            customerService = new CustomerService(new CustomerRepository());
            var list = customerService.GetAllCustomers();
            Customers = new ObservableCollection<Customer>(list);
        }

        public void AddCustomerFromInput()
        {
            if (!string.IsNullOrWhiteSpace(Input.ContactName))
            {
                var newCustomer = new Customer
                {
                    CompanyName = Input.CompanyName,
                    ContactName = Input.ContactName,
                    ContactTitle = Input.ContactTitle,
                    Address = Input.Address,
                    Phone = Input.Phone
                };

                int id = customerService.AddCustomer(newCustomer);
                if (id > 0)
                {
                    newCustomer.CustomerID = id;
                    Customers.Add(newCustomer);

                    // Clear form
                    Input.CompanyName = Input.ContactName = Input.ContactTitle = Input.Address = Input.Phone = "";
                    OnPropertyChanged(nameof(Input));
                }
            }
        }

        public void UpdateCustomer(Customer updatedCustomer)
        {
            bool result = customerService.UpdateCustomer(updatedCustomer);
            if (result)
            {
                // Force refresh by removing and re-adding
                var index = Customers.IndexOf(updatedCustomer);
                if (index >= 0)
                {
                    Customers[index] = updatedCustomer;
                }
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            bool result = customerService.DeleteCustomer(customer.CustomerID);
            if (result)
            {
                Customers.Remove(customer);
            }
        }

        public void SearchCustomer(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Customers = new ObservableCollection<Customer>(customerService.GetAllCustomers());
            } else
            {
                Customers = new ObservableCollection<Customer>(customerService.SearchCustomersByName(name));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
