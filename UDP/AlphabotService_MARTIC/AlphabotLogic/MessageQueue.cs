using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphabotLogic
{
    public class MessageQueue
    {
        private Socket _socketQueue;
        private EndPoint _remoteEp;
        private byte[] _data;
        private string _request;
        private AlphabotRequestHandler _alphabotRequestHandler;
        private List<AlphabotInformation> _listAlphabotInformation = null;
        private IServiceLogger _logger;


        public List<AlphabotInformation> ListAlphabotInformation
        {
           get
            {
                if (_listAlphabotInformation == null)
                {
                    _listAlphabotInformation = new List<AlphabotInformation>();
                    return _listAlphabotInformation;
                }
            return _listAlphabotInformation;
            }
        }
        public MessageQueue(Socket socket, IServiceLogger logger)
        {
            _socketQueue = socket;
            _request = "";
            _logger = logger;
        }

        public void HandleIncomingMessages()
        {

             _remoteEp = (EndPoint) new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {

                _data = new byte[1024];
                _socketQueue.ReceiveFrom(_data, ref _remoteEp);
                _logger.LogReceivedCmdsInformation("Client connected: " + _remoteEp.ToString());
                _request = Encoding.ASCII.GetString(_data);

                _alphabotRequestHandler = new AlphabotRequestHandler(_request);

                AlphabotInformation _alphabotInformation = _alphabotRequestHandler.GetResponse();
                DateTime timestamp = DateTime.Now;

                AddAlphabotInfo(_alphabotInformation);
                string response = timestamp.ToString() + " " + _remoteEp.ToString() + "\n" + _alphabotInformation.ToString();

                _logger.LogReceivedCmdsInformation(DateTime.Now.ToString() + "\n" + response);
            }
        }

        public void AddAlphabotInfo(AlphabotInformation a)
        {
            ListAlphabotInformation.Add(a);
        }

    }
}
