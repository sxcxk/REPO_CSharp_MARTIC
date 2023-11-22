using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareInformationProtocol.Core
{
    public interface  IServiceLogger
    {
        void LogRequestInformation(string text);
        void LogSysInformation(string text);
    }
}
