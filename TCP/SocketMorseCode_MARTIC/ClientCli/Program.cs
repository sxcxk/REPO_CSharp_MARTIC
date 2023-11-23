using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace ClientCli
{
   public class Program
    {
        static void Main(string[] args)
        {
            Run();
            Console.ReadKey();


        }
        #region Methods
        public static void Run()
        {
            string response = "";
            string request = "";

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 2412;
            IPEndPoint ep = new IPEndPoint(ip, port);
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(ep);
            do
            {
                byte[] requestmsg = new byte[1024];
                Console.WriteLine("Geben Siw das jeweilige Kommando ein: (Klartext in Morsecode --> translate2mc <text> /// Morsecode in Klartext --> translaze2latin <Morsecode> ...)\n");
                Console.Write("mcp://");
                request = Console.ReadLine();
                requestmsg = Encoding.ASCII.GetBytes(request);
                clientSocket.Send(requestmsg);
                Console.WriteLine("Request gesendet...\n");
                Console.WriteLine("Warten...");

                byte[] responsemsg = new byte[1024];
                clientSocket.Receive(responsemsg);
                response = Encoding.ASCII.GetString(responsemsg);
                Console.Write("Response: " + response);

                if (response=="exit")
                {
                    Environment.Exit(0);
                }
            } while (true);
        }
        #endregion
    }
}
