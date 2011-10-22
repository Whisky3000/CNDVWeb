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

namespace Host
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }
        private ServiceHost host;
        public void StartService()
        {
            Type contractType = typeof(IService);
            Type instanceType = typeof(OperationService);
            Uri baseAddresshttp = new Uri("http://localhost:8001/WebService");
            host = new ServiceHost(instanceType, baseAddresshttp);
                                                         
            switch (CB1.SelectedIndex)
            {
                case 0: // Create basicHttpBinding endpoint
                    host.AddServiceEndpoint(contractType, new BasicHttpBinding(), "http://localhost:8001/WebService");
                    break;
                case 1:
                    NetTcpBinding A = new NetTcpBinding(SecurityMode.Transport);
                    host.AddServiceEndpoint(contractType, new NetTcpBinding(), "net.tcp://localhost:9000/WebService");
                    break;
            }

                    // Add behavior for our MEX endpoint
                    //Add Mex endpoint can dung de khi client discovery thay duoc service
                    
                    // Add MEX endpoint at http://localhost:8000/MEX/
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    host.Description.Behaviors.Add(behavior);
                    host.AddServiceEndpoint(typeof(IMetadataExchange), new BasicHttpBinding(), "MEX");
                    host.Open();
                    lbl_mess.Text = "Service is starting";
                    lbl_mess.ForeColor = Color.Green;
                    
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartService();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            host.Close();
            lbl_mess.Text = "Service closed";
            lbl_mess.ForeColor = Color.Red;
        }

    }
}
