using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficCounting.Core
{
    public class TcpService
    {
        private Socket _serverSocket;
        private IPEndPoint _serverEndPoint;
        private IServiceLogger _logger;
        private int _port;

        public TcpService(int port, IServiceLogger serviceLogger)
        {
            _logger = serviceLogger;
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (port<1024 || port > 65536)
            {
                _port = 1410;
            }
        _serverEndPoint = new IPEndPoint(IPAddress.Loopback, port);
        }

        public void Start()
        {
            _serverSocket.Bind(_serverEndPoint);
            _logger.LogSystemInformation(DateTime.Now.ToString() + "-" + _serverSocket.LocalEndPoint.ToString() + "- Server started ...");
            _serverSocket.Listen(10);

            ClientHandler clientHandler = new ClientHandler(_serverSocket, _logger);
            ThreadStart threadStart = new ThreadStart(clientHandler.AcceptClients);
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
                    _logger.LogSystemInformation(ex.Message);
                }
            }
        }
    }
}
