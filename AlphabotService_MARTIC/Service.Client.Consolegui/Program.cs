using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Service.Client.Consolegui
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            byte[] _data;
            Socket _clientSocket;
            IPAddress _clientIp;
            IPEndPoint _clientep;
            int _port;
            string _request = "";
            while (true)
            {
                _data = new byte[1024];
                _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                do
                {
                    Console.Clear();
                    Console.WriteLine("Geben Sie eine IP an:");
                    string _ip = Console.ReadLine();
                    if (CheckIP(_ip))
                    {
                        _clientIp = IPAddress.Parse(_ip);
                        break;
                    }
                } while (true);

                Console.WriteLine("Port: ");
                _port = Convert.ToInt32(Console.ReadLine());
                _clientep = new IPEndPoint(_clientIp,_port);

                Console.WriteLine();
                Console.WriteLine("Geben Sie das erste Byte ein:");
                string _byte1 = Console.ReadLine();

                Console.WriteLine("Geben Sie das zweite Byte ein:");
                string _byte2 = Console.ReadLine();

                _request = _byte1 + " " + _byte2;
                _data = Encoding.ASCII.GetBytes(_request);
                _clientSocket.SendTo(_data, _clientep);
                
            }
        }

        public static bool CheckIP(string ip)
        {
            string[] bytes = ip.Split('.');
            if (bytes.Length == 4)
            {
                return true;
            }
            return false;
        }
    }
}
