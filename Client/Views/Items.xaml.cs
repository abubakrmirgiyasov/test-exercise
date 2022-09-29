using Client.Services;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Client.Views
{
    public partial class Items : Page
    {
        private bool _isRunning = false;

        public Items()
        {
            InitializeComponent();
        }

        private void GetItemsClick(object sender, RoutedEventArgs e)
        {
            try
            {
                List.ItemsSource = new TcpSender().GetCurrentDataList("GetCurrentList");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПопробуйте еще раз.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void StartClick(object sender, RoutedEventArgs e)
        {
            _isRunning = true;
            Start.IsEnabled = false;
            Stop.IsEnabled = true;

            try
            {
                while (_isRunning)
                {
                    new TcpSender().SendGeneratedData("SensorValue");
                    await Task.Delay(1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПопробуйте еще раз.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void StopClick(object sender, RoutedEventArgs e)
        {
            _isRunning = false;
            Start.IsEnabled = true;
            Stop.IsEnabled = false;
        }

        private void FilterClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Filter());
        }

        private void AddDeviceClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Device());
        }
    }
}
