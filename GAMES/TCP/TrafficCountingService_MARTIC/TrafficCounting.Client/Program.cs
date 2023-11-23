using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TrafficCounting.Shared;

namespace TrafficCounting.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            IPAddress iPAddress = IPAddress.Loopback;
            IPEndPoint iPEndPoint;
            int _port = 1407;
            
            Console.WriteLine("IP:");
            string ip = Console.ReadLine();
            if (CheckIP(ip))
            {
                iPAddress = IPAddress.Parse(ip);
            }


            Console.WriteLine("Port:");
            string port = Console.ReadLine();
            if (CheckPort(port)) 
            {
                _port = Convert.ToInt32(port);
            }

            iPEndPoint = new IPEndPoint(iPAddress, _port);   
            Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _clientSocket.Connect(iPEndPoint);
            SocketWriter socketWriter = new SocketWriter(_clientSocket);
            SocketReader socketReader = new SocketReader(_clientSocket);
            while (true)
            {
                string cmd;
                Console.Write("tfc//: ");
                cmd = Console.ReadLine();
                Console.Clear();
                socketWriter.SendString(cmd);

                Console.WriteLine("Response: " + socketReader.ReceiveString());
            }

        }

        public static bool CheckIP(string ip)
        {
            IPAddress ipAddress;
            string[] ipBytes = ip.Split('.');
            if (ipBytes.Length == 4)
            {
                if (IPAddress.TryParse(ip,out ipAddress))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPort(string port)
        {
            int _port = 0;
            if (Int32.TryParse(port,out _port))
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
