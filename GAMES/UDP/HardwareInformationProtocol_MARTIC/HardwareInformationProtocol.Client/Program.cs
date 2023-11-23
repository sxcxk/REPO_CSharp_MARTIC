using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using HardwareInformationProtocol.Shared;

namespace HardwareInformationProtocol.Client
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Run()
        {
            IPAddress _ip = IPAddress.Loopback;
            int _port = 1609;
            Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint _ep;
            SocketWriter _socketWriter;
            string input = "";

            Console.WriteLine("IP:");
            input = Console.ReadLine();
            if (CheckIP(input))
            {
                _ip = IPAddress.Parse(ip);
            }

            Console.WriteLine("Port:");
            input = Console.ReadLine();
            if (CheckIP(input))
            {
                _port = Convert.ToInt32(input);
            }

            _ep = new IPEndPoint(_ip, _port);

            byte[] data = new byte[1024];
            int _byte;
            while (true)
            {
                data = new byte[1024];
                Console.WriteLine("Geben sie das 1. byte ein:");
                _byte = Convert.ToInt32(Console.ReadLine());
                data[0] = Convert.ToByte(_byte);

                Console.WriteLine("Geben sie das 2. byte ein:");
                _byte = Convert.ToInt32(Console.ReadLine());
                data[1] = Convert.ToByte(_byte);


                Console.WriteLine("Geben sie das 3. byte ein:");
                _byte = Convert.ToInt32(Console.ReadLine());
                data[2] = Convert.ToByte(_byte);

                //Console.WriteLine("Geben sie eine nachricht ein:");
                //char[] text = Console.ReadLine().ToCharArray();
                //data += (byte)text;

            }

        }

        public static bool CheckIP(string ip)
        {
            IPAddress _ip = null;
            if (ip.Split('.').Length == 4) 
            {
                if (IPAddress.TryParse(ip, out _ip))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPort(string port)
        {
            int _port = 0;
            if (Int32.TryParse(port, out _port))
            {
                if (_port > 1024 || _port < 65536) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
