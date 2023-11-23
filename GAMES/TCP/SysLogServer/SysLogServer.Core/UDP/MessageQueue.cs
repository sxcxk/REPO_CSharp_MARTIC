using SysLogServer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SysLogServer.Core.UDP
{
    public class MessageQueue
    {
        private SysLogManager _sysLogManager;
        private SocketReader _socketReader;
        private EndPoint _remoteEp;
        private Socket _serverSocket;
        private IServiceLogger _serviceLogger;
        public MessageQueue(Socket serverSocket, IServiceLogger serviceLogger)
        {
            _serverSocket = serverSocket;
            _serviceLogger = serviceLogger;
            _sysLogManager = SysLogManager.Instance;
        }

        public void HandleIncoming()
        {
            string _request;
            _remoteEp = (EndPoint)new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                byte[] _data = new byte[1024];
                _request = "";

                
                _socketReader = new SocketReader(_serverSocket, _remoteEp);
                _serviceLogger.LogRequestInformation("Client connected(UDP): " + _remoteEp.ToString());

                _request = _socketReader.ReceiveFromMessage();
                _serviceLogger.LogRequestInformation("Request received(UDP): " + _request + " from: " + _remoteEp.ToString());

                _request += " " + _remoteEp.ToString();
                SysLogMessage _sysLogMessage = new SysLogMessage(_request);
                _sysLogManager.AddMessage(_sysLogMessage);
                _serviceLogger.LogResponseInformation(DateTime.Now.ToString() + " Message was saved(UDP)");
            }
        }
    }
}
