using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramControl.Service.Core
{
    public class TramWayInformation
    {
        private TramEnum _tramEnum;
        private byte[] _data;
        public TramWayInformation(TramEnum tramEnum)
        {
            _tramEnum = tramEnum;
        }

        public TramWayInformation(byte[] data)
        {
            _data = data;
            GetTramEnum();
        }


        public void GetTramEnum()
        {
            string tramEnumBin = Encoding.ASCII.GetString(_data);
            int tramEnum = Convert.ToInt32(tramEnumBin, 2);
            _tramEnum = (TramEnum)tramEnum;
        }

        public override string ToString()
        {
            int tramEnum = (int)_tramEnum;
            return tramEnum + ";" + _tramEnum;
        }

    }
}
