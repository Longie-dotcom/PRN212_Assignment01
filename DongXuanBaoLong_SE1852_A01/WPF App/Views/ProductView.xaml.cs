using System.Windows;
using System.Windows.Controls;
using DongXuanBaoLongWPF.ViewModels;

namespace DongXuanBaoLongWPF.Views
{
    public partial class ProductView : UserControl
    {
        private ProductViewModel ViewModel;

        public ProductView()
        {
            InitializeComponent();
            ViewModel = new ProductViewModel();
            DataContext = ViewModel;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.AddProduct();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.UpdateProduct();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.DeleteProduct();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SearchProduct(SearchBox.Text);
        }
    }
}
