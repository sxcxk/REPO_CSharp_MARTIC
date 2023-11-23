using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MorseServiceLib
{
   public class SessionHandler
    {
        #region Fields and Properties
        private Socket clientSocket;
        private string request;
        private IServiceLogger serviceLogger;        
        private SocketWriter sw;
        private SocketReader sr;
        private McpRequestHandler requestHandler;

        #endregion

        #region Methods

        public void Stop()
        {
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
        public void HandleConnection()
        {
            string response = "";
            DateTime d = DateTime.Now;
            
            sr = new SocketReader(clientSocket);
            sw = new SocketWriter(clientSocket);

            request = sr.ReceiveString().Trim('\0');
            if (request.ToLower() == "exit")
            {
                Stop();
            }

            if (request.Substring(0, 12).Trim('\0') == "translate2mc") 
            {
                d = DateTime.Now;
                request = request.Substring(13);
                serviceLogger.LogRequestInformation(d.ToString() + ", " + clientSocket.RemoteEndPoint.ToString() + " Request: " + request);

                requestHandler = new McpRequestHandler(request);
                response = requestHandler.Translate2MC();
                sw.SendMessage(response);
                return;
            }

            if (request.Substring(0, 15).Trim('\0') == "translate2latin")
            {
                d = DateTime.Now;
                request = request.Substring(16);
                serviceLogger.LogRequestInformation(d.ToString() + ", " + clientSocket.RemoteEndPoint.ToString() + " Request: " + request);

                requestHandler = new McpRequestHandler(request);
                response = requestHandler.Translate2Latin();
                sw.SendMessage(response);
                return;
            }

        }
        #endregion

        #region Constructors
        public SessionHandler(Socket clientSocket, IServiceLogger serviceLogger)
        {
            this.serviceLogger = serviceLogger;
            request = "";
            this.clientSocket = clientSocket;
        }
        #endregion
    }
}
