using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightHubService.Core;

namespace LightHubService.Server.Gui
{
   public class Program
    {
        static void Main(string[] args)
        {
            UdpService _udpService;
            int _port = 0;
            _udpService = new UdpService(_port, new ConsoleLogger());
            string _input = "";
            while (true)
            {
                Console.WriteLine("Start(1),Stop(2):");
                _input = Console.ReadLine();
                if (_input.Contains("1"))
                {
                    _udpService.Start();
                }

                if (_input.Contains("2"))
                {
                    _udpService.Stop();
                }
            }
        }

    }
}
