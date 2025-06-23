using DongXuanBaoLongWPF.ViewModels;
using Repositories.Implementation;
using Services.Implementation;
using System.Windows;
using System.Windows.Controls;

namespace DongXuanBaoLongWPF.Views
{
    public partial class CustomerProfileView : UserControl
    {
        private readonly CustomerProfileViewModel ViewModel;

        public CustomerProfileView(int customerId)
        {
            InitializeComponent();
            ViewModel = new CustomerProfileViewModel(customerId, new CustomerService(new CustomerRepository()));
            DataContext = ViewModel;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.UpdateCustomer();
        }
    }
}
