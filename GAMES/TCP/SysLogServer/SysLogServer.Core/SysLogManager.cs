using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogServer.Core
{
    public class SysLogManager
    {
        private List<SysLogMessage> _sysLogs;
        private static SysLogManager _instance = null;

        public static SysLogManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SysLogManager();
                }
            return _instance;
            }
        }

        private SysLogManager()
        {
            _sysLogs = new List<SysLogMessage>();
        }
        
        public void AddMessage(SysLogMessage sysLogMessage)
        {
            _sysLogs.Add(sysLogMessage);
        }

        public List<SysLogMessage> GetList()
        {
            return _sysLogs;
        }
    }
}
