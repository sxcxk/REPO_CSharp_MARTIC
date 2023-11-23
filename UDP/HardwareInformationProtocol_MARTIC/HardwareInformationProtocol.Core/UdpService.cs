using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HardwareInformationProtocol.Core
{
    public class UdpService
    {
        private IPAddress _ip;
        private int _port;
        private Socket _serverSocket;
        private IPEndPoint _ep;
        IServiceLogger _logger;


        public UdpService(IPAddress ip,int port, IServiceLogger serviceLogger)
        {
            _logger = serviceLogger;

            IPAddress iPAddress = null;
            _ip = IPAddress.Loopback;
            _port = 1603;
            if (port > 1024 || port < 65536)
            {
                _port = port;
            }

            if (IPAddress.TryParse(ip.ToString(),out iPAddress))
            {
                _ip = iPAddress;
            }
            _ep = new IPEndPoint(_ip,_port);
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }


        public void Start()
        {
            _serverSocket.Bind(_ep);
            _logger.LogSysInformation(DateTime.Now.ToString() + "- Server started...");
            MessageQueue messageQueue = new MessageQueue(_serverSocket,_logger);
            ThreadStart threadStart = new ThreadStart(messageQueue.HandleIncomingMessage);
            Thread thread = new Thread(threadStart);
            thread.IsBackground = true;
            thread.Start();
            thread.Join();
            Stop();
        }

        public void Stop()
        {
            if (_serverSocket!=null)
            {
                try
                {
                    _serverSocket.Shutdown(SocketShutdown.Both);
                    _serverSocket.Close();
                }
                catch (Exception ex)
                {
                    _logger.LogSysInformation("Error: " + ex.Message);
                }
            }
        }
    }
}
;