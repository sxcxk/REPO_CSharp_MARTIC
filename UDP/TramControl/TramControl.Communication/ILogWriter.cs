using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramControl.Communication
{
    public interface ILogWriter
    {
        void LogRequest(string text);
        void LogResponse(string text);
        void LogSystemInfo(string text);


    }
}
