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
    public class TcpService
    {
        private Socket _serverSocket;
        private ClientHandler _clientHandler;
        private IPEndPoint _tcpEndPoint;
        private IServiceLogger _serviceLogger;

        public TcpService(int port, IServiceLogger serviceLogger)
        {
            if (port < 1025 || port > 65536) 
            {
                port = 8080;
            }
            _serviceLogger = serviceLogger;
            _tcpEndPoint = new IPEndPoint(IPAddress.Loopback, port);
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            _serverSocket.Bind(_tcpEndPoint);
            _serverSocket.Listen(10);
            _serviceLogger.LogRequestInformation("Server started(TCP): " + DateTime.Now.ToString());
            _clientHandler = new ClientHandler(_serverSocket, _serviceLogger);

            ThreadStart _threadStart = new ThreadStart(_clientHandler.AcceptClients);
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
