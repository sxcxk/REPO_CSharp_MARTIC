using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using TramControl.Communication;
using System.Threading;

namespace TramControl.Service.Core
{
    public class TcpService
    {
        private IPAddress _ip;
        private int _port;
        private Socket _serverSocket;
        private IPEndPoint _ipEndPoint;
        private ILogWriter _logger;

        public TcpService(IPAddress iPAddress, int port, ILogWriter logWriter)
        {
            _logger = logWriter;
            _ip = iPAddress;
            _port = port;
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _ipEndPoint = new IPEndPoint(_ip, _port);
        }

        public void Start()
        {
            _serverSocket.Bind(_ipEndPoint);
            _serverSocket.Listen(10);
            _logger.LogSystemInfo(DateTime.Now.ToString() + "|" +  "|started server" + _serverSocket.LocalEndPoint.ToString());

            ClientHandler clientHandler = new ClientHandler(_serverSocket, _logger);

            ThreadStart threadStart = new ThreadStart(clientHandler.AcceptClients);
            Thread thread = new Thread(threadStart);
            thread.IsBackground = true;
            thread.Start();
            thread.Join();
            
        }

        public void Stop()
        {
            try
            {
                if (_serverSocket!= null)
                {
                    _serverSocket.Shutdown(SocketShutdown.Both);
                    _serverSocket.Close();
                }
            }
            catch (Exception ex )
            {
                _logger.LogSystemInfo("Error(TcpService): " + ex.Message);
            }
        }
    }
}
