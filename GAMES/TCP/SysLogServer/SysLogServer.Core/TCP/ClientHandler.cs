using SysLogServer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysLogServer.Core
{
    public class ClientHandler
    {
        private IServiceLogger _serviceLogger;
        private Socket _clientSocket;
        private Socket _serverSocket;
        private SessionHandler _sessionHandler;

        public ClientHandler(Socket serverSocket, IServiceLogger serviceLogger)
        {
            _serverSocket = serverSocket;
            _serviceLogger = serviceLogger;
        }

        public void AcceptClients()
        {
            _clientSocket = _serverSocket.Accept();
            _serviceLogger.LogRequestInformation("Client connected(TCP): " + _clientSocket.RemoteEndPoint.ToString() + " " + DateTime.Now.ToString());
            _sessionHandler = new SessionHandler(_clientSocket,_serviceLogger);
            
            ThreadStart _threadStart = new ThreadStart(_sessionHandler.HandleCommunication);
            Thread _thread = new Thread(_threadStart);
            _thread.IsBackground = true;
            _thread.Start();

        }
    }
}
