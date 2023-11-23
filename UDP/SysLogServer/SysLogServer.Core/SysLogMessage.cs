using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SysLogServer.Core
{
    public class SysLogMessage
    {
        private int _priority;
        private FacilityValue _facilityValue;
        private SeverityValue _severityValue;
        private string _timeStamp;
        private string _message;
        private string _sourceIp;

        public FacilityValue FacilityValue { get => _facilityValue; set => _facilityValue = value; }
        public SeverityValue SeverityValue { get => _severityValue; set => _severityValue = value; }
        public string TimeStamp { get => _timeStamp; set => _timeStamp = value; }
        public string Message { get => _message; set => _message = value; }
        public string SourceIp { get => _sourceIp; set => _sourceIp = value; }

        public override string ToString()
        {
            _timeStamp = DateTime.Now.ToString();
            return _sourceIp.ToString() + ";" + _timeStamp.ToString() + ";" + _facilityValue.ToString() + ";" + _severityValue.ToString()+";"+_message;
        }



        public SysLogMessage(string request)
        {

            string[] data = request.Split(' ');

            _priority = Convert.ToInt32(data[0]);
            _message = data[1];
            _sourceIp = data[2];
            GetSeverity();
            GetFacility();
        }

        public void GetSeverity()
        {
            int severity = _priority & 7;
            _severityValue = (SeverityValue)severity;
        }

        public void GetFacility()
        {
            int facility = _priority >> 3;
            _facilityValue = (FacilityValue)facility;
        }
    }
}
