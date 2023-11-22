using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LightHubService.Core
{
   public class MessageQueue
    {
        private IServiceLogger _serviceLogger;
        private Socket _serviceSocket;
        private string _request;
        private LightHubRequestHandler _requesthandler;
        private List<LightHubInformation> _listOfLightHubInformation = null;

        public List<LightHubInformation> ListOfLightHubInformation
        {
            get
            {
                if (_listOfLightHubInformation == null)
                {
                    _listOfLightHubInformation = new List<LightHubInformation>();
                  
                }
                return _listOfLightHubInformation;
            }
        }




        public MessageQueue(Socket serviceSocket, IServiceLogger serviceLogger)
        {
            _request = "";
            _serviceSocket = serviceSocket;
            _serviceLogger = serviceLogger;
            _listOfLightHubInformation = new List<LightHubInformation>();
        }

        public void HandleIncomingMessages()
        {
            byte[] data;
            EndPoint _remoteEp = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));
            while (true)
            {
                data = new byte[1024];
                _serviceSocket.ReceiveFrom(data, ref _remoteEp);
                _serviceLogger.LogSysInformation(DateTime.Now.ToString() + "- " + _remoteEp.ToString() + "-Aktion: " + "verbunden");

                _requesthandler = new LightHubRequestHandler(data);
                LightHubInformation _lightHubInformation = _requesthandler.GetResponse();
                AddLightHubInformation(_lightHubInformation);

                _serviceLogger.LogReceivedInformation(DateTime.Now.ToString() + "\n" + _lightHubInformation.ToString());

            }
        }


        public void AddLightHubInformation(LightHubInformation lightHubInformation)
        {
            _listOfLightHubInformation.Add(lightHubInformation);
        }
    }
}
