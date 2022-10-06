using Client.Services;
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;

namespace Client.Views
{
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
        }

        private void Search_B_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new TcpSender().GetFilteredData(
                    header: "GetFilteredDataList",
                    device: Device_T.Text,
                    topDate: DateTime.Parse(TopDate_T.Text),
                    bottomDate: DateTime.Parse(BottomDate_T.Text));
                List_D.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
