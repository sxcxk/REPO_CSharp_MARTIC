using AlphabotLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabotLogic
{
    public class AlphabotRequestHandler
    {
        private string _request;
        private AlphabotInformation _alphabotInformation;
        public AlphabotRequestHandler(string request)
        {
            _request = request;
        }

        public AlphabotInformation GetResponse()
        {


            string[] _bytes = _request.Split(' ');

            for (int i = 0; i < _bytes.Length; i++)
            {
                _bytes[i] = _bytes[i].Trim('\0');
            }

            int _startbitsByte = Convert.ToInt32(_bytes[0]);
            string _startbits = Convert.ToString(_startbitsByte,2);

            if (_startbits.Substring(6,2) != "11")
            {
                _alphabotInformation = new AlphabotInformation(0, (DriveControl)5, (CollisionPrevention)6);
                return _alphabotInformation;
            }

            else
            {
                byte _num1byte = (byte)Convert.ToInt32(_bytes[0]);
                byte _num2byte = (byte)Convert.ToInt32(_bytes[1]);


                int _drivecontrol = (_num1byte >> 2) & 7;
                int _collisionprevention = _num1byte >> 5;
                int _speed = _num2byte & 255;

                _alphabotInformation = new AlphabotInformation(_speed, (DriveControl)_drivecontrol, (CollisionPrevention)_collisionprevention);
                return _alphabotInformation;
            }
           

        }
    }
}
