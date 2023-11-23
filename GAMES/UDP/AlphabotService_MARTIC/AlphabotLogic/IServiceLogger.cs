using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabotLogic
{
    public interface IServiceLogger
    {
        void LogInformation(string text);
        void LogReceivedCmdsInformation(string text);
    }
}
