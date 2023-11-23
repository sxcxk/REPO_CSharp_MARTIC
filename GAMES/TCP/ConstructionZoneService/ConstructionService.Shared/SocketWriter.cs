using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ConstructionService.Shared
{
   public class SocketWriter
    {
        private byte[] msg;
        private Socket clientSocket;

        public SocketWriter(Socket clientSocket)
        {
            msg = new byte[1024];
            this.clientSocket = clientSocket;
        }


        public void SendString(string text)
        {
            msg = new byte[1024];
            msg = Encoding.ASCII.GetBytes(text.Trim('\0'));
            clientSocket.Send(msg);
        }


        public void SendFile(byte[] file)
        {
            for (int i = 0; i < file.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    clientSocket.Send(file, i, 1, SocketFlags.None);
                }
            }
        }

    }
}
