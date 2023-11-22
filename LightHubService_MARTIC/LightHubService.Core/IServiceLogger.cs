using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHubService.Core
{
    public interface IServiceLogger
    {
        void LogSysInformation(string text);
        void LogReceivedInformation(string text);
    }
}
