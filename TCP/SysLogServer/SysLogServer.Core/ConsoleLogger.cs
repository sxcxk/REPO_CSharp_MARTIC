using SysLogServer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogServer.Core
{
    public class ConsoleLogger : IServiceLogger
    {
        public void LogRequestInformation(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
        }

        public void LogResponseInformation(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
        }
    }
}
