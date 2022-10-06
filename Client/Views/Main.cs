using Client.Services;
using Client.Views;
using System;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Main : Form
    {
        private bool _isRunning = false;

        public Main()
        {
            InitializeComponent();
        }

        private void GetList_B_Click(object sender, EventArgs e)
        {
            try
            {
                List_D.DataSource = new TcpSender().GetCurrentList("GetCurrentList");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddDevice_B_Click(object sender, EventArgs e)
        {
            try
            {
                var device = new Device();

                if (device.ShowDialog() == DialogResult.OK)
                {
                    var deviceId = Guid.NewGuid().ToString();

                    new TcpSender()
                        .SendDeviceObject("Device", device.DeviceName_T.Text, device.DeviceDescription_T.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSensor_B_Click(object sender, EventArgs e)
        {
            try
            {
                var sensor = new Sensor();

                sensor.DeviceName_C.DataSource = new TcpSender().GetDeviceList("GetDeviceList");
                sensor.DeviceName_C.DisplayMember = "Name";
                sensor.DeviceName_C.ValueMember = "Id";
                
                if (sensor.ShowDialog() == DialogResult.OK)
                {
                    new TcpSender().SendSensorObject("Sensor", sensor.SensorName_T.Text, Guid.Parse(sensor.DeviceName_C.SelectedValue.ToString()), sensor.SensorDescription_T.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void Start_B_Click(object sender, EventArgs e)
        {
            try
            {
                _isRunning = true;
                Start_B.Enabled = false;
                Stop_B.Enabled = true;

                while (_isRunning)
                {
                    new TcpSender().SendGeneratedObject("SensorValue");
                    await Task.Delay(1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Stop_B_Click(object sender, EventArgs e)
        {
            _isRunning = false;
            Start_B.Enabled = true;
            Stop_B.Enabled = false;
        }

        private void Search_B_Click(object sender, EventArgs e)
        {
            var filter = new Filter();
            filter.ShowDialog();
        }
    }
}
