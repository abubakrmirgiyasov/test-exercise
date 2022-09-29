using Client.Services;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Client.Views
{
    public partial class Filter : Page
    {
        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public Filter()
        {
            InitializeComponent();
        }

        private void GoHomeClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var list = new TcpSender().GetFilteredDataList(
                header: "GetFilteredDataList",
                device: DeviceName.Text,
                topDate: FromDate,
                bottomDate: ToDate);
                List.ItemsSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПопробуйте еще раз.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TopBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (TopDateBox.Text == "От")
            {
                TopDateBox.Text = "";
            }
        }

        private void TopBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (TopDateBox.Text == "")
            {
                TopDateBox.Text = "От";
            }
            else if (TopDateBox.Text != "")
            {
                try
                {
                    FromDate = DateTime.Parse(TopDateBox.Text);
                    TopDateBox.Text = FromDate.ToString();
                }
                catch
                {
                    MessageBox.Show("Пример: 01-01-2022 01:00", "Ошибка при вводе");
                }
            }
        }

        private void BottomBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (BottomDateBox.Text == "До")
            {
                BottomDateBox.Text = "";
            }
        }

        private void BottomBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (BottomDateBox.Text == "")
            {
                BottomDateBox.Text = "До";
            }
            else if (BottomDateBox.Text != "")
            {
                try
                {
                    ToDate = DateTime.Parse(BottomDateBox.Text);
                    BottomDateBox.Text = ToDate.ToString();
                }
                catch
                {
                    MessageBox.Show("Пример: 01-01-2022 01:00", "Ошибка при вводе");
                }
            }
        }

        private void TextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (DeviceName.Text == "Устройства")
            {
                DeviceName.Text = "";
            }
        }

        private void TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (DeviceName.Text == "")
            {
                DeviceName.Text = "Устройства";
            }
        }
    }
}
