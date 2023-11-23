using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TramControl.Communication
{
    public class SocketWriter
    {
        private Socket _clientSocket;

        public SocketWriter(Socket clientSocket)
        {
            _clientSocket = clientSocket;
        }

        public void SendData(byte[] data)
        {
            _clientSocket.Send(data);
        }
    }
}
