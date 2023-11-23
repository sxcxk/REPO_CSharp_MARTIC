using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHubService.Core
{
    public class LightHubInformation
    {
        private int _saturation;
        private int _brightness;
        private Color _color;
        private ColorTable _colorTable;
        private OnOff _onOff;


        public int Saturation { get => _saturation; set => _saturation = value; }
        public int Brightness { get => _brightness; set => _brightness = value; }
        public Color Color { get => _color; set => _color = value; }
        public ColorTable ColorTable { get => _colorTable; set => _colorTable = value; }
        public OnOff OnOff { get => _onOff; set => _onOff = value; }
        public LightHubInformation(int saturation, int brightness, Color color, ColorTable colorTable, OnOff onOff)
        {
            _saturation = saturation;
            _brightness = brightness;
            _color = color;
            _colorTable = colorTable;
            _onOff = onOff;
        }

        public LightHubInformation()
        {

        }


        public override string ToString()
        {
            int _saturationPercent = (_saturation * 100) / 15;
            int _brightnessPercent = (_brightness * 100) / 15;

            string _byte1 = Convert.ToString((int)_color, 2) + Convert.ToString((int)_colorTable, 2) + Convert.ToString((int)_onOff, 2);
            string _byte2 = Convert.ToString(_brightness, 2) + Convert.ToString(_saturation, 2);

            int _decByte1 = Convert.ToInt32(_byte1,2);
            int _decByte2 = Convert.ToInt32(_byte2,2);

            return "Byte 1: dezimal: " + _decByte1 + ", " + "Binär: " + _byte1 + "\n" + "Byte 2: dezimal: " + _decByte2 + ", " + "Binär: " + _byte2 + "\n " + "switch: " + _onOff + ", color: " + _color + ", sat: " + _saturationPercent + "%, " + "bri: " + _brightnessPercent + "%";
        }


    }
}
