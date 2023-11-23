using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TramControl.Communication;

namespace TramControl.Service.Core
{
    public class SessionHandler
    {
        private Socket _clientSocket;
        private ILogWriter _logger;

        public SessionHandler(Socket clientSocket,ILogWriter logWriter)
        {
            _clientSocket = clientSocket;
            _logger = logWriter;
        }

        public void HandleCommunication()
        {
            while (true)
            {
                string dataText = "";
                _logger.LogSystemInfo(DateTime.Now.ToString() + "|" + "|waiting for request on " + _clientSocket.LocalEndPoint.ToString());
                byte[] data = new byte[1024];
                SocketReader socketReader = new SocketReader(_clientSocket);
                data = socketReader.ReceiveData();
                dataText = Encoding.ASCII.GetString(data).Trim('\0');

                _logger.LogSystemInfo(DateTime.Now.ToString() + "|" + "|received from" + _clientSocket.RemoteEndPoint.ToString() + "|" +dataText);
                RequestHandler requestHandler = new RequestHandler(data);

            }
        }

        public void Stop()
        {
            try
            {
                if (_clientSocket != null)
                {
                    _clientSocket.Shutdown(SocketShutdown.Both);
                    _clientSocket.Close();
                }
            }
            catch (Exception ex)
            {
                _logger.LogSystemInfo("Error(SessionHandler): " + ex.Message);
            }
        }
    }
}
