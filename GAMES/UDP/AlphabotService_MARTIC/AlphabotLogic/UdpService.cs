using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlphabotLogic
{
    public class UdpService
    {
        private MessageQueue _messageQueue;
        private Socket _serviceSocket;
        private IPAddress _serviceAddress;
        private int _port;
        private IPEndPoint _serviceEndpoint;
        private IServiceLogger _logger;
       

        public IPAddress ServiceAddress { get => _serviceAddress; set => _serviceAddress = value; }
        public int Port { get => _port; set => _port = value; }
        public IServiceLogger Logger { get => _logger; set => _logger = value; }

        public UdpService(int port, IPAddress serviceAddress, IServiceLogger logger)
        {
            string[] ip = serviceAddress.ToString().Split('.');
            if (port < 1000 && port > 65536)
            {
                _port = 1704;
            }

            else
            {
                _port = port;
            }

            if (ip.Length == 4)
            {
                _serviceAddress = serviceAddress;
            }

            else
            {
                _serviceAddress = IPAddress.Loopback;
            }

            _serviceSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _serviceEndpoint = new IPEndPoint(_serviceAddress, _port);
            
          Logger = logger;
        }



        public void Start()
        {
            _serviceSocket.Bind(_serviceEndpoint);
            _messageQueue = new MessageQueue(_serviceSocket,_logger);
            _logger.LogInformation("Server Started: " + DateTime.Now.ToString());
            ThreadStart _threadStart = new ThreadStart(_messageQueue.HandleIncomingMessages);
            Thread _thread = new Thread(_threadStart);
            _thread.IsBackground = true;
            _thread.Start();
        }

        public void Stop()
        {
            _serviceSocket.Shutdown(SocketShutdown.Both);
            _serviceSocket.Close();
        }
    }
}
