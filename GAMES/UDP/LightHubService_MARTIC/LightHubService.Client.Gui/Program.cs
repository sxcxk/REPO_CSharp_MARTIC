using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LightHubService.Client.Gui
{
   public class Program
    {
        static void Main(string[] args)
        {
            IPAddress _clientIP = IPAddress.Loopback;
            int _port = 0;

            Console.WriteLine("Geben Sie eine IP ein:");
            string inputIp = Console.ReadLine();
            if (ValidIP(inputIp))
            {
                _clientIP = IPAddress.Parse(inputIp);
            }

            Console.WriteLine("Geben Sie einen Port an: ");
            int inputPort = Convert.ToInt32(Console.ReadLine());
            if (inputPort < 1025 || inputPort > 65536)
            {
                _port = 1512;
            }
            else
            {
                _port = inputPort;
            }

            Run(_port, _clientIP);
        }

        public static bool ValidIP(string ip)
        {
            IPAddress address = IPAddress.Loopback;
            string[] bytes = ip.Split('.');
            if (bytes.Length ==4)
            {
                if (IPAddress.TryParse(ip,out address))
                {
                    return true;
                }
            }
            return false;
        }

        public static void Run(int port, IPAddress ip)
        {
            byte[] data;
            Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint _clientIpEndPoint = new IPEndPoint(ip, port);
            while (true)
            {
                data = new byte[2];
                Console.WriteLine("Geben Sie das 1. Byte ein:");
                data[0] = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Geben Sie das 2.Byte ein:");
                data[1] = Convert.ToByte(Console.ReadLine());

                _clientSocket.SendTo(data, _clientIpEndPoint);

            }
        }
    }
}
