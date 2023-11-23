using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Construction.Service.Core
{
    public class RequestHandler
    {
        private string request;
        private FileList fileList;
        private string response;
        public RequestHandler(string request)
        {
            this.request = request;
            fileList = new FileList();
            response = "";
        }

        public string GetResponse()
        {
            string[] cmdparts = request.Split(' ');
            if (request =="exit")
            {
                response = "exit";
            }

            if (cmdparts[0] =="find")
            {
                response = "";
                List<string> stringList = fileList.GetDirectory(@"Z:\ConstructionZoneService\ConstructionService.Cli.Client\bin\Debug", false);
                for (int i = 0; i < stringList.Count; i++)
                {
                    response += "\r" + "\n" + stringList[i];
                }
            }

            return response;
        }
    }
}
