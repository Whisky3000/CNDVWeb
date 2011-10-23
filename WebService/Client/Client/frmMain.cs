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

        private void btn_BasicHttp_Click(object sender, EventArgs e)
        {
            try
            {
                EndpointAddress address = new EndpointAddress("http://localhost:8001/WebService");
                BasicHttpBinding binding = new BasicHttpBinding();

                IService proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                string grouphttp = proxy.GetAuthors();
                txbBasicHttp.Text = grouphttp;
            }
            catch {
                MessageBox.Show("Service no response", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_NetTcp_Click(object sender, EventArgs e)
        {
            try
            {
                EndpointAddress address = new EndpointAddress("net.tcp://localhost:9000/WebService");
                NetTcpBinding binding = new NetTcpBinding();

                IService proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                string groupnet = proxy.GetAuthors();
                txb_Tcp.Text = groupnet;
            }
            catch {
                MessageBox.Show("Service no response", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_WsHttp_Click(object sender, EventArgs e)
        {
            try
            {
                EndpointAddress adress = new EndpointAddress("http://localhost:8002/WebService");
                WSHttpBinding binding = new WSHttpBinding();

                IService proxy = ChannelFactory<IService>.CreateChannel(binding, adress);
                string groupnet = proxy.GetAuthors();
                txbWsHttp.Text = groupnet;
            }
            catch
            {
                MessageBox.Show("Service no respone", "Error", MessageBoxButtons.YesNo);
            }
        }

    }
}
