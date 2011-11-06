using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using ClientForm.ClientServiceReference;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasicHttp_Click(object sender, EventArgs e)
        {
            try
            {
                EndpointAddress address = new EndpointAddress("http://localhost:2000/Connect");
                BasicHttpBinding binding = new BasicHttpBinding();
                //khai bao cong ket noi
                IService proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                string groupBasicHttp = proxy.GetAuthor();
                txbBasicHttp.Text = groupBasicHttp;
            }
            catch
            {
                MessageBox.Show("Link is error! Try again!","Error", MessageBoxButtons.OK);
            }
        }

        private void btnNetTcp_Click(object sender, EventArgs e)
        {
            try
            {
                EndpointAddress address = new EndpointAddress("net.tcp://localhost:3000/Connect");
                NetTcpBinding binding = new NetTcpBinding();

                IService proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                string groupTcp = proxy.GetAuthor();
                txbNetTcp.Text = groupTcp;
            }
            catch
            {
                MessageBox.Show("Link is error!Try again!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnWsHttp_Click(object sender, EventArgs e)
        {
            try
            {
                EndpointAddress address = new EndpointAddress("http://localhost:8732/Design_Time_Addresses/Host/Service1/");
                WSHttpBinding binding = new WSHttpBinding();

                IService proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                string groupWsHttp = proxy.GetAuthor();
                txbWsHttp.Text = groupWsHttp;
            }
            catch
            {
                MessageBox.Show("Link is error! Try a again!", "Error", MessageBoxButtons.OK);
            }
        }

        
        
    }
}
