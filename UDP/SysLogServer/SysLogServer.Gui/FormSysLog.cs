using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysLogServer.Core;
using SysLogServer.Shared;

namespace SysLogServer.Gui
{
    public partial class FormSysLog : Form, IServiceLogger
    {
        private string _servertype;
        private FormSelectionTCPUDP _formSelection;
        private Action<string> _logRequestInformation;
        private Action<string> _logResponseInformation;
        private SysLogManager _sysLogManager;
        private TcpService _tcpService;
        private UdpService _udpService;

        public FormSysLog(string serverType, FormSelectionTCPUDP formSelection)
        {
            InitializeComponent();
            _servertype = serverType;
            _formSelection = formSelection;

            _sysLogManager = SysLogManager.Instance;
            _logRequestInformation = new Action<string>(LogRequestInformation);
            _logResponseInformation = new Action<string>(LogResponseInformation);
        }

        public void LogRequestInformation(string text)
        {
            if (lbxInfoStatus.InvokeRequired)
            {
                lbxInfoStatus.Invoke(_logRequestInformation, text);
            }

            else
            {
                lbxInfoStatus.Items.Add(text);
            }
        }

        public void LogResponseInformation(string text)
        {
            if (listViewSysLog.InvokeRequired)
            {
                listViewSysLog.Invoke(_logResponseInformation, text);
            }

            else
            {
                lbxInfoStatus.Items.Add(text);
                FillSysLog();
            }
        }

        private void ClearSysLog()
        {
            listViewSysLog.Items.Clear();
        }

        private void FillSysLog()
        {
            ClearSysLog();
            List<SysLogMessage> messages = _sysLogManager.GetList();
            string[] data = new string[5];
            for (int i = 0; i < messages.Count; i++)
            {
                SysLogMessage message = messages[i];
                data = message.ToString().Split(';');

                string timeStamp = data[1];
                int facility = (int)messages[i].FacilityValue;
                int severity = (int)messages[i].SeverityValue;
                int priority = (facility << 3) | severity;


                ListViewItem item = new ListViewItem(priority.ToString());
                item.SubItems.Add(severity.ToString());
                item.SubItems.Add(facility.ToString());
                item.SubItems.Add(timeStamp);
                item.SubItems.Add(messages[i].SourceIp.ToString());
                item.SubItems.Add(messages[i].Message.ToString());
                listViewSysLog.Items.Add(item);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (_servertype.ToLower() == "tcp")
            {
                _tcpService = new TcpService(8080, this);
                ThreadStart _threadStart = new ThreadStart(_tcpService.Start);
                Thread _thread = new Thread(_threadStart);
                _thread.IsBackground = true;
                _thread.Start();
            }

            if (_servertype.ToLower() == "udp")
            {
                _udpService = new UdpService(8080, this);
                ThreadStart _threadStart = new ThreadStart(_udpService.Start);
                Thread _thread = new Thread(_threadStart);
                _thread.IsBackground = true;
                _thread.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_servertype.ToLower() == "tcp")
            {
                _tcpService = new TcpService(8080, this);
                ThreadStart _threadStart = new ThreadStart(_tcpService.Stop);
                Thread _thread = new Thread(_threadStart);
                _thread.IsBackground = true;
                _thread.Start();
            }

            if (_servertype.ToLower() == "udp")
            {
                _udpService = new UdpService(8080, this);
                ThreadStart _threadStart = new ThreadStart(_udpService.Stop);
                Thread _thread = new Thread(_threadStart);
                _thread.IsBackground = true;
                _thread.Start();
            }
        }

        private void btnResetLogs_Click(object sender, EventArgs e)
        {
            ClearSysLog();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillSysLog();
        }

        private void FormSysLogTCP_Load(object sender, EventArgs e)
        {

        }

        private void stripMenuSelection_Click(object sender, EventArgs e)
        {
            _formSelection.Show();
            this.Close();

        }
    }
}
