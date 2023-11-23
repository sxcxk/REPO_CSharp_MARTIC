using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace MorseServiceLib
{
   public class SocketReader
    {

        #region Fields and Properties
        private byte[] msg;
        private Socket clientSocket;
        #endregion

        #region Methods
        public string ReceiveString()
        {
            string receivedString = "";

            clientSocket.Receive(msg);
            return receivedString = Encoding.ASCII.GetString(msg);
        }
        #endregion

        #region Constructor

        public SocketReader(Socket clientSocket)
        {
            msg = new byte[1024];
            this.clientSocket = clientSocket;
        }
        #endregion
    }
}
