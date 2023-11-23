using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficCounting.Core
{
    public class ClientHandler
    {
        private Socket _clientSocket;
        private Socket _serverSocket;
        private IServiceLogger _logger;

        public ClientHandler(Socket serverSocket, IServiceLogger serviceLogger)
        {
            _logger = serviceLogger;
            _serverSocket = serverSocket;
        }

        public void AcceptClients()
        {
            _clientSocket = _serverSocket.Accept();
            _logger.LogSystemInformation(DateTime.Now.ToString() + "-" + _clientSocket.LocalEndPoint.ToString() + "-Conneceted");
            SessionHandler sessionHandler = new SessionHandler(_clientSocket,_logger);

            ThreadStart threadStart = new ThreadStart(sessionHandler.HandleCommunication);
            Thread thread = new Thread(threadStart);
            thread.IsBackground = true;
            thread.Start();
            thread.Join();
            Stop();

        }
        public void Stop()
        {

            if (_serverSocket != null)
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
