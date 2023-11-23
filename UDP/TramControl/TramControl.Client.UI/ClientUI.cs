using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TramControl.Communication;

namespace TramControl.Client.UI
{
    public partial class ClientUI : Form
    {
        private Socket _clientSocket;
        private IPAddress _ip;
        private int _port;
        private IPEndPoint _ipEndPoint;
        private SocketWriter _socketWriter;
        public ClientUI()
        {
            InitializeComponent();
            _ip = IPAddress.Loopback;
            _port = 4711;
            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (CheckIP(tbxIP.Text))
            {
                _ip = IPAddress.Parse(tbxIP.Text);
            }

            if (CheckPort(tbxPort.Text))
            {
                _port = Int32.Parse(tbxPort.Text);
            }
            _ipEndPoint = new IPEndPoint(_ip, _port);
            _clientSocket.Connect(_ipEndPoint);
            _socketWriter = new SocketWriter(_clientSocket);


        }

        private bool CheckIP(string ip)
        {
            IPAddress _ip = IPAddress.Any;
            if (ip.Split('.').Length == 4)
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
                if (_port > 1024 && _port < 65536)
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _clientSocket.Shutdown(SocketShutdown.Both);
                _clientSocket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error(Client):" + ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            // man muss hier prüfen welche checkboxen angewählt worden sind, und dann mit denen eine zeichenfolge erstellt werden muss
            // und dann in Binaryformat mithilfe von Convert.ToByte(Zeichenfolge,2) als Byte geschickt werden. (ging sich nicht aus)

            //string tramEnumBin = "";
            //if ()
            //{

            //}
            //_socketWriter.SendData(data)
        }
    }
}
