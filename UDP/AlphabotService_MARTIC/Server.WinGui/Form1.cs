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
using AlphabotLogic;

namespace Server.WinGui
{

    public partial class Form1 : Form,IServiceLogger
    {
        UdpService _udpService;

        private Action<string> _logRequestInformation;
        private Action<string> _logResponseInformation;


        public Form1()
        {            
            InitializeComponent();
            _logRequestInformation = new Action<string>(LogInformation);
            _logResponseInformation = new Action<string>(LogReceivedCmdsInformation);
        }

        public void LogInformation(string text)
        {
            if (lbxSyslog.InvokeRequired)
            {
                lbxSyslog.Invoke(_logResponseInformation, text);
            }

            else
            {
                lbxSyslog.Items.Add(text);
            }
        }

        public void LogReceivedCmdsInformation(string text)
        {
            if (lbxReceivedCmds.InvokeRequired)
            {
                lbxReceivedCmds.Invoke(_logRequestInformation, text);
            }

            else
            {
                lbxReceivedCmds.Items.Add(text);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _udpService = new UdpService(1704, IPAddress.Loopback, this);
            lblValueIP.Text = IPAddress.Loopback.ToString();
            lblValuePort.Text = 1704.ToString();
            ThreadStart ts = new ThreadStart(_udpService.Start);
            Thread t = new Thread(ts);
            t.IsBackground = true;
            t.Start();
        }




        private void lviewSysLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lviewReceivedCmds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _udpService.Stop();
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }

    

       

        private void lbxSyslog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
