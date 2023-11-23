using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MorseServiceLib
{
    public class ClientHandler
    {
        #region Fields and Properties
        private Socket serverSocket;
        private Socket clientSocket;
        private SessionHandler sessionHandler;
        private IServiceLogger serviceLogger;
        #endregion

        #region Methods
        public void AcceptClients()
        {
            clientSocket = serverSocket.Accept();
            DateTime d = DateTime.Now;
            serviceLogger.LogRequestInformation(d.ToString() + ", "  + clientSocket.RemoteEndPoint.ToString());
            sessionHandler = new SessionHandler(clientSocket,serviceLogger);
            sessionHandler.HandleConnection();
        }

        public void Stop()
        {
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
        #endregion

        #region Constructors
        public ClientHandler(Socket serverSocket, IServiceLogger serviceLogger)
        {
            this.serviceLogger = serviceLogger;
            this.serverSocket = serverSocket;
        }
        #endregion
    }
}
