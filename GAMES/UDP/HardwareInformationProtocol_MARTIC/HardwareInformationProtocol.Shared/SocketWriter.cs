using System.Net;
using System.Net.Sockets;

serusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareInformationProtocol.Shared
{
    public class SocketWriter
    {
        private Socket _clientSocket;
        private EndPoint _remoteEp;
        public SocketWriter(Socket clientSocket, EndPoint remoteEp)
        {
            _clientSocket = clientSocket;
            _remoteEp = remoteEp;
        }


        public void SendRequest(byte[] data)
        {
            _clientSocket.SendTo(data, _remoteEp);
        }
    }
}
