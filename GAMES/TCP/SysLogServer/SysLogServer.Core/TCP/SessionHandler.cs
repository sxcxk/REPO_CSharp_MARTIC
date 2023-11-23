using SysLogServer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SysLogServer.Core
{
    public class SessionHandler
    {
        private SocketReader _socketReader;
        private SocketWriter _socketWriter;
        private string _request;
        private IServiceLogger _serviceLogger;
        private Socket _clientSocket;
        SysLogManager _syslogLogManager;
        public SessionHandler(Socket clientSocket, IServiceLogger serviceLogger)
        {
            _syslogLogManager = SysLogManager.Instance;
            _request = "";
            _serviceLogger = serviceLogger;
            _clientSocket = clientSocket;
        }

        public void HandleCommunication()
        {
            while (true)
            {
                _socketReader = new SocketReader(_clientSocket);
                _socketWriter = new SocketWriter(_clientSocket);
                _request = "";

                _request = _socketReader.ReceiveMessage();
                string _ip = _clientSocket.RemoteEndPoint.ToString();
                _serviceLogger.LogRequestInformation(DateTime.Now.ToString()+ " Request(TCP): " + _request + " from: " + _ip);

                _request+= " " + _ip;
                SysLogMessage _sysLogMessage = new SysLogMessage(_request);
                _syslogLogManager.AddMessage(_sysLogMessage);
                _serviceLogger.LogResponseInformation(DateTime.Now.ToString() + ": " + "Message was saved(TCP)");
            }
        }
    }
}
