using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace MorseServiceLib
{
    public class SocketWriter
    {
        #region Fields and Properties
        private byte[] msg;
        private Socket clientSocket;
        #endregion

        #region Methods
        public void SendMessage(string message) 
        {
            msg = Encoding.ASCII.GetBytes(message);
            clientSocket.Send(msg);
        }
        #endregion

        #region Constructor
        public SocketWriter(Socket clientSocket)
        {
            msg = new byte[1024];
            this.clientSocket = clientSocket;
        }
        #endregion
    }
}
