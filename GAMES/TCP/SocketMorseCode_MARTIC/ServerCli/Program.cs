using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorseServiceLib;
using System.Net;
using System.Net.Sockets;

namespace ServerCli
{
   public class Program
    {
        static void Main(string[] args)
        {
            TcpService service = new TcpService(IPAddress.Parse("127.0.0.1"), 2412, new ConsoleLogger());
            service.Start();
            Console.ReadKey();
        }
    }
}
