using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareInformationProtocol.Core
{
    public class HIPInformation
    {
        private Component _component;
        private Information _information;
        private Subsystem _subsystem;
        private Sensor _sensor;
        private string _message;

        public HIPInformation(Component component, Information information, Subsystem subsystem, Sensor sensor, string message)
        {
            _component = component;
            _information = information;
            _subsystem = subsystem;
            _sensor = sensor;
            _message = message;
        }

        public Component Component { get => _component; set => _component = value; }
        public Information Information { get => _information; set => _information = value; }
        public Subsystem Subsystem { get => _subsystem; set => _subsystem = value; }
        public Sensor Sensor { get => _sensor; set => _sensor = value; }
        public string Message { get => _message; set => _message = value; }



        public override string ToString()
        {
            return "Komponente[KO]: " + (int)_component + "\n" + "Subsystem[SU]: " + (int)_subsystem + "\n" + "Information[IN]: " + (int)_information + "\n" + "Sensor[SE]: " + (int)_sensor;
        }
    }


}
