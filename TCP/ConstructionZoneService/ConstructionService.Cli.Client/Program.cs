using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading.Tasks;
using ConstructionService.Shared;

namespace ConstructionService.Cli.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            IPAddress ip;
            Socket clientSocket;
            IPEndPoint ep;
            int port;
            SocketReader socketReader;
            SocketWriter socketWriter;
            FileInfo fi;
            string response = "";


            while (true)
            {
                Console.WriteLine("GEBEN SIE EINEN PORT AN...");
                string giveport = Console.ReadLine();
                port = Convert.ToInt32(giveport);
                if (port<1025 || port > 65536)
                {
                    port = 2004;
                }
                ip = IPAddress.Loopback;
                ep = new IPEndPoint(ip, port);
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket.Connect(ep);

                socketWriter = new SocketWriter(clientSocket);
                socketReader = new SocketReader(clientSocket);

                Console.WriteLine("GEBEN SIE EIN CMD EIN...");
                string cmd = Console.ReadLine().ToLower();
                string[] cmdparts = cmd.Split(' ');
                if (cmdparts[0] == "download")
                {
                    string path = @"Z:\ConstructionZoneService\ConstructionService.Cli.Client\bin\Debug\";
                    socketWriter.SendString(cmd);
                    for (int i = 1; i < cmdparts.Length; i++)
                    {
                        fi = new FileInfo(path + cmdparts[i]);
                        int length = (int)fi.Length;
                        socketWriter.SendString(length.ToString());
                        byte[] file = File.ReadAllBytes(path + cmdparts[i]);
                        socketWriter.SendFile(file);

                        response = socketReader.ReceiveString();
                        Console.WriteLine(response);
                    }
                }

                if (cmdparts[0] == "find")
                {
                    socketWriter.SendString(cmd);
                    response = socketReader.ReceiveString();
                    Console.WriteLine(response);
                }

                response = socketReader.ReceiveString();
                if (response =="exit")
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    Environment.Exit(0);
                }
                clientSocket.Close();
            }
        }
    }
}
