using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogServer.Shared
{
    public interface IServiceLogger
    {
        void LogRequestInformation(string text);
        void LogResponseInformation(string text);
    }
}
