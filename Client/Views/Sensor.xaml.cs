using Client.Services;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Client.Views
{
    public partial class Sensor : Page
    {
        public Sensor()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DeviceId.ItemsSource = new TcpSender().GetDeviceList("GetDeviceList");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПопробуйте еще раз.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GoHomeClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Items());
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            var deviceId = Guid.Parse(DeviceId.SelectedValue.ToString());

            if (deviceId == null)
            {
                MessageBox.Show("Выберете устройство");
            }
            else
            {
                try
                {
                    new TcpSender().SendSensorData("Sensor", SensorName.Text, SensorDescription.Text, deviceId);
                    NavigationService.Navigate(new Items());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nПопробуйте еще раз.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
