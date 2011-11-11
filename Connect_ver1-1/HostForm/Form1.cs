using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Description;
using System.Windows.Forms;
using HostLibrary;


namespace HostForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ServiceHost host;
        public void StartService()
        {
            Uri baseaddress = new Uri("http://localhost:7000/Connect");
            Type contractType = typeof(IService);
            Type instantType = typeof(HostService);

            host = new ServiceHost(instantType, baseaddress);
            switch (cbEndPoint.SelectedIndex)
            {
                case 0://create BasicHttpBinding
                    //txbBaseAddress.Text = "http://localhost:7000/Connect";
                    {
                        
                        host.AddServiceEndpoint(contractType, new BasicHttpBinding(), "BasicHttpbinding");
                        txbBaseAddress.Text = "http://localhost:7000/Connect/BasicHttpbinding";
                        break;
                    }
                case 1://create NetTcpBinding
                    {
                        NetTcpBinding tcp = new NetTcpBinding(SecurityMode.Transport);
                        host.AddServiceEndpoint(contractType, new NetTcpBinding(), "net.tcp://localhost:3000/Connect");
                        txbBaseAddress.Text = "net.tcp://localhost:3000/Connect";
                        break;
                    }
                case 2://Create WsHttpBinding
                    {
                        WSHttpBinding wshttp = new WSHttpBinding();
                        host.AddServiceEndpoint(contractType, new WSHttpBinding(), "WsHttpBinding");
                        txbBaseAddress.Text = "http://localhost:7000/Connect/WsHttpbinding";
                        break;
                    }
            }

            // Add behavior for our MEX endpoint
            //Add Mex endpoint can dung de khi client discovery thay duoc service
            //neu khong add thi khi khong add duoc service refference
            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            behavior.HttpGetEnabled = true;
            host.Description.Behaviors.Add(behavior);
            //Add Mex Endpoint 
            host.AddServiceEndpoint(contractType, new BasicHttpBinding(), "Mex");
            host.Open();
            lbl_Status.Text = " Service is starting";
            lbl_Status.ForeColor = Color.BlueViolet;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartService();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            host.Close();
            lbl_Status.Text = " Service stopped";
            lbl_Status.ForeColor = Color.GhostWhite;       
        }

        
    }

}
