using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHubService.Core
{
   public class LightHubRequestHandler
    {
        private byte[] _data;
        private string _response;
        public LightHubRequestHandler(byte[] data)
        {
            _data = data;
            _response = "";
        }

        public LightHubInformation GetResponse()
        {
            byte _byte1 = _data[0];
            byte _byte2 = _data[1];

            int _onOff = _byte1 & 1;
            int _colorTable = (_byte1 >> 1) & 7;
            int _color = _byte1 >> 4;

            int _saturation = _byte2 & 15;
            int _brightness = _byte2 >> 4;

            LightHubInformation _lightHubInformation = new LightHubInformation(_saturation, _brightness, (Color)_color, (ColorTable)_colorTable, (OnOff)_onOff);

            return _lightHubInformation;
        }
    }
}
