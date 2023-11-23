using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SysLogServer.Shared
{

    public class SocketReader
    {
        private byte[] _msg;
        private EndPoint _remoteEp;
        private Socket _clientSocket;



        public SocketReader(Socket clientSocket, EndPoint remoteEp)
        {
            _clientSocket = clientSocket;
            _remoteEp = remoteEp;

        }

        public string ReceiveFromMessage() //with ref call
        {
            _msg = new byte[1024];
            string message = "";
            _clientSocket.ReceiveFrom(_msg, ref _remoteEp);
            message = Encoding.ASCII.GetString(_msg).Trim('\0');
            return message;
        }

        public SocketReader(Socket clientSocket)
        {
            _msg = new byte[1024];
            _clientSocket = clientSocket;
        }

        public string ReceiveMessage()
        {
            string _text = "";
            _msg = new byte[1024];
            _clientSocket.Receive(_msg);
            _text = Encoding.ASCII.GetString(_msg).Trim('\0');
            return _text;
        }
    }
}
