using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseServiceLib
{
    public interface IServiceLogger
    {
        void LogRequestInformation(string text);
        void LogServiceInformation(string text);
    }
}
