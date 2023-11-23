using SysLogServer.Core.UDP;
using SysLogServer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysLogServer.Core
{
    public class UdpService
    {
        private MessageQueue _messageQueue;
        private Socket _serverSocket;
        private IPEndPoint _endpoint;
        private IServiceLogger _serviceLogger;
         
        public UdpService(int port, IServiceLogger serviceLogger)
        {
            if (port < 1024 || port > 65536)
            {
                port = 8080;
            }
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _endpoint = new IPEndPoint(IPAddress.Loopback, port);
            _serviceLogger = serviceLogger;
        }

        public void Start()
        {
            _serverSocket.Bind(_endpoint);
            _serviceLogger.LogRequestInformation("Server started(UDP): " + DateTime.Now.ToString());
            _messageQueue = new MessageQueue(_serverSocket,_serviceLogger);
            
            ThreadStart _threadStart = new ThreadStart(_messageQueue.HandleIncoming);
            Thread _thread = new Thread(_threadStart);
            _thread.IsBackground = true;
            _thread.Start();



        }

        public void Stop()
        {
            _serverSocket.Shutdown(SocketShutdown.Both);
            _serverSocket.Close();
        }
    }
}
