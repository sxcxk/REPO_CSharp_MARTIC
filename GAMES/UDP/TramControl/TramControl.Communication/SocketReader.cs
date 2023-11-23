using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TramControl.Communication
{
   public class SocketReader
    {
        private Socket _clientSocket;
        public SocketReader(Socket clientSocket)
        {
            _clientSocket = clientSocket;
        }

        public byte[] ReceiveData()
        {
            byte[] data = new byte[1024];
            _clientSocket.Receive(data);
            return data;
        }
    }
}
