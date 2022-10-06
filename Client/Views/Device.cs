using System;
using System.Windows.Forms;

namespace Client.Views
{
    public partial class Device : Form
    {
        public Device()
        {
            InitializeComponent();
        }

        private void Device_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DeviceName_T.Text == string.Empty)
                {
                    throw new Exception("Заполните поле Имя устройства");
                }
                else if (DeviceDescription_T.Text == string.Empty)
                {
                    throw new Exception("Заполните поле Описание");
                }
                e.Cancel = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.Cancel = true;
            }
        }
    }
}
