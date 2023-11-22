using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficCounting.Core
{
    public class OneLaneCar : Vehicle
    {
        public OneLaneCar(string vehicleID, string brand, string type, CountStation station) : base(vehicleID, brand, type, station)
        {
            type = "OneLaneCar";
        }

        public OneLaneCar(string vehicleID, string type) : base(vehicleID, type)
        {
            type = "OneLaneCar";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
