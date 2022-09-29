using Client.Views;
using System.Windows;

namespace Client
{
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            MainFrame.Content = new Items();
        }
    }
}
