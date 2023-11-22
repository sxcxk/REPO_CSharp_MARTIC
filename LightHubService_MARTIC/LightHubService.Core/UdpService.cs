using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LightHubService.Core
{
    public class UdpService
    {
        private Socket _udpSocket;
        private IPEndPoint _ipendpoint;
        private MessageQueue _messageQueue;
        private IServiceLogger _serviceLogger;
        public UdpService(int port, IServiceLogger serviceLogger)
        {
            if (port < 1025 | port > 65536)
            {
                port = 1512;
            }
            _serviceLogger = serviceLogger;
            _ipendpoint = new IPEndPoint(IPAddress.Loopback, port);
            _udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }


        public void Start()
        {
            _udpSocket.Bind(_ipendpoint);
            _serviceLogger.LogSysInformation(DateTime.Now.ToString() + "- " + _udpSocket.LocalEndPoint.ToString() + "-Aktion: " + "gestartet");
            _messageQueue = new MessageQueue(_udpSocket, _serviceLogger);
            ThreadStart _threadStart = new ThreadStart(_messageQueue.HandleIncomingMessages);
            Thread _thread = new Thread(_threadStart);
            _thread.IsBackground = true;
            _thread.Start();


        }

        public void Stop()
        {
            _serviceLogger.LogSysInformation(DateTime.Now.ToString() + "- " + _udpSocket.LocalEndPoint.ToString() + "-Aktion: " + "gestoppt");
            _udpSocket.Shutdown(SocketShutdown.Both);
            _udpSocket.Close();
        }
    }
}
