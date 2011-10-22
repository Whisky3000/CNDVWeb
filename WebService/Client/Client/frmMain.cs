using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Client.ServiceReference;

namespace Client
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_Author_Click(object sender, EventArgs e)
        {
            try
            {
                EndpointAddress address = new EndpointAddress("http://localhost:8001/WebService");
                BasicHttpBinding binding = new BasicHttpBinding();

                IService proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                string grouphttp = proxy.GetAuthors();
                txbHttp.Text = grouphttp;
            }
            catch {
                MessageBox.Show("Service no response", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_getListNetTcp_Click(object sender, EventArgs e)
        {
            try
            {
                EndpointAddress address = new EndpointAddress("net.tcp://localhost:9000/WebService");
                NetTcpBinding binding = new NetTcpBinding();

                IService proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                string groupnet = proxy.GetAuthors();
                txbTcp.Text = groupnet;
            }
            catch {
                MessageBox.Show("Service no response", "Error", MessageBoxButtons.OK);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
