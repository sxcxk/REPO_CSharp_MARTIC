using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramControl.Service.Core
{
    public class RequestHandler
    {
        private byte[] _data;
        public RequestHandler(byte[] data)
        {
            _data = data;
        }

        public TramWayInformation GetResponse()
        {
            TramWayInformation tramWayInformation = new TramWayInformation(_data);
            return tramWayInformation;


        }
    }
}
