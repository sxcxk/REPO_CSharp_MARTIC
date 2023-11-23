using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MorseServiceLib
{
    public class TcpService
    {
        #region Fields and Properties
        private Socket serverSocket;
        private IPAddress ip;
        private IPEndPoint ep;
        private int port;
        private ClientHandler clientHandler;
        private byte[] msg;
        private IServiceLogger serviceLogger;
        #endregion

        #region Methods
        public void Start()
        {
            serverSocket.Bind(ep);
            serverSocket.Listen(10);
            DateTime d = DateTime.Now;
            serviceLogger.LogServiceInformation(d.ToString() + ", Gestartet");

            while (true)
            {
                this.clientHandler = new ClientHandler(serverSocket, serviceLogger);
                clientHandler.AcceptClients();
            }
            
        }
        #endregion

        #region Constructors
        public TcpService(IPAddress ip, int port, IServiceLogger serviceLogger)
        {
            this.serviceLogger = serviceLogger;
            if (port > 65536 || port < 1024)
            {
                this.ip = IPAddress.Loopback;
                this.port = 2412;

            }
            else
            {
                this.ip = ip;
                this.port = port;
            }

            this.ep = new IPEndPoint(this.ip, this.port);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.msg = new byte[1024];

        }
        #endregion
    }
}
