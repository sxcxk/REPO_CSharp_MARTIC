using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogServer.Core
{
    public enum FacilityValue
    {
        _kernel_messages = 0,
        _user_level_messages = 1,
        _mail_system = 2,
        _system_daemons = 3,
        security_authorization_messages = 4,
        _messages_generated_internally_by_syslogd = 5,
        _line_printer_subsystem = 6,
        _network_news_subsystem = 7,
        _uucp_subsystem = 8,
        _clock_daemon = 9,
        _security_authorization_messages2 = 10,
        _ftp_daemon = 11,
        _ntp_subsystem = 12,
        _log_audit = 13,
        _log_alert = 14,
        _clock_daemon2 = 15,
        _local0 = 16
    }
}
