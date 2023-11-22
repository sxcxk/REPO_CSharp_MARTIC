using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TrafficCounting.Shared
{
    public class SocketWriter
    {
        private byte[] _buffer;
        private string _request;
        private Socket _clientSocket;
        public SocketWriter(Socket clientSocket)
        {
            _clientSocket = clientSocket;
            _buffer = new byte[1024];
            _request = "";

        }

        public void SendString(string text)
        {
            _buffer = new byte[1024];
            _buffer = Encoding.ASCII.GetBytes(text.Trim('\0'));
            _clientSocket.Send(_buffer);
        }
    }
}
