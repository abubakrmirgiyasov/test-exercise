using Client.Services;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Client.Views
{
    public partial class Device : Page
    {
        public Device()
        {
            InitializeComponent();
        }

        private void GoHomeClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Items());
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                new TcpSender().SendDeviceData("Device", DeviceName.Text, DeviceDescription.Text);
                NavigationService.Navigate(new Sensor());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПопробуйте еще раз.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddSensor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Sensor());
        }
    }
}
