using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficCounting.Core
{
    public class Car : Vehicle
    {
        public Car(string vehicleID, string brand, string type, CountStation station) : base(vehicleID, brand, type, station)
        {
            type = "Car";
        }

        public Car(string vehicleID,string type) : base(vehicleID,type)
        {
            type = "Car";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
