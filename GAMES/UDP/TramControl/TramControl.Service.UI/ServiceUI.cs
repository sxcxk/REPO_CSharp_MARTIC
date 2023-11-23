using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TramControl.Communication;
using TramControl.Service.Core;
namespace TramControl.Service.UI
{
    public partial class ServiceUI : Form, ILogWriter
    {
        private TcpService _tcpService;
        private Action<string> _logSysInfo;
        private IPAddress _ip;
        private int _port;
        private TramManager _tramManager;
        public ServiceUI()
        {
            InitializeComponent();
            _port = 4711;
            _ip = IPAddress.Loopback;
            _logSysInfo = new Action<string>(LogSystemInfo);
            _tramManager = TramManager.Instance;
        }

        public void LogRequest(string text)
        {
        }

        public void LogResponse(string text)
        {
        }

        public void LogSystemInfo(string text)
        {
            if (lbxSysLog.InvokeRequired)
            {
                lbxSysLog.Invoke(_logSysInfo, text);
            }
            else
            {
                lbxSysLog.Items.Add(text);
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (CheckIP(tbxIP.Text))
            {
                _ip = IPAddress.Parse(tbxIP.Text);
            }

            if (CheckPort(tbxPort.Text))
            {
                _port = Int32.Parse(tbxPort.Text);
            }

            _tcpService = new TcpService(_ip, _port, this);
            ThreadStart threadStart = new ThreadStart(_tcpService.Start);
            Thread thread = new Thread(threadStart);
            thread.IsBackground = true;
            thread.Start();
            thread.Join();
        }

        private bool CheckIP(string ip)
        {
            IPAddress _ip = IPAddress.Any;
            if (ip.Split('.').Length==4)
            {
                if (IPAddress.TryParse(ip, out _ip))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckPort(string port)
        {
            int _port = 0;
            if (Int32.TryParse(port, out _port))
            {
                if (_port>1024 &&_port <65536)
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            _tcpService.Stop();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            List<TramWayInformation> tramWayInformations = _tramManager.GetList();
            if (rbtnTxt.Checked)
            {
                saveFileDialog1.FileName = combxLanguage.Text + ".txt";

                for (int i = 0; i < tramWayInformations.Count; i++)
                {
                    File.AppendAllText(saveFileDialog1.FileName,tramWayInformations[i].ToString());
                }
            }

            if (rbtnCsv.Checked)
            {
                saveFileDialog1.FileName = combxLanguage.Text + ".csv";

                for (int i = 0; i < tramWayInformations.Count; i++)
                {
                    File.AppendAllText(saveFileDialog1.FileName, tramWayInformations[i].ToString());
                }
            }

            if (rbtnXml.Checked)
            {
                saveFileDialog1.FileName = combxLanguage.Text + ".xml";

                for (int i = 0; i < tramWayInformations.Count; i++)
                {
                    File.AppendAllText(saveFileDialog1.FileName, tramWayInformations[i].ToString());
                }
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lbxSysLog.Items.Clear();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==DialogResult.OK)
            {
                string[] data = File.ReadAllLines(openFileDialog1.FileName);
                for (int i = 0; i < data.Length; i++)
                {
                    lbxSysLog.Items.Add(data[i]);

                }
            }
        }
    }
}
