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
    public class SocketReader
    {
        private byte[] msg;
        private Socket clientSocket;

        public SocketReader(Socket clientSocket)
        {
            msg = new byte[1024];
            this.clientSocket = clientSocket;
        }

        public string ReceiveString()
        {
            msg = new byte[1024];
            clientSocket.Receive(msg);
            string text = Encoding.ASCII.GetString(msg);
            text = text.Trim('\0');
            return text;
        }

        public byte[] ReceiveFile(int length)
        {
            byte[] file = new byte[length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    clientSocket.Receive(file, i, 1, SocketFlags.None);
                }
            }
            return file;
        }

    }
}
