using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using ConstructionService.Shared;

namespace Construction.Service.Core
{
    public class SessionHandler
    {
        private string request;
        private string response;
        private Socket clientSocket;
        private IServiceLogger serviceLogger;
        private SocketReader socketReader;
        private SocketWriter socketWriter;
        private RequestHandler requestHandler;
        public SessionHandler(Socket clientSocket, IServiceLogger serviceLogger)
        {
            this.serviceLogger = serviceLogger;
            this.clientSocket = clientSocket;
        }

        public void HandleCommunication()
        {
            serviceLogger.LogServiceInformation( DateTime.Now + " Connected to: " + clientSocket.RemoteEndPoint.ToString());

            socketWriter = new SocketWriter(clientSocket);
            socketReader = new SocketReader(clientSocket);

            request = socketReader.ReceiveString();
            requestHandler = new RequestHandler(request);
            string[] requestparts = request.Split(' ');

            if (requestparts[0] == "find")
            {
                response = requestHandler.GetResponse();

                socketWriter.SendString(response);
            }

            if (requestparts[0] == "download")
            {
                byte[] file;
                string[] receiveFiles = new string[requestparts.Length - 1]; 
                for (int i = 1; i < requestparts.Length; i++)
                {
                    receiveFiles[i - 1] = requestparts[i];
                }

                for (int i = 0; i < receiveFiles.Length; i++)
                {
                    request = socketReader.ReceiveString();
                    int length = Convert.ToInt32(request);
                    file = socketReader.ReceiveFile(length);

                    File.WriteAllBytes(@"Z:\ConstructionZoneService\ConstructionService.Cli.Server\bin\Debug\" + receiveFiles[i], file);
                    if (File.Exists(@"Z:\ConstructionZoneService\ConstructionService.Cli.Server\bin\Debug\" + receiveFiles[i]))
                    {
                        socketWriter.SendString("OK");
                    }
                    else
                    {
                        socketWriter.SendString("FAIL");
                    }
                    
                }

            }


        }
    }
}
