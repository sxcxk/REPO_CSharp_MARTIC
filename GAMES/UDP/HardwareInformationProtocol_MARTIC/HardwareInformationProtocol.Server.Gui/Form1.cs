using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareInformationProtocol.Core;

namespace HardwareInformationProtocol.Server.Gui
{
    public partial class Form1 : Form, IServiceLogger
    {

        private Action<string> _logRequest;
        private Action<string> _logSysInfo;
        private UdpService _udpService;
        public Form1()
        {
            InitializeComponent();
            _logRequest = new Action<string>(LogRequestInformation);
            _logSysInfo = new Action<string>(LogSysInformation);
        }

        public void LogRequestInformation(string text)
        {
            if (lbxLogRequest.InvokeRequired)
            {
                lbxLogRequest.Invoke(_logRequest, text);
            }

            else
            {
                lbxLogRequest.Items.Add(text);
            }
        }

        public void LogSysInformation(string text)
        {
            if (lbxLogSysInfo.InvokeRequired)
            {
                lbxLogRequest.Invoke(_logSysInfo, text);
            }

            else
            {
                lbxLogSysInfo.Items.Add(text);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Loopback;
            int port = 1609;

            port = Convert.ToInt32(tbxPortValue.Text);

            _udpService = new UdpService(ip, port, this);
            _udpService.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _udpService.Stop();
        }
    }
}
