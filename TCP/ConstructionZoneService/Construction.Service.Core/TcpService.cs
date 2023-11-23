using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Construction.Service.Core
{
  public  class TcpService
    {
        private IPAddress ip;
        private IPEndPoint ep;
        private int port;
        private Socket serverSocket;
        private ClientHandler clientHandler;
        private IServiceLogger serviceLogger;



        public TcpService(int port, IServiceLogger serviceLogger)
        {
            if (port<1025 || port >65536)
            {
                port = 2004;
            }
            ip = IPAddress.Loopback;
            ep = new IPEndPoint(ip, port);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.serviceLogger = serviceLogger;
        }


        public void Start()
        {
            serviceLogger.LogServiceInformation(DateTime.Now + " Server Starting...."); 
            serverSocket.Bind(ep);
            serverSocket.Listen(10);
            while (!(serverSocket.Connected))
            {
                clientHandler = new ClientHandler(serverSocket, serviceLogger);
                ThreadStart ts = new ThreadStart(clientHandler.AcceptClients);
                Thread t = new Thread(ts);
                t.IsBackground = true;
                t.Start();
            }
            Stop();

        }

        public void Stop()
        {
            serverSocket.Shutdown(SocketShutdown.Both);
            serverSocket.Close();
        }
    }
}
