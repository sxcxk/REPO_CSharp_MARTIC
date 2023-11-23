using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using HardwareInformationProtocol.Shared;

namespace HardwareInformationProtocol.Core
{
    public class MessageQueue
    {
        private Socket _serverSocket;
        IServiceLogger _logger;

        public MessageQueue(Socket serverSocket, IServiceLogger serviceLogger)
        {
            _serverSocket = serverSocket;
            _logger = serviceLogger;
        }

        public void HandleIncomingMessage()
        {

            EndPoint _remoteEp = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));
            byte[] _data;
            while (true)
            {
                _data = new byte[1024];
                SocketReader socketReader = new SocketReader(_serverSocket, _remoteEp);
                _data = socketReader.ReceiveRequest();
                _logger.LogRequestInformation(DateTime.Now.ToString() + "-" + _remoteEp.ToString() + "- request: " + Encoding.ASCII.GetString(_data).Trim('\0'));

            }
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
                    _logger.LogSysInformation("Error: " + ex.Message);
                }
            }
        }
    }
}
