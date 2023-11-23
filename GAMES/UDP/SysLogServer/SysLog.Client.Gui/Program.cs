using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SysLogServer.Shared;

namespace SysLog.Client.Gui
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select server type Tcp(tcp)/Udp(udp):");
                string type = Console.ReadLine();
                if (type.ToLower().Contains("tcp"))
                {
                    RunTCP();
                }

                if (type.ToLower().Contains("udp"))
                {
                    RunUDP();
                }
                else
                {
                    Console.WriteLine("Error: Server type unknown");
                }
            }
        }

        public static void RunTCP()
        {
            SocketWriter _socketWriter;
            IPAddress _ip;
            IPEndPoint _clientIpEndPoint;
            int _port = 8080;

            Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _socketWriter = new SocketWriter(_clientSocket);


            Console.WriteLine("IP:");
            _ip = CheckIP(Console.ReadLine());
            Console.WriteLine("Port:");
            _port = Convert.ToInt32(Console.ReadLine());

            _clientIpEndPoint = new IPEndPoint(_ip, _port);

            _clientSocket.Connect(_clientIpEndPoint);
            while (true)
            {
                byte[] _data = new byte[1024];
                Console.WriteLine("( \"BEISPIEL: \"+\"\\n\" + \"<Number> + (Message) \" +\"\\n\"+ \"GEBEN SIE EINE NACHRICHT EIN:\")");

                _socketWriter.SendMessage(Console.ReadLine());
            }


        }


        public static void RunUDP()
        {
            Socket _clientSocket;
            IPEndPoint _remoteIpEp; 
            SocketWriter _socketWriter;
            IPAddress _ip;
            int _port = 8080;

            Console.WriteLine("IP:");
            _ip = CheckIP(Console.ReadLine());
            Console.WriteLine("Port:");
            _port = Convert.ToInt32(Console.ReadLine());

            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _remoteIpEp = new IPEndPoint(_ip, _port);
            _socketWriter = new SocketWriter(_clientSocket, _remoteIpEp);

            while (true)
            {
                Console.WriteLine("( \"BEISPIEL: \"+\"\\n\" + \"<Number> + (Message) \" +\"\\n\"+ \"GEBEN SIE EINE NACHRICHT EIN:\")");
                _socketWriter.SendMessageTo(Console.ReadLine());
            }
        }


        public static IPAddress CheckIP(string ip)
        {
            IPAddress validIP;
            string[] ipLength = ip.Split('.');
            if (ipLength.Length == 4)
            {
                if (IPAddress.TryParse(ip, out validIP))
                {
                    return validIP;
                }
            }
            return IPAddress.Loopback;
        }
    }
}
