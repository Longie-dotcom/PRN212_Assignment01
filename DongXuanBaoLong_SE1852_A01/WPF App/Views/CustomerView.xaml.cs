using System.Windows;
using System.Windows.Controls;
using DongXuanBaoLongWPF.ViewModels;

namespace DongXuanBaoLongWPF.Views
{
    public partial class CustomerView : UserControl
    {
        private readonly CustomerViewModel ViewModel;

        public CustomerView()
        {
            InitializeComponent();
            ViewModel = new CustomerViewModel();
            DataContext = ViewModel;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.AddCustomerFromInput();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.SelectedCustomer != null)
                ViewModel.UpdateCustomer(ViewModel.SelectedCustomer);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.SelectedCustomer != null)
                ViewModel.DeleteCustomer(ViewModel.SelectedCustomer);
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SearchCustomer(SearchBox.Text);
        }
    }
}
