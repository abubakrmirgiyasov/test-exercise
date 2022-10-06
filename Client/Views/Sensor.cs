using System;
using System.Windows.Forms;

namespace Client.Views
{
    public partial class Sensor : Form
    {
        public Sensor()
        {
            InitializeComponent();
        }

        private void Sensor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (SensorName_T.Text == string.Empty)
                {
                    throw new Exception("Заполните поле Имя датчика ");
                }
                else if (DeviceName_C.SelectedIndex == -1)
                {
                    throw new Exception("Выберете устройство");
                }
                else if (SensorDescription_T.Text == string.Empty)
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
