using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficCounting.Core
{
    public class Truck : Vehicle
    {
        public Truck(string vehicleID, string brand, string type, CountStation station) : base(vehicleID, brand, type, station)
        {
            type = "Truck";
        }

        public Truck(string vehicleID, string type) : base(vehicleID, type)
        {
            type = "Truck";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
