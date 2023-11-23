using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogServer.Core
{
    public interface IExport
    {
        void ExportFile(string filename);
    }
}
