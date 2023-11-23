using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TrafficCounting.Shared
{
    public class SocketReader
    {
        private byte[] _buffer;
        private string _request; 
        private Socket _clientSocket;
        public SocketReader(Socket clientSocket)
        { 
            _clientSocket = clientSocket;
            _buffer = new byte[1024];
            _request = "";

        }

        public string ReceiveString()
        {
            _buffer = new byte[1024];
            _request = "";
            _clientSocket.Receive(_buffer);
            _request = Encoding.ASCII.GetString(_buffer).Trim('\0');
            return _request;
        }




    }
}
