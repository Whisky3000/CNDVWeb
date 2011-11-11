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
                EndpointAddress address = new EndpointAddress("http://localhost:7000/Connect/BasicHttpbinding");
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
                EndpointAddress address = new EndpointAddress("http://localhost:7000/Connect/WsHttpbinding");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbBasicHttp.Text != "")
              txbAll.Text   = txbBasicHttp.Text + txbAdd.Text;
            if (txbNetTcp.Text != "")
                txbAll.Text = txbNetTcp.Text + txbAdd.Text;
            if (txbWsHttp.Text != "")
                txbAll.Text = txbWsHttp.Text + txbAdd.Text;
        }

        public void Callback(object sne, ClientServiceReference.GetAuthorCompletedEventArgs e)
        {
            txbAll.Text = e.Result;
        }
        private void btnAsyn_Click(object sender, EventArgs e)
        {
            txbAll.Text = "Asyn. You cando anything@";
            ClientServiceReference.ServiceClient proxy = new ClientServiceReference.ServiceClient();
            proxy.GetAuthorCompleted +=new EventHandler<GetAuthorCompletedEventArgs>(Callback);
            proxy.GetAuthorAsync();//sau khi getauthor se goi callback de lay ket qua ve
            proxy.Close();

        }

        private void btSyn_Click(object sender, EventArgs e)
        {
            txbAll.Text = "Syn. You can't do anything@";
            ClientServiceReference.ServiceClient proxy = new ClientServiceReference.ServiceClient();
            txbAll.Text = proxy.GetAuthor();
            proxy.Close();
        }

       
        
        
    }
}
