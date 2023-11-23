using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TramControl.Communication;

namespace TramControl.Service.Core
{
    public class ClientHandler
    {
        private Socket _serverSocket;
        private Socket _clientSocket;
        private ILogWriter _logger;


        public ClientHandler(Socket serverSocket,ILogWriter logWriter)
        {
            _logger = logWriter;
            _serverSocket = serverSocket;
        }

        public void AcceptClients()
        {
            _clientSocket = _serverSocket.Accept();
            _logger.LogSystemInfo(DateTime.Now.ToString() + "|" + "|client connected to" + _serverSocket.RemoteEndPoint.ToString());

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
            try
            {
                if (_serverSocket != null)
                {
                    _serverSocket.Shutdown(SocketShutdown.Both);
                    _serverSocket.Close();
                }
            }
            catch (Exception ex)
            {
                _logger.LogSystemInfo("Error(ClientHandler): " + ex.Message);
            }
        }
    }
}
