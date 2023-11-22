using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficCounting.Core;

namespace TrafficCounting.Service
{
    public partial class TrafficCountingServiceGUI : Form,IServiceLogger
    {
        private Action<string> _logRequestInformation;
        private Action<string> _logSystemInformation;
        private TcpService tcpService;
        public TrafficCountingServiceGUI()
        {
            InitializeComponent();
            _logRequestInformation = new Action<string>(LogRequestInformation);
            _logSystemInformation = new Action<string>(LogSystemInformation);
        }

        

        public void LogRequestInformation(string text)
        {
            if (lbxRequestInformation.InvokeRequired)
            {
                lbxRequestInformation.Invoke(_logRequestInformation,text);
            }

            else
            {
                lbxRequestInformation.Items.Add(text);
            }
        }

        public void LogSystemInformation(string text)
        {
            if (lbxSystemInformationLog.InvokeRequired)
            {
                lbxSystemInformationLog.Invoke(_logSystemInformation,text);
            }

            else
            {
                lbxSystemInformationLog.Items.Add(text);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (tbxPortValue.Text == "N/A" || tbxPortValue.Text == "") 
            {
                tbxPortValue.Text = 1407.ToString();
            }
            int port = Convert.ToInt32(tbxPortValue.Text);
            tcpService = new TcpService(port,this);
            lblIpValue.Text = IPAddress.Loopback.ToString();
            
            ThreadStart threadStart = new ThreadStart(tcpService.Start);
            Thread thread = new Thread(threadStart);
            thread.IsBackground = true;
            thread.Start();


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tcpService.Stop();
        }
    }
}
