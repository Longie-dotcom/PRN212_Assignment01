using DongXuanBaoLongWPF.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DongXuanBaoLongWPF.Views
{
    /// <summary>
    /// Interaction logic for ReportView.xaml
    /// </summary>
    public partial class ReportView : UserControl
    {
        private readonly StatisticsViewModel ViewModel; 
        public ReportView()
        {
            InitializeComponent();
            ViewModel = new StatisticsViewModel();
            DataContext = ViewModel;
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            // I havent done this yet ;3
        }

        private void OnLoadReport(object sender, RoutedEventArgs e)
        {
            ViewModel.LoadStatistics();
        }
    }
}
