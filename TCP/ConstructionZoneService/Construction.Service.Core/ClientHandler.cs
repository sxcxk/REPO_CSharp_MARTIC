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
  public  class ClientHandler
    {
        private Socket serverSocket;
        private Socket clientSocket;
        private IServiceLogger serviceLogger;
        private SessionHandler sessionHandler;


        public void AcceptClients()
        {
            while (true)
            {
                clientSocket = serverSocket.Accept();
                sessionHandler = new SessionHandler(clientSocket, serviceLogger);
                ThreadStart ts = new ThreadStart(sessionHandler.HandleCommunication);
                Thread t = new Thread(ts);
                t.IsBackground = true;
                t.Start();
            }
        }



        public ClientHandler(Socket serverSocket, IServiceLogger serviceLogger)
        {
            this.serviceLogger = serviceLogger;
            this.serverSocket = serverSocket;
        }
    }
}
