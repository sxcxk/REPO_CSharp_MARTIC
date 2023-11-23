using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Construction.Service.Core
{
   public interface IServiceLogger
    {
        void LogRequestInformation(string text);
        void LogServiceInformation(string text);
    }
}
