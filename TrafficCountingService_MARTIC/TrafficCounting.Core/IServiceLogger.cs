using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficCounting.Core
{
    public interface IServiceLogger
    {
        void LogSystemInformation(string text);
        void LogRequestInformation(string text);

    }
}
