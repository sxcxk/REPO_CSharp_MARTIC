using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Construction.Service.Core;
namespace ConstructionService.Cli.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpService service = new TcpService(2004, new ConsoleLogger());
            service.Start();
        }
    }
}
