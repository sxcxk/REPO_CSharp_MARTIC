using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HardwareInformationProtocol.Shared
{
   public class SocketReader
    {
        private Socket _serverSocket;
        private byte[] _data;
        private EndPoint _remoteEp;
        public SocketReader(Socket serverSocket, EndPoint remoteEp)
        {
            _serverSocket = serverSocket;
            _remoteEp = remoteEp;
        }

        public byte[] ReceiveRequest()
        {
            _data = new byte[1024];
            _serverSocket.ReceiveFrom(_data, ref _remoteEp);
            return _data;

        }
    }
}
