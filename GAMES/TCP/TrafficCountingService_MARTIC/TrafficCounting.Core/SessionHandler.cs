using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TrafficCounting.Shared;

namespace TrafficCounting.Core
{
    public class SessionHandler
    {
        private Socket _clientSocket;
        private IServiceLogger _logger;
        private string _request;
        private SocketReader _socketReader;
        private SocketWriter _socketWriter;

        public SessionHandler(Socket clientSocket, IServiceLogger serviceLogger)
        {
            _request = "";
            _logger = serviceLogger;
            _clientSocket = clientSocket;
        }

        public void HandleCommunication()
        {
            _socketReader = new SocketReader(_clientSocket);
            _socketWriter = new SocketWriter(_clientSocket);
            
            while (true)
            {
                _request = "";
                _request = _socketReader.ReceiveString();
                _logger.LogRequestInformation(DateTime.Now.ToString() + "-" + _clientSocket.LocalEndPoint.ToString() + "-" + _request);

                RequestHandler requestHandler = new RequestHandler(_request);
                if (_request == "shutdown")
                {
                    Stop();
                    return;
                }

                
               _socketWriter.SendString(requestHandler.GetResponse());

            }
        }

        public void Stop()
        {
            _clientSocket.Shutdown(SocketShutdown.Both);
            _clientSocket.Close();
        }
    }
}
