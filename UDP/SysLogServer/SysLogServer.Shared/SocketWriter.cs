using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SysLogServer.Shared
{
    public class SocketWriter
    {
        private byte[] _msg;
        private Socket _clientSocket;
        private EndPoint _remoteEp;
        public SocketWriter(Socket clientSocket)
        {
            _clientSocket = clientSocket;
            _msg = new byte[1024];
        }

        public SocketWriter(Socket clientSocket, EndPoint remoteEp)
        {
            _clientSocket = clientSocket;
            _remoteEp = remoteEp;
            _msg = new byte[1024];
        }


        public void SendMessageTo(string message)
        {
            _msg = new byte[1024];
            _msg = Encoding.ASCII.GetBytes(message);
            _clientSocket.SendTo(_msg,_remoteEp);

        }

        public void SendMessage(string msg)
        {
            _msg = Encoding.ASCII.GetBytes(msg.Trim('\0'));
            _clientSocket.Send(_msg);
        }
    }
}
